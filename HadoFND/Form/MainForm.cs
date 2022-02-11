using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RJCP.IO.Ports;
using System.Data;
using System.Threading;
using System.Reflection;

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
        float currentTotalWeight = 0; // 현재 총 작업 중량
        float currentScaleValue = 0; // 현재 저울 계량값
        float beforeTotalWeight = 0; // 이전 총중량
        float currentAddWeight = 0; // 현재 추가 중량(kg)
        int currentAddWeightG = 0; // 현재 추가 중량(g)

        int stWeightCnt = 0; // 안정상태 계량값이 전달된 횟수를 체크하는 변수
        int beforeCurrentAddWeightG = 0; // 지금 출력된 계량값의 바로 이전에 출력된 계량값

        int selectedProductUnitWeight = 0; // 선택한 제품의 단위중량값
        int selectedProductHiValue = 0; // 선택한 제품의 상한값
        int selectedProductLoValue = 0; // 선택한 제품의 하한값

        SerialPortStream indicatorSerialPort;   // 인디케이터 시리얼 통신
        SerialPortStream ledSerialPort;   // 경광등 시리얼 통신

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetDefaultValue();
            TodayWorkRecords_Datagridview.DoubleBuffered(true);
        }

        //
        // 환경설정 파일 다시 로드하는 함수
        // 통신 관리에서 저장 버튼 누르면 변경 사항을 적용하기 위해 실행된다.
        //
        private void RefreshConfigFile()
        {
            _configFile = _configFile.Load();
        }

        //
        // 제품 목록 불러오는 함수
        // 제품 등록 또는 삭제 후 메인 화면에서 제품 목록 갱신한다.
        //
        private void RefreshProductList()
        {
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
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
            finally
            {
                
            }
        }

        //
        // 일일 작업 현황 조회
        //
        private void GetTodayWorkRecords()
        {
            var sqlselect = "";
            var startDate = DateTime.Today;
            var endDate = DateTime.Today.AddDays(1);

            //
            // 오늘 작업 완료된 데이터만 조회
            //
            sqlselect =
                "SELECT p.name AS 제품명, " +
                "w.weight AS 추가중량_g, w.work_count AS 작업수, w.created_at AS 작업일시 " +
                "FROM workrecord w " +
                "LEFT JOIN product p " +
                "ON w.product_id = p.id " +
                "WHERE DATE(w.created_at) BETWEEN @startDate AND @endDate " +
                //"WHERE w.is_finish =                                                                                                                                                TRUE AND DATE(w.created_at) BETWEEN @startDate AND @endDate " +
                "ORDER BY w.created_at DESC, w.work_count DESC";

            MySqlCommand cmd = new MySqlCommand(sqlselect, conn);
            cmd.Parameters.AddWithValue("@startDate", startDate);
            cmd.Parameters.AddWithValue("@endDate", endDate);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TodayWorkRecords_Datagridview.DataSource = dt;
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

            MadeByText_Label.Text = _configFile.Made_By;
            WebsiteUrlText_Label.Text = _configFile.Website_Url;
            SalePlaceStoreName_Label.Text = _configFile.Store_Name;
            SalePlaceStorePhone_Label.Text = _configFile.Store_Phone;
            SalePlaceStoreLeaderName_Label.Text = _configFile.Store_Leader_Name;
            AddressText_Label.Text = _configFile.Store_Address;           

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
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
            finally
            {
                //conn.Close();
            }

            //
            // 일일 현황 가져오기
            //
            GetTodayWorkRecords();
        }

        //
        // 통신 관리 페이지
        //
        private void SerialSetting_Button_Click(object sender, EventArgs e)
        {
            SerialSettingForm serialSettingForm = new SerialSettingForm();
            // 통신 관리 페이지에서 저장 누르면 환경 설정파일을 로드해서 변경된 값으로 바꿔주기 위한 이벤트 핸들러 설정            
            serialSettingForm.SerialSettingClosedEvent += new SerialSettingClosedEventHandler(this.RefreshConfigFile);
            serialSettingForm.ShowDialog();
        }

        //
        // 제품 관리 페이지
        //
        private void ProductManage_Button_Click(object sender, EventArgs e)
        {
            ProductManageForm productManageForm = new ProductManageForm();
            productManageForm.ProductManageClosedEvent += new ProductManageClosedEventHandler(this.RefreshProductList);
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
        // 엑셀 추출 페이지
        //
        private void ExcelExport_Button_Click(object sender, EventArgs e)
        {
            ExcelExportForm excelExportForm = new ExcelExportForm();
            excelExportForm.ShowDialog();
        }

        //
        // 작업 시작
        //
        private void WorkStart()
        {
            //
            // 제품 선택 여부 확인
            //
            if (Product_Name_Combobox.SelectedIndex < 0)
            {
                var text = "제품을 선택해주세요.";
                MessageBox.Show(text);
                return;
            }

            //
            // 상한, 하한 값 입력했는지 확인
            //
            if (Hi_Textbox.Text == "" || Hi_Textbox == null)
            {
                var text = "상한값을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (Lo_Textbox.Text == "" || Lo_Textbox == null)
            {
                var text = "하한값을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            selectedProductHiValue = Convert.ToInt32(Hi_Textbox.Text);
            selectedProductLoValue = Convert.ToInt32(Lo_Textbox.Text);
            if (selectedProductHiValue <= selectedProductUnitWeight)
            {
                var text = "상한값을 다시 설정해주세요.";
                MessageBox.Show(text);
                return;
            }
            if (selectedProductLoValue >= selectedProductUnitWeight)
            {
                var text = "하한값을 다시 설정해주세요.";
                MessageBox.Show(text);
                return;
            }

            //
            // 작업 수 입력했는지 확인
            //

            if(WorkCount_Textbox.Text == "" || WorkCount_Textbox == null)
            {
                var text = "작업수를 입력해주세요.";
                MessageBox.Show(text);
                return;
            }
            int workCnt = Convert.ToInt32(WorkCount_Textbox.Text);
            if (workCnt < 0)
            {
                var text = "작업수는 0이상의 값을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }
            currentWorkCount = workCnt;

            WorkStartEnd_Button.Text = "작업종료";

            //
            // 작업 시작 후 통신설정,제품관리,유저관리,엑셀추출,작업시작 버튼 안눌리도록 
            //
            SerialSetting_Button.Enabled = false;
            ProductManage_Button.Enabled = false;
            UserManage_Button.Enabled = false;
            ExcelExport_Button.Enabled = false;
            Product_Name_Combobox.Enabled = false;
            DB_Backup_Button.Enabled = false;

            //
            // 상한, 하한 입력 안되도록
            //

            Hi_Textbox.Enabled = false;
            Lo_Textbox.Enabled = false;

            //
            // 작업수 입력 안되도록
            //
            WorkCount_Textbox.Enabled = false;

            //
            // 선택한 제품으로 가장 최근에 작업을 했으나 작업완료를 하지 못한 기록이 있는지 검색하기
            //
            var selectedProductId = Product_Name_Combobox.SelectedValue;
            try
            {
                var sqlselect = "SELECT * FROM workrecord WHERE product_id = @product_id ORDER BY created_at DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sqlselect, conn);
                cmd.Parameters.AddWithValue("@product_id", selectedProductId);
                MySqlDataReader dr = cmd.ExecuteReader();


                // 작업 새로 시작하는 경우
                // 1)선택한 제품으로 작업한 기록이 아예 없거나
                // 2)완료한 기록만 있을 경우
                WorkDate_Textbox.Text = DateTime.Now.ToString("yyyy.MM.dd");
                WorkCount_Textbox.Text = currentWorkCount.ToString();

                /*
                 프로그램이 갑작스럽게 종료되거나 작업 종료를 누르지 못하고 끈 경우
                플랫폼에 종료 전에 올려뒀던 물건을 그대로 둔 후 프로그램을 다시 시작하면
                이전 작업에 이어서 작업을 진행할 수 있다.
                 */
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
                        // 총 작업 중량과 이전 총 중량을 DB에서 가져온 값으로 설정
                        currentTotalWeight = workRecord.total_weight;
                        beforeTotalWeight = workRecord.total_weight;

                        // 총 작업 중량 표시
                        //TotalWeight_HtmlLabel.Text = currentTotalWeight.ToString("F2");
                        TotalWeightText_Label.Text = currentTotalWeight.ToString("F2");
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
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
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
                // 인디케이터 시리얼 통신 연결
                indicatorSerialPort = new SerialPortStream(_configFile.Comport, _configFile.BaudRate, _configFile.DataBits, _configFile.Parity, _configFile.StopBits);

                indicatorSerialPort.DataReceived += indicatorSerialPort_DataReceived;
                indicatorSerialPort.Open();

                // 경광등 시리얼 통신 연결
                ledSerialPort = new SerialPortStream(_configFile.Led_Comport, _configFile.Led_BaudRate, _configFile.Led_DataBits, _configFile.Led_Parity, _configFile.Led_StopBits);

                ledSerialPort.Open();

                ////
                //// 영점 잡기
                ////
                //indicatorSerialPort.Write("MZ\r\n");
            }
            catch (Exception ex)
            {
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
        }

        //
        // 작업 종료
        //
        private void WorkEnd()
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
                    if (workRecordId.Equals("") || workRecordId == null)
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
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
            finally
            {
                MessageBox.Show("작업이 종료 되었습니다.");
                conn.Close();
                //
                // 시리얼 포트 닫기
                //
                try
                {
                    // 경광등 모두 종료
                    ledSerialPort.Write("C\r\n");

                    indicatorSerialPort.Close();
                    ledSerialPort.Close();
                }
                catch (Exception ex)
                {
                    Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
                }

                WorkStartEnd_Button.Text = "작업시작";

                //
                // 버튼 활성/비활성화
                //
                SerialSetting_Button.Enabled = true;
                ProductManage_Button.Enabled = true;
                UserManage_Button.Enabled = true;
                ExcelExport_Button.Enabled = true;
                Product_Name_Combobox.Enabled = true;
                DB_Backup_Button.Enabled = true;

                //
                // 상한, 하한 입력 되도록
                //
                Hi_Textbox.Enabled = true;
                Lo_Textbox.Enabled = true;

                //
                // 작업수 입력 되도록
                //
                WorkCount_Textbox.Enabled = true;

                currentWorkCount = 0; // 현재 작업수
                currentTotalWeight = 0; // 총 작업 중량
                currentScaleValue = 0; // 저울 계량값
                beforeTotalWeight = 0; // 이전 총중량
                currentAddWeight = 0; // 현재 추가 중량(kg)
                currentAddWeightG = 0; // 현재 추가 중량(g)
                beforeCurrentAddWeightG = 0; // 직전 현재 추가 중량(g)

                // 총 작업 중량 표시 초기화
                TotalWeightText_Label.Text = currentTotalWeight.ToString("F2");
                //// 저울 계량값 표시 초기화
                //ScaleValueText_Label.Text = currentScaleValue.ToString("F2");
                // 현재 추가 중량 표시 초기화
                WeightText_Label.Text = currentAddWeightG.ToString();
                // 작업수 표시 초기화
                WorkCount_Textbox.Text = currentWorkCount.ToString();
            }
        }


        //
        // 작업 시작/종료 버튼 클릭
        //
        private void WorkStartEnd_Button_Click(object sender, EventArgs e)
        {
            // 작업 시작 호출
            if(WorkStartEnd_Button.Text == "작업시작")
            {
                stWeightCnt = 0;
                WorkStart();
            }
            // 작업 종료 호출
            else
            {
                WorkEnd();
            }
        }

        //
        // 인디케이터 시리얼 수신 이벤트가 발생하면 아래 부분이 실행된다.
        //
        private void indicatorSerialPort_DataReceived(object sender, RJCP.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(IndicatorSerialReceived)); // 메인 쓰레드와 수신 쓰레드의 충돌을 방지하기 위해 Invoke 사용. IndicatorSerialReceived로 이동하여 추가 작업 실행.            
        }

        //
        // 인디케이터 시리얼 수신 데이터 처리
        //
        private void IndicatorSerialReceived(object s, EventArgs e)
        {
            try
            {
                var receivedData = indicatorSerialPort.ReadLine(); // 시리얼 통신으로 받아온 데이터

                var header1 = ""; // 첫번째 헤더( ST: 안정 / US: 불안정 / OL: 오버플로우 )
                var header2 = ""; // 두번째 헤더( GS: 총중량 / NT: 순중량 / TR: 용기 )
                var contents = ""; // 데이터( 극성, 소수점 포함 8자리 + 단위 2자리 = 총 10자리 )

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

                var onlyNumber = contents.Substring(0, 8);

                // 시리얼 데이터에서 계량값(숫자만) 추출해서 저울 계량값에 표시
                currentScaleValue = float.Parse(onlyNumber);
                //ScaleValueText_Label.Text = currentScaleValue.ToString("F2");

                // 추가 중량 = 저울 계량값 - 이전 총 중량
                currentAddWeight = currentScaleValue - beforeTotalWeight;

                // 추가 중량 g단위
                currentAddWeightG = (int)(currentAddWeight * 1000);

                // 추가 중량 표시
                WeightText_Label.Text = currentAddWeightG.ToString();

                //
                // 계량값 안정(ST)일때만 처리
                //
                if (header1 == "ST")
                {
                    if(currentAddWeightG == beforeCurrentAddWeightG)
                    {
                        stWeightCnt++;

                        //
                        // 현재 추가 중량이 최소 무게보다 클 경우에 작업으로 기록
                        //
                        if (currentAddWeightG > _configFile.Min_Weight)
                        {
                            if (stWeightCnt >= 10)
                            {
                                //
                                // 경광등으로 신호 전달
                                //
                                var state = "";

                                // LO 적색등
                                if (currentAddWeightG <= selectedProductLoValue)
                                {
                                    ledSerialPort.Write("L\r\n");
                                    state = "LO";
                                }
                                // HI 황색등
                                else if (currentAddWeightG >= selectedProductHiValue)
                                {
                                    ledSerialPort.Write("H\r\n");
                                    state = "HI";
                                }
                                // OK 녹색등
                                else
                                {
                                    ledSerialPort.Write("O\r\n");
                                    state = "OK";
                                }

                                //
                                // 현재 추가 중량 및 총 중량 DB에 기록
                                //

                                // 작업수 +1
                                currentWorkCount++;
                                //// 총 작업 중량 = 총 작업 중량 + 추가 중량
                                //currentTotalWeight += currentAddWeight;

                                try
                                {
                                    var sqlInsert = "INSERT INTO workrecord ( id, user_id, product_id, weight, total_weight, work_count, is_finish, created_at, state ) VALUES (@id, @user_id, @product_id, @weight, @total_weight, @work_count, @is_finish, @created_at, @state)";
                                    MySqlCommand cmd = new MySqlCommand(sqlInsert, conn);

                                    cmd.Parameters.AddWithValue("@id", Guid.NewGuid().ToString());
                                    cmd.Parameters.AddWithValue("@user_id", currentUserId);
                                    cmd.Parameters.AddWithValue("@product_id", Product_Name_Combobox.SelectedValue);
                                    cmd.Parameters.AddWithValue("@weight", currentAddWeightG);
                                    cmd.Parameters.AddWithValue("@total_weight", currentScaleValue);
                                    cmd.Parameters.AddWithValue("@work_count", currentWorkCount);
                                    cmd.Parameters.AddWithValue("@is_finish", false);
                                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                                    cmd.Parameters.AddWithValue("@state", state);

                                    conn.Open();
                                    cmd.ExecuteNonQuery();

                                    GetTodayWorkRecords();
                                }
                                catch (Exception ex)
                                {
                                    Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
                                }
                                finally
                                {
                                    conn.Close();
                                    // 이전 총 중량 = 이전 총 중량 + 추가 중량
                                    beforeTotalWeight += currentAddWeight;
                                    TotalWeightText_Label.Text = currentScaleValue.ToString("F2");
                                    // 작업 수 갱신
                                    WorkCount_Textbox.Text = currentWorkCount.ToString();
                                    stWeightCnt = 0;
                                    beforeCurrentAddWeightG = 0;
                                }
                            }
                        }

                        /*
                            플랫폼에 더이상 물건을 올릴 수 없을 때 물건을 모두 내리고 다시 올린다.
                            이 때 추가 중량은 0보다 작은 값이 나올 것이다.
                            물건을 모두 내렸으므로 작업을 처음 시작하는 것과 동일하게 이전 총 중량을 0으로 리셋해야한다.
                            단, 저울 계량값이 최소 무게보다 작을 경우에만 이전 총 중량을 0으로 리셋한다.
                         */
                        else
                        {
                            beforeTotalWeight = currentScaleValue;
                            TotalWeightText_Label.Text = currentScaleValue.ToString("F2");
                            //if ((int)(currentScaleValue * 1000) < _configFile.Min_Weight)
                            //{
                            //    // 이전 총 중량을 0으로 리셋
                            //    beforeTotalWeight = 0;
                            //}
                        }
                    }
                    else
                    {
                        stWeightCnt = 0;
                    }

                    beforeCurrentAddWeightG = currentAddWeightG;
                }
            }
            catch(Exception ex)
            {
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
        }
                
        //
        // 콤보박스에서 제품 선택 시 상한, 하한 값 표시
        //
        private void Product_Name_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProductId = "";
            if (Product_Name_Combobox.SelectedIndex >= 0)
            {
                var selectedProduct = productList[Product_Name_Combobox.SelectedIndex];

                // 선택한 제품의 id값
                currentProductId = selectedProduct.id;

                // 선택한 제품의 단위중량값
                selectedProductUnitWeight = selectedProduct.unit_weight;
                ProductUnitWeight_Textbox.Text = selectedProduct.unit_weight.ToString();

                selectedProductHiValue = selectedProduct.unit_weight + _configFile.Hi_Value;
                selectedProductLoValue = selectedProduct.unit_weight - _configFile.Lo_Value;
                Hi_Textbox.Text = selectedProductHiValue.ToString();
                Lo_Textbox.Text = selectedProductLoValue.ToString();
            }
        }

        //
        // 경광등 켜기 버튼
        //
        private void LedOn_Button_Click(object sender, EventArgs e)
        {
            //
            // 경광등 시리얼 통신 연결 여부 확인
            //
            try
            {
                if (ledSerialPort == null)
                {
                    ledSerialPort = new SerialPortStream(_configFile.Led_Comport, _configFile.Led_BaudRate, _configFile.Led_DataBits, _configFile.Led_Parity, _configFile.Led_StopBits);
                    ledSerialPort.Open();
                }
                else
                {
                    if (!ledSerialPort.IsOpen)
                    {
                        ledSerialPort.Open();   
                    }
                }
                
                //
                // 전체 신호 0.5초 간격으로 보내기
                //
                ledSerialPort.Write("O\r\n");
                Thread.Sleep(500);
                ledSerialPort.Write("L\r\n");
                Thread.Sleep(500);
                ledSerialPort.Write("H\r\n");
            }
            catch (Exception ex)
            {
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
        }

        //
        // 경광등 끄기 버튼
        //
        private void LedOff_Button_Click(object sender, EventArgs e)
        {
            //
            // 경광등 시리얼 통신 연결 여부 확인
            //
            try
            {
                if (ledSerialPort == null)
                {
                    ledSerialPort = new SerialPortStream(_configFile.Led_Comport, _configFile.Led_BaudRate, _configFile.Led_DataBits, _configFile.Led_Parity, _configFile.Led_StopBits);
                    ledSerialPort.Open();
                }
                else
                {
                    if (!ledSerialPort.IsOpen)
                    {
                        ledSerialPort.Open();
                    }
                }

                //
                // 끄기 신호 보내기
                //
                ledSerialPort.Write("C\r\n");
            }
            catch (Exception ex)
            {
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
        }

        private void Hi_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void Lo_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        //
        // DB 백업 버튼
        // 참고 사이트
        // https://kwikedemy.com/create-backup-and-restore-of-mysql-database-using-winform-application-c/
        //
        private void DB_Backup_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                var connectString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", _configFile.Db_IP, _configFile.Db_NAME, _configFile.Db_ID, _configFile.Db_PW);
                var currentDate = DateTime.Now.ToString("yyyyMMdd");
                using (MySqlConnection conn = new MySqlConnection(connectString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(_configFile.File_Path + "\\backup_" + currentDate + ".sql");
                            conn.Close();                            
                            MessageBox.Show("DB 백업이 완료되었습니다.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
            finally
            {
                Cursor.Current = Cursors.AppStarting;
            }
        }

        private void WorkCount_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }        
    }

    //
    // DataGridView 더블버퍼 추가하여 속도 개선
    //
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
