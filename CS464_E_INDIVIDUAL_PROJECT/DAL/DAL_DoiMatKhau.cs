using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_E_INDIVIDUAL_PROJECT.DAL
{
    class DAL_DoiMatKhau
    {
        LopDungChung lopChung;
        public DAL_DoiMatKhau()
        {
            lopChung = new LopDungChung();
        }
        public void DAL_ChangePassword(string username, string oldpassword, string newpassword, string confirmpassword)
        {
            if (newpassword == confirmpassword)
            {
                string sqlSua = "update TAIKHOAN set password = N'" + newpassword +
                    "' where username = '" + username + "' and password = '" + oldpassword + "'";
                lopChung.Nonquery(sqlSua);                
            }
            else
            {
                MessageBox.Show("Bạn phải nhập mật khẩu xác nhận giống nhau");
            }
        }
        public void DAL_Exit(Form f)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                f.Close();
            }
        }
    }
}
