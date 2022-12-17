using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_E_INDIVIDUAL_PROJECT.DAL
{
    class DAL_DangNhap
    {
        LopDungChung lopChung;
        public DAL_DangNhap()
        {
            lopChung = new LopDungChung();
        }
        public int DAL_dangnhap(string username, string password)
        {
            string sqlDangNhap = "select count (*) from TAIKHOAN where username = '" +
                username + "' and password = '" + password + "'";
            return (int)lopChung.Scalar(sqlDangNhap);
        }
        public string DAL_DangNhap_GetName(string username, string password)
        {
            string find = "Select N.displayname From TAIKHOAN T, NHANVIEN N where username = '" + username + "' and password = '" + password + "' AND T.mataikhoan = N.mataikhoan";
            return lopChung.DataReader(find);
        }
    }
}
