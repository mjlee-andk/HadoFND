using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace HadoFND
{
    public partial class ExcelExportForm : MetroFramework.Forms.MetroForm // 상속 클래스 변경
    {
        ConfigFile _configFile = new ConfigFile();

        // DB 연결 및 데이터 가져오기        
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        List<DataFormat.Product> productList; // 제품 목록
        string currentProductId = ""; // 현재 선택된 제품 id

        public ExcelExportForm()
        {
            InitializeComponent();
        }

        private void ExcelExportForm_Load(object sender, EventArgs e)
        {
            //
            // 환경설정 파일 로드
            //
            _configFile = _configFile.Load();

            //
            // 환경 설정 파일에서 파일 저장 위치 불러와서 표시
            //
            FilePath_TextBox.Text = _configFile.File_Path;

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
                    var text = "DB에 등록된 제품이 없어서 작업 기록 검색을 할 수 없습니다.";
                    MessageBox.Show(text);
                    this.Close();
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
                ProductList_Combobox.DisplayMember = "name";
                ProductList_Combobox.ValueMember = "id";
                ProductList_Combobox.DataSource = productList;
                ProductList_Combobox.SelectedIndex = -1;

                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        //
        // 파일 저장 위치 설정 버튼
        //
        private void FilePath_Button_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.SelectedPath = @"C:\";
            dialog.ShowDialog();
            string selected = dialog.SelectedPath;

            // 환경설정 파일에 저장
            _configFile.File_Path = selected;
            _configFile.Save();

            // 저장한 경로 화면에 표시
            FilePath_TextBox.Text = selected;
        }

        private void ProductList_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProductId = "";
            if (ProductList_Combobox.SelectedIndex >= 0)
            {
                var selectedProduct = productList[ProductList_Combobox.SelectedIndex];

                // 선택한 제품의 id값
                currentProductId = selectedProduct.id;
            }
        }

        //
        // 특정 제품 조회 버튼 클릭
        //
        private void Search_Button_Click(object sender, EventArgs e)
        {
            //
            // 제품 선택 여부 확인
            //
            if (currentProductId.Equals("") || currentProductId == null)
            {
                var text = "제품을 선택해주세요.";
                MessageBox.Show(text);
                return;
            }

            var startDate = Convert.ToDateTime(DateStart_DateTime.Text);
            // 종료날짜에 +1일을 하는 이유는 쿼리에서 BETWEEN 연산자 때문
            // ex) BETWEEN '2021-12-22' AND '2021-12-23' 이면 22일 데이터만 조회됨.
            var endDate = Convert.ToDateTime(DateEnd_DateTime.Text).AddDays(1);

            //
            // 날짜 선택 확인
            //
            if(startDate > endDate)
            {
                var text = "날짜 선택을 다시 해주세요.";
                MessageBox.Show(text);
                return;
            }

            selectWorkRecord(startDate, endDate);
        }

        //
        // 전체 제품 조회 버튼
        //
        private void AllSearch_Button_Click(object sender, EventArgs e)
        {
            //
            // 제품 선택 여부와 상관없이 시작날짜와 종료날짜 사이의 작업기록을 모두 검색한다.
            //

            var startDate = Convert.ToDateTime(DateStart_DateTime.Text);
            // 종료날짜에 +1일을 하는 이유는 쿼리에서 BETWEEN 연산자 때문
            // ex) BETWEEN '2021-12-22' AND '2021-12-23' 이면 22일 데이터만 조회됨.
            var endDate = Convert.ToDateTime(DateEnd_DateTime.Text).AddDays(1);

            //
            // 날짜 선택 확인
            //
            if (startDate > endDate)
            {
                var text = "날짜 선택을 다시 해주세요.";
                MessageBox.Show(text);
                return;
            }

            selectWorkRecord(startDate, endDate);
        }

        private void selectWorkRecord(DateTime startDate, DateTime endDate)
        {
            var sqlselect = "";
            try
            {
                conn.Open();                
                
                // 전체 조회
                if (currentProductId.Equals("") || currentProductId == null)
                {
                    sqlselect =
                    "SELECT p.code_number AS Code, p.name AS Name, p.unit_weight AS UnitWeight, " +
                    "w.weight AS AddWeight, w.total_weight AS TotalWeight, w.work_count AS WorkCount, w.created_at AS CreatedAt " +
                    "FROM workrecord w " +
                    "LEFT JOIN product p " +
                    "ON w.product_id = p.id " +
                    "WHERE DATE(w.created_at) BETWEEN @startDate AND @endDate " +
                    "ORDER BY w.created_at ASC, w.work_count ASC";
                }
                // 특정 제품 조회
                else
                {
                    sqlselect =
                    "SELECT p.code_number AS Code, p.name AS Name, p.unit_weight AS UnitWeight, " +
                    "w.weight AS AddWeight, w.total_weight AS TotalWeight, w.work_count AS WorkCount, w.created_at AS CreatedAt " +
                    "FROM workrecord w " +
                    "LEFT JOIN product p " +
                    "ON w.product_id = p.id " +
                    "WHERE w.product_id = @product_id " +
                    "AND (DATE(w.created_at) BETWEEN @startDate AND @endDate) " +
                    "ORDER BY w.created_at ASC, w.work_count ASC";
                }

                cmd = new MySqlCommand(sqlselect, conn);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                if (!currentProductId.Equals("") && currentProductId != null)
                {
                    cmd.Parameters.AddWithValue("@product_id", currentProductId);
                }

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                WorkRecordList_Datagridview.DataSource = dt;
                if (WorkRecordList_Datagridview.RowCount == 0)
                {
                    var text = "해당 조건으로 조회되는 데이터가 없습니다.";
                    MessageBox.Show(text);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                
            }
        }

        //
        // 엑셀 추출
        //
        private void ExcelExport_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var currentFilePath = _configFile.File_Path;

                //
                // 파일 저장 경로 지정 확인
                //
                if (currentFilePath.Equals("") || currentFilePath == null)
                {
                    var text = "다운로드할 파일을 저장할 경로가 지정되지 않았습니다.";
                    MessageBox.Show(text);
                    return;
                }

                // 오늘 날짜로 파일명 생성
                var currentDate = DateTime.Now.ToString("yyyyMMdd");
                var fileName = currentFilePath + "\\" + currentDate + "_WorkReport.xlsx";

                Microsoft.Office.Interop.Excel.Application xlsApp;
                Excel.Workbook xlsWorkbook;
                Excel.Worksheet xlsWorksheet;
                object misValue = System.Reflection.Missing.Value;

                // 이전 엑셀 파일 삭제
                try
                {
                    System.IO.FileInfo oldFile = new System.IO.FileInfo(fileName);
                    if (oldFile.Exists)
                    {
                        System.IO.File.SetAttributes(oldFile.FullName, System.IO.FileAttributes.Normal);
                        oldFile.Delete();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing old Excel report: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                // 새로운 파일 생성
                xlsApp = new Excel.Application();
                xlsWorkbook = xlsApp.Workbooks.Add(misValue);
                xlsWorksheet = (Excel.Worksheet)xlsWorkbook.Sheets[1];

                //var sqlselect = "SELECT * FROM scales;";
                //MySqlCommand cmd = new MySqlCommand(sqlselect, conn);
                //MySqlDataReader dr = cmd.ExecuteReader();

                //
                // 엑셀의 row, column은 인덱스가 1부터 시작한다.
                //

                dr = cmd.ExecuteReader();

                // DB 컬럼명 입력
                var i = 1;
                if (dr.HasRows)
                {
                    for (int j = 1; j <= dr.FieldCount; ++j)
                    {
                        xlsWorksheet.Cells[i, j] = dr.GetName(j-1); // 211220 dr.GetName(j)의 j를 j-1로 변경할 것
                    }
                    ++i;
                }
                // DB 컬럼명에 해당하는 데이터 입력
                while (dr.Read())
                {
                    for (int j = 1; j <= dr.FieldCount; ++j) // 211220 j < dr.FieldCount를 j <= dr.FieldCount로 변경할 것
                    {
                        xlsWorksheet.Cells[i, j] = dr.GetValue(j-1); // 211220 dr.GetValue(j)의 j를 j-1로 변경할 것
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                var text = "엑셀 추출이 완료 되었습니다.";
                MessageBox.Show(text);
                conn.Close();
            }
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

        private void ExcelExportClose_Button_Click(object sender, EventArgs e)
        {
            dr.Close();
            this.Close();
        }
    }
}
