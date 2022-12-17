using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_E_INDIVIDUAL_PROJECT.DAL
{
    class DAL_Sach
    {
        LopDungChung lopChung;
        public DAL_Sach()
        {
            lopChung = new LopDungChung();
        }
        public DataTable DAL_LoadData()
        {
            string sqlLoad = "select * from SACH";
            return lopChung.LoadData(sqlLoad);
        }
        public DataTable DAL_LoadNXB()
        {
            string sqlLoadNXB = "select * from NHAXUATBAN";
            return lopChung.LoadData(sqlLoadNXB);
        }

        public DataTable DAL_LoadTL()
        {
            string sqlLoadNXB = "select * from THELOAI";
            return lopChung.LoadData(sqlLoadNXB);
        }
        public void DAL_Sach_Them(string masach, string tensach, int namxb, string theloai/*object theloai*/, string nhaxb, string tacgia)
        {
            string sqlThem = "insert into SACH values(N'" + masach + "', N'" + tensach + "', '" + namxb + "', N'"
                + theloai + "', N'" + nhaxb + "', N'" + tacgia + "')";
            lopChung.Nonquery(sqlThem);
        }
        public void DAL_Sach_Xoa(string masach)
        {
            string sqlXoa = "Delete from SACH where masach = '" + masach + "'";
            lopChung.Nonquery(sqlXoa);
        }
        public void DAL_Sach_Sua(string masach, string tensach, int namxb, string theloai, string nhaxb, string tacgia)
        {
            string sqlSua = "update SACH set tensach = N'" + tensach
                + "', namxb = '" + namxb + "', matheloai = N'" + theloai + "', manhaxb = N'" + nhaxb + "', tacgia = N'" + tacgia
                + "' where masach = '" + masach + "'";
            lopChung.Nonquery(sqlSua);
        }
        public int DAL_Sach_Dem()
        {
            string sqlDem = "select count(*) from SACH";
            return (int)lopChung.Scalar(sqlDem);
        }
        public DataTable DAL_Sach_TimKiem(string search)
        {
            string sqlTimKiem = "select * from SACH where masach like '%" + search + "%' or tensach like N'%" + search + "%'";
            return lopChung.LoadData(sqlTimKiem);
        }
    }
}
