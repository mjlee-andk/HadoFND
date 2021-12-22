using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace HadoFND
{
    public partial class MainForm : MetroFramework.Forms.MetroForm // 상속 클래스 변경
    {
        ConfigFile _configFile = new ConfigFile();

        // DB 연결 및 데이터 가져오기        
        MySqlConnection conn;

        List<DataFormat.Product> productList; // 제품 목록
        
        public static string currentUserId; // 현재 로그인한 계정 id
        string currentProductId = ""; // 현재 작업중인 제품 id

        int currentWorkCount = 0; // 현재 작업수
        int currentTotalWeight = 0; // 현재 총중량
        int beforeTotalWeight = 0; // 이전 총중량
        int currentAddWeight = 0; // 현재 추가 중량

        int selectedProductHiValue = 0; // 선택한 제품의 상한값
        int selectedProductLoValue = 0; // 선택한 제품의 하한값

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetDefaultValue();            
        }

        //
        // 환경설정 파일 다시 로드하는 함수
        // 통신 관리에서 변동사항 있을 경우 실행된다.
        //
        private void RefreshConfigFile()
        {
            _configFile = _configFile.Load();
        }

        //
        // 폼 로드시 가져오는 데이터
        //
        private void SetDefaultValue()
        {
            //
            // 환경설정 파일 로드
            //
            _configFile = _configFile.Load();

            //
            // DB에 등록된 제품 로드
            //
            try
            {
                string connectString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", _configFile.Db_IP, _configFile.Db_NAME, _configFile.Db_ID, _configFile.Db_PW);
                conn = new MySqlConnection(connectString);
                conn.Open();

                var sqlselect = "SELECT * FROM product WHERE deleted_at is null;";
                MySqlCommand cmd = new MySqlCommand(sqlselect, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                // 등록된 제품 없을 경우 제품 등록 안내
                if (!dr.HasRows)
                {
                    var text = "등록된 제품이 없습니다. 제품 관리에서 제품을 입력 후 프로그램을 재시작해주세요.";
                    MessageBox.Show(text);
                    return;
                }

                productList = new List<DataFormat.Product>();
                while (dr.Read())
                {
                    var product = new DataFormat.Product();
                    product.id = dr["id"].ToString();
                    product.name = dr["name"].ToString();
                    product.unit_weight = Convert.ToInt32(dr["unit_weight"]);
                    product.code_number = Convert.ToInt32(dr["code_number"]);
                    product.created_at = Convert.ToDateTime(dr["created_at"]);
                    product.deleted_at = null;

                    productList.Add(product);
                }
                Product_Name_Combobox.DisplayMember = "name";
                Product_Name_Combobox.ValueMember = "id";
                Product_Name_Combobox.DataSource = productList;
                Product_Name_Combobox.SelectedIndex = -1;

                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            //
            // 일일 현황 가져오기
            //
        }

        //
        // 통신 관리 페이지
        //
        private void SerialSetting_Button_Click(object sender, EventArgs e)
        {
            SerialSettingForm serialSettingForm = new SerialSettingForm();
            serialSettingForm.SerialSettingClosedEvent += new SerialSettingClosedEventHandler(this.RefreshConfigFile);
            serialSettingForm.ShowDialog();
        }

        //
        // 제품 관리 페이지
        //
        private void ProductManage_Button_Click(object sender, EventArgs e)
        {
            ProductManageForm productManageForm = new ProductManageForm();
            productManageForm.ShowDialog();
        }

        //
        // 유저 관리 페이지
        //
        private void UserManage_Button_Click(object sender, EventArgs e)
        {
            UserManageForm userManageForm = new UserManageForm();
            userManageForm.ShowDialog();
        }
                
        //
        // 작업 시작 버튼 클릭
        //
        private void WorkStart_Button_Click(object sender, EventArgs e)
        {
            //
            // 제품 선택 여부 확인
            //
            if(Product_Name_Combobox.SelectedIndex < 0)
            {
                var text = "제품을 선택해주세요.";
                MessageBox.Show(text);
                return;
            }

            //
            // 작업 시작 후 통신설정,제품관리,유저관리,엑셀추출,작업시작 버튼 안눌리도록 
            //
            SerialSetting_Button.Enabled = false;
            ProductManage_Button.Enabled = false;
            UserManage_Button.Enabled = false;
            ExcelExport_Button.Enabled = false;
            WorkStart_Button.Enabled = false;
            WorkEnd_Button.Enabled = true;
            Product_Name_Combobox.Enabled = false;

            //
            // 선택한 제품으로 가장 최근에 작업을 했으나 작업완료를 하지 못한 기록이 있는지 검색하기
            //
            var selectedProductId = Product_Name_Combobox.SelectedValue;
            try
            {
                conn.Open();
                var sqlselect = "SELECT * FROM workrecord WHERE product_id = @product_id ORDER BY created_at DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sqlselect, conn);
                cmd.Parameters.AddWithValue("@product_id", selectedProductId);
                MySqlDataReader dr = cmd.ExecuteReader();


                // 작업 새로 시작하는 경우
                // 1)선택한 제품으로 작업한 기록이 아예 없거나
                // 2)완료한 기록만 있을 경우
                WorkDate_Textbox.Text = DateTime.Now.ToString("yyyy.MM.dd");
                WorkCount_Textbox.Text = currentWorkCount.ToString();

                // 미완료된 작업이 남아있는 경우
                if (dr.HasRows)
                {
                    dr.Read();

                    var workRecord = new DataFormat.WorkRecord();
                    workRecord.total_weight = Convert.ToInt32(dr["total_weight"]);
                    workRecord.work_count = Convert.ToInt32(dr["work_count"]);
                    workRecord.is_finish = Convert.ToBoolean(dr["is_finish"]);
                    workRecord.created_at = Convert.ToDateTime(dr["created_at"]);

                    // 해당 제품의 최신 기록의 is_finish 값이 false일 경우 작업이 완료되지 않았음을 의미
                    if (!workRecord.is_finish)
                    {
                        // 현재 총중량, 이전 총중량을 DB에서 읽어온 값으로 설정
                        currentTotalWeight = workRecord.total_weight;
                        beforeTotalWeight = workRecord.total_weight;

                        // 총중량 표시
                        TotalWeight_Textbox.Text = currentTotalWeight.ToString();
                        // 추가 중량 표시
                        Weight_Textbox.Text = (currentTotalWeight - beforeTotalWeight).ToString();
                        // 작업일자 표시
                        WorkDate_Textbox.Text = workRecord.created_at.ToString("yyyy.MM.dd");
                        // 작업수 DB에서 읽어온 값으로 설정 및 표시
                        currentWorkCount = workRecord.work_count;
                        WorkCount_Textbox.Text = currentWorkCount.ToString();
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            //
            // 시리얼 통신 연결 여부 확인
            //
            try
            {
                if (indicatorSerialPort == null)
                {
                    indicatorSerialPort = new SerialPort();
                }

                if (!indicatorSerialPort.IsOpen) // 연결 끊겨 있을 경우
                {
                    indicatorSerialPort.PortName = _configFile.Comport;
                    indicatorSerialPort.BaudRate = _configFile.BaudRate;
                    indicatorSerialPort.DataBits = _configFile.DataBits;
                    indicatorSerialPort.Parity = _configFile.Parity;
                    indicatorSerialPort.StopBits = _configFile.StopBits;

                    indicatorSerialPort.DataReceived += new SerialDataReceivedEventHandler(indicatorSerialPort_DataReceived);

                    indicatorSerialPort.Open();
                }

                //
                // 영점 잡기
                //
                indicatorSerialPort.Write("MZ\r\n");
            }
            catch(Exception ex)
            {
                var text = "시리얼 통신 연결 오류";
                MessageBox.Show(text);
                return;
            }
        }

        //
        // 작업 종료 버튼 클릭
        //

        private void WorkEnd_Button_Click(object sender, EventArgs e)
        {
            try
            {
                //
                // 가장 마지막으로 작업한 데이터를 작업 완료로 표시
                //
                conn.Open();
                var sqlselect = "SELECT * FROM workrecord WHERE product_id = @product_id ORDER BY created_at DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sqlselect, conn);
                cmd.Parameters.AddWithValue("@product_id", currentProductId);
                MySqlDataReader dr = cmd.ExecuteReader();

                // 데이터 있는 경우
                if (dr.HasRows)
                {
                    dr.Read();

                    var workRecordId = dr["id"];
                    if(workRecordId.Equals("") || workRecordId == null)
                    {
                        return;
                    }

                    dr.Close();

                    // is_finish 를 true로 변경
                    var sqlUpdate = "UPDATE workrecord SET is_finish = @is_finish WHERE id = @work_record_id;";
                    cmd = new MySqlCommand(sqlUpdate, conn);
                    cmd.Parameters.AddWithValue("@is_finish", true);
                    cmd.Parameters.AddWithValue("@work_record_id", workRecordId);

                    cmd.ExecuteNonQuery();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
                MessageBox.Show("작업이 종료 되었습니다.");
                //
                // 버튼 활성/비활성화
                //
                SerialSetting_Button.Enabled = true;
                ProductManage_Button.Enabled = true;
                UserManage_Button.Enabled = true;
                ExcelExport_Button.Enabled = true;
                WorkStart_Button.Enabled = true;
                WorkEnd_Button.Enabled = false;
                Product_Name_Combobox.Enabled = true;
            }
        }

        //
        // 시리얼 수신 이벤트가 발생하면 아래 부분이 실행된다.
        //
        private void indicatorSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(IndicatorSerialReceived)); // 메인 쓰레드와 수신 쓰레드의 충돌을 방지하기 위해 Invoke 사용. IndicatorSerialReceived로 이동하여 추가 작업 실행.
        }

        //
        // 시리얼 수신 데이터 처리
        //
        private void IndicatorSerialReceived(object s, EventArgs e)
        {
            try
            {
                var receivedData = indicatorSerialPort.ReadLine(); // 시리얼 통신으로 받아온 데이터

                var header1 = ""; // 첫번째 헤더( ST: 안정 US: 불안정 OL: 오버플로우 )
                var header2 = ""; // 두번째 헤더( GS: 총중량 NT: 순중량 TR: 용기 )
                var contents = ""; // 데이터( 극성, 소수점 포함 8자리 + 단위 2자리 )

                var words = receivedData.Split(',');
                if (words.Length < 3)
                {
                    return;
                }
                header1 = words[0];
                header2 = words[1];
                contents = words[2];

                if (contents == null || contents.Equals(""))
                {
                    return;
                }

                // 시리얼 데이터에서 계량값(숫자만) 추출해서 현재 총 중량에 표시
                currentTotalWeight = Convert.ToInt32(Regex.Replace(contents, @"\D", ""));
                TotalWeight_Textbox.Text = currentTotalWeight.ToString();

                currentAddWeight = currentTotalWeight - beforeTotalWeight;

                // 추가 중량에 현재 총중량 - 이전 총중량 값 표시
                Weight_Textbox.Text = currentAddWeight.ToString();

                //
                // 계량값 안정(ST)일때만 처리
                //
                if (header1 == "ST")
                {
                    //
                    // 현재 추가 중량이 최소 무게보다 클 경우에 작업으로 기록
                    //
                    if (currentAddWeight > _configFile.Min_Weight)
                    {
                        //
                        // 현재 추가 중량이 상한 또는 하한 값 범위를 벗어나면 경광등으로 신호 전달
                        //
                        if (currentAddWeight < selectedProductLoValue || currentAddWeight > selectedProductHiValue)
                        {
                            //
                            // 경광등으로 신호 전달
                            //                            
                        }
                        //
                        // 현재 추가 중량 및 총 중량 DB에 기록
                        //
                        else
                        {
                            // 작업수 +1
                            currentWorkCount++;

                            try
                            {
                                var sqlInsert = "INSERT INTO workrecord ( id, user_id, product_id, weight, total_weight, work_count, is_finish, created_at ) VALUES (@id, @user_id, @product_id, @weight, @total_weight, @work_count, @is_finish, @created_at)";
                                MySqlCommand cmd = new MySqlCommand(sqlInsert, conn);

                                cmd.Parameters.AddWithValue("@id", Guid.NewGuid().ToString());
                                cmd.Parameters.AddWithValue("@user_id", currentUserId);
                                cmd.Parameters.AddWithValue("@product_id", Product_Name_Combobox.SelectedValue);
                                cmd.Parameters.AddWithValue("@weight", currentTotalWeight - beforeTotalWeight);
                                cmd.Parameters.AddWithValue("@total_weight", currentTotalWeight);
                                cmd.Parameters.AddWithValue("@work_count", currentWorkCount);
                                cmd.Parameters.AddWithValue("@is_finish", false);
                                cmd.Parameters.AddWithValue("@created_at", DateTime.Now);

                                conn.Open();
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {

                            }
                            finally
                            {
                                conn.Close();
                                // 이전 총 중량에 현재 총 중량 넣기
                                beforeTotalWeight = currentTotalWeight;
                                // 작업 수 갱신
                                WorkCount_Textbox.Text = currentWorkCount.ToString();
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                
            }            
        }

        //
        // 엑셀 추출 페이지
        //
        private void ExcelExport_Button_Click(object sender, EventArgs e)
        {
            var fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "ExcelReport.xlsx";
            Excel.Application xlsApp;
            Excel.Workbook xlsWorkbook;
            Excel.Worksheet xlsWorksheet;
            object misValue = System.Reflection.Missing.Value;

            // 이전 엑셀 파일 삭제
            try
            {
                FileInfo oldFile = new FileInfo(fileName);
                if (oldFile.Exists)
                {
                    File.SetAttributes(oldFile.FullName, FileAttributes.Normal);
                    oldFile.Delete();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error removing old Excel report: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // 새로운 파일 생성
            xlsApp = new Excel.Application();
            xlsWorkbook = xlsApp.Workbooks.Add(misValue);
            xlsWorksheet = (Excel.Worksheet)xlsWorkbook.Sheets[1];

            

            var sqlselect = "SELECT * FROM scales;";
            MySqlCommand cmd = new MySqlCommand(sqlselect, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            //
            // 엑셀의 row, column은 인덱스가 1부터 시작한다.
            //

            // DB 컬럼명 입력
            var i = 1;
            if (dr.HasRows)
            {
                for (int j = 1; j < dr.FieldCount; ++j) 
                {
                    xlsWorksheet.Cells[i, j] = dr.GetName(j); // 211220 dr.GetName(j)의 j를 j-1로 변경할 것
                }
                ++i;
            }
            // DB 컬럼명에 해당하는 데이터 입력
            while (dr.Read())
            {
                for (int j = 1; j < dr.FieldCount; ++j) // 211220 j < dr.FieldCount를 j <= dr.FieldCount로 변경할 것
                {
                    xlsWorksheet.Cells[i, j] = dr.GetValue(j); // 211220 dr.GetValue(j)의 j를 j-1로 변경할 것
                }                    
                ++i;
            }

            xlsWorkbook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue,
    misValue, misValue,
    Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges,
    misValue, misValue, misValue, misValue);
            xlsWorkbook.Close(true, misValue, misValue);
            xlsApp.Quit();

            releaseObject(xlsWorksheet);
            releaseObject(xlsWorkbook);
            releaseObject(xlsApp);
            
        }

        //
        // 엑셀 객체 생성 후 객체 해제를 위한 함수
        //
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        //
        // 콤보박스에서 제품 선택 시 상한, 하한 값 표시
        //
        private void Product_Name_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Product_Name_Combobox.SelectedIndex >= 0)
            {
                var selectedProduct = productList[Product_Name_Combobox.SelectedIndex];

                // 선택한 제품의 id값
                currentProductId = selectedProduct.id;

                selectedProductHiValue = selectedProduct.unit_weight + _configFile.Hi_Value;
                selectedProductLoValue = selectedProduct.unit_weight - _configFile.Lo_Value;
                Hi_Textbox.Text = selectedProductHiValue.ToString();
                Lo_Textbox.Text = selectedProductLoValue.ToString();
            }            
        }

    }
}
