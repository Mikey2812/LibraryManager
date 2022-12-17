using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_E_INDIVIDUAL_PROJECT.GUI
{
    public partial class DOIMATKHAU : Form
    {
        BLL.BLL_DoiMatKhau bllDMK;
        public DOIMATKHAU()
        {
            InitializeComponent();
            bllDMK = new BLL.BLL_DoiMatKhau(this);
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            bllDMK.BLL_doimatkhau();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            bllDMK.BLL_Exit(this);
        }

        private void chk_Hien_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Hien.Checked == true)
            {
                txt_newpass.PasswordChar = (char)0;
                txt_oldpass.PasswordChar = (char)0;
                txt_confirmpass.PasswordChar = (char)0;
            }
            else
            {
                txt_newpass.PasswordChar = '*';
                txt_oldpass.PasswordChar = '*';
                txt_confirmpass.PasswordChar = '*';
            }
        }
    }
}
