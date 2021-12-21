using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HadoFND
{
    class Util
    {
        // 현재 창 종료 묻는 메시지 박스
        public static void CloseCurrentFormMessageBox(Form currentForm)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                currentForm.Close();
            }
        }
    }
}
