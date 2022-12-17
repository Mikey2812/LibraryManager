using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_E_INDIVIDUAL_PROJECT.GUI
{
    public partial class DANGNHAP : Form
    {
        BLL.BLL_DangNhap bllDN;
        public DANGNHAP()
        {
            InitializeComponent();
            bllDN = new BLL.BLL_DangNhap(this);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btn_DangNhap_Click_1(object sender, EventArgs e)
        {
            if (txt_User.Text == "")
            {
                MessageBox.Show("Bạn phải nhập username");
                txt_User.Focus();
            }
            else if (txt_Pass.Text == "")
            {
                MessageBox.Show("Bạn phải nhập password");
                txt_Pass.Focus();
            }
            else
            {
                int ketqua = bllDN.BLL_dangnhap();
                if (ketqua >= 1)
                {
                    frm_Main Main = new frm_Main(bllDN.BLL_DangNhap_LoadName());
                    Main.Show();
                    this.Visible = false;
                }
                else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Show.Checked == true)
            {
                txt_Pass.PasswordChar = (char)0;
            }
            else
            {
                txt_Pass.PasswordChar = '*';
            }
        }

        private void lbl_Clear_Click(object sender, EventArgs e)
        {
            txt_User.Text = "";
            txt_Pass.Text = "";
            txt_User.Focus();
        }

        private void ll_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DOIMATKHAU DMK = new DOIMATKHAU();
            DMK.Show();
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DANGNHAP_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txt_User_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_DangNhap.PerformClick();
            }
        }

        private void txt_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_DangNhap.PerformClick();
            }
        }
    }
}
