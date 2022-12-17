using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464_E_INDIVIDUAL_PROJECT.BLL
{
    class BLL_DocGia
    {
        DAL.DAL_DocGia dalDocGia;
        GUI.QUANLYDOCGIA QLDG;
        public BLL_DocGia(GUI.QUANLYDOCGIA f_QLDG)
        {
            dalDocGia = new DAL.DAL_DocGia();
            QLDG = f_QLDG;
        }
        public void BLL_Load_Data()
        {
            QLDG.dataGridView1.DataSource = dalDocGia.DAL_LoadData();
        }
        public void BLL_DocGia_Them()
        {
            dalDocGia.DAL_DocGia_Them(QLDG.txt_MaDocGia.Text, QLDG.txt_HoVaTen.Text, QLDG.dateTimePicker1.Value,
                QLDG.cb_GioiTinh.SelectedItem, QLDG.txt_CMND.Text, QLDG.txt_HinhAnh.Text);
        }
        public void BLL_DocGia_Xoa()
        {
            dalDocGia.DAL_DocGia_Xoa(QLDG.txt_MaDocGia.Text);
        }
        public void BLL_DocGia_Sua()
        {
            dalDocGia.DAL_DocGia_Sua(QLDG.txt_MaDocGia.Text, QLDG.txt_HoVaTen.Text, QLDG.dateTimePicker1.Value,
                QLDG.cb_GioiTinh.SelectedItem, QLDG.txt_CMND.Text, QLDG.txt_HinhAnh.Text);
        }
    }
}
