using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464_E_INDIVIDUAL_PROJECT.BLL
{
    class BLL_DoiMatKhau
    {
        DAL.DAL_DoiMatKhau dalDoiMatKhau;
        GUI.DOIMATKHAU DMK;
        public BLL_DoiMatKhau(GUI.DOIMATKHAU f_DMK)
        {
            dalDoiMatKhau = new DAL.DAL_DoiMatKhau();
            DMK = f_DMK;
        }
        public void BLL_doimatkhau()
        {
            dalDoiMatKhau.DAL_ChangePassword(DMK.txt_user.Text, DMK.txt_oldpass.Text, DMK.txt_newpass.Text, DMK.txt_confirmpass.Text);
        }
        public void BLL_Exit(GUI.DOIMATKHAU f_DMK)
        {
            dalDoiMatKhau.DAL_Exit(f_DMK);
        }
    }
}
