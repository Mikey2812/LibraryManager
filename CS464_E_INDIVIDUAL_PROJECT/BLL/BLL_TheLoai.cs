using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464_E_INDIVIDUAL_PROJECT.BLL
{
    class BLL_TheLoai
    {
        DAL.DAL_TheLoai daltl;
        GUI.QUANLYTHELOAI QLTL;
        public BLL_TheLoai(GUI.QUANLYTHELOAI f_QLTL)
        {
            daltl = new DAL.DAL_TheLoai();
            QLTL = f_QLTL;
        }
        public void BLL_Load_Data()
        {
            QLTL.dataGridView1.DataSource = daltl.DAL_LoadData();
        }
        public void BLL_TheLoai_Them()
        {
            daltl.DAL_TheLoai_Them(QLTL.txt_MaTL.Text, QLTL.txt_TenTL.Text);
        }
        public void BLL_TheLoai_Xoa()
        {
            daltl.DAL_TheLoai_Xoa(QLTL.txt_MaTL.Text);
        }
        public void BLL_TheLoai_Sua()
        {
            daltl.DAL_TheLoai_Sua(QLTL.txt_MaTL.Text, QLTL.txt_TenTL.Text);
        }
    }
}
