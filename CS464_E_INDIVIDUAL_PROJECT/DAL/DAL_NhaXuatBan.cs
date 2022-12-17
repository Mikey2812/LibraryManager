using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464_E_INDIVIDUAL_PROJECT.DAL
{
    class DAL_NhaXuatBan
    {
        LopDungChung lopChung;
        public DAL_NhaXuatBan()
        {
            lopChung = new LopDungChung();
        }
        public DataTable DAL_LoadData()
        {
            string sqlLoad = "select * from NHAXUATBAN";
            return lopChung.LoadData(sqlLoad);
        }
        public void DAL_NhaXuatBan_Them(string manhaxb, string tennhaxb, string diachi, string hinhanh)
        {
            string sqlThem = "insert into NHAXUATBAN values(N'" + manhaxb + "', N'" + tennhaxb + "', N'" + diachi + "', N'" + hinhanh + "')";
            lopChung.Nonquery(sqlThem);
        }
        public void DAL_NhaXuatBan_Xoa(string manhaxb)
        {
            string sqlXoa = "Delete from NHAXUATBAN where manhaxb = '" + manhaxb + "'";
            lopChung.Nonquery(sqlXoa);
        }
        public void DAL_NhaXuatBan_Sua(string manhaxb, string tennhaxb, string diachi, string hinhanh)
        {
            string sqlSua = "update NHAXUATBAN set tennhaxb = N'" + tennhaxb + "', diachi = N'" +
                diachi + "', hinhanh = N'" + hinhanh + "' where manhaxb = '" + manhaxb + "'";
            lopChung.Nonquery(sqlSua);
        }
    }
}
