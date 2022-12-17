using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464_E_INDIVIDUAL_PROJECT.BLL
{
    class BLL_NhaXuatBan
    {
        DAL.DAL_NhaXuatBan dalnhaxb;
        GUI.NHAXUATBAN QLNXB;
        public BLL_NhaXuatBan(GUI.NHAXUATBAN f_QLNXB)
        {
            dalnhaxb = new DAL.DAL_NhaXuatBan();
            QLNXB = f_QLNXB;
        }
        public void BLL_Load_Data()
        {
            QLNXB.dataGridView1.DataSource = dalnhaxb.DAL_LoadData();
        }
        public void BLL_NhaXuatBan_Them()
        {
            dalnhaxb.DAL_NhaXuatBan_Them(QLNXB.txt_MaNXB.Text, QLNXB.txt_TenNXB.Text,
                QLNXB.txt_DiaChi.Text, QLNXB.txt_HinhAnh.Text);
        }
        public void BLL_NhaXuatBan_Xoa()
        {
            dalnhaxb.DAL_NhaXuatBan_Xoa(QLNXB.txt_MaNXB.Text);
        }
        public void BLL_NhaXuatBan_Sua()
        {
            dalnhaxb.DAL_NhaXuatBan_Sua(QLNXB.txt_MaNXB.Text, QLNXB.txt_TenNXB.Text, QLNXB.txt_DiaChi.Text, QLNXB.txt_HinhAnh.Text);
        }
    }
}
