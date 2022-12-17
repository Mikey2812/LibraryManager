using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464_E_INDIVIDUAL_PROJECT.BLL
{
    class BLL_DangNhap
    {
        DAL.DAL_DangNhap dalDangNhap;
        GUI.DANGNHAP DN;
        public BLL_DangNhap(GUI.DANGNHAP f_DN)
        {
            dalDangNhap = new DAL.DAL_DangNhap();
            DN = f_DN;
        }
        public int BLL_dangnhap()
        {
            return dalDangNhap.DAL_dangnhap(DN.txt_User.Text, DN.txt_Pass.Text);
        }
        public string BLL_DangNhap_LoadName()
        {
            return dalDangNhap.DAL_DangNhap_GetName(DN.txt_User.Text, DN.txt_Pass.Text);
        }
    }
}
