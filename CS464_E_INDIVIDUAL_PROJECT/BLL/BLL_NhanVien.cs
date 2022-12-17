using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464_E_INDIVIDUAL_PROJECT.BLL
{
    class BLL_NhanVien
    {
        DAL.DAL_NhanVien dalNhanVien;
        GUI.QUANLYNHANVIEN QLNV;
        public BLL_NhanVien(GUI.QUANLYNHANVIEN f_QLNV)
        {
            dalNhanVien = new DAL.DAL_NhanVien();
            QLNV = f_QLNV;
        }
        public void BLL_Load_Data()
        {
            QLNV.dataGridView1.DataSource = dalNhanVien.DAL_LoadData();
        }
        public void BLL_NhanVien_Them()
        {
            dalNhanVien.DAL_NhanVien_Them(QLNV.txt_MaNhanVien.Text, QLNV.txt_HoVaTen.Text, QLNV.txt_SDT.Text, QLNV.dateTimePicker1.Value,
                QLNV.cb_GioiTinh.SelectedItem, QLNV.txt_CMND.Text, QLNV.txt_HinhAnh.Text);
        }
        public void BLL_NhanVien_Xoa()
        {
            dalNhanVien.DAL_NhanVien_Xoa(QLNV.txt_MaNhanVien.Text);
        }
        public void BLL_NhanVien_Sua()
        {
            dalNhanVien.DAL_NhanVien_Sua(QLNV.txt_MaNhanVien.Text, QLNV.txt_HoVaTen.Text, QLNV.txt_SDT.Text, QLNV.dateTimePicker1.Value,
                QLNV.cb_GioiTinh.SelectedItem, QLNV.txt_CMND.Text, QLNV.txt_HinhAnh.Text);
        }
    }
}
