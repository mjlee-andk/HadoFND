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

namespace HadoFND
{
    public partial class ExcelExportForm : MetroFramework.Forms.MetroForm // 상속 클래스 변경
    {
        ConfigFile _configFile = new ConfigFile();

        // DB 연결 및 데이터 가져오기        
        MySqlConnection conn;

        List<DataFormat.Product> productList; // 제품 목록

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
            // 환경 설정 파일에서 파일 저장 위치 불러오기
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
            dialog.SelectedPath = @"C:\";    // 열 때 폴더를 지정하려면 이런식으로..(추가)

            dialog.ShowDialog();
            string selected = dialog.SelectedPath;

            _configFile.File_Path = selected;
            _configFile.Save();

            FilePath_TextBox.Text = selected;
        }
    }
}
