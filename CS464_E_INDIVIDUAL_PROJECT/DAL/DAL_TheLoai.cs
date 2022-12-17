using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464_E_INDIVIDUAL_PROJECT.DAL
{
    class DAL_TheLoai
    {
        LopDungChung lopChung;
        public DAL_TheLoai()
        {
            lopChung = new LopDungChung();
        }
        public DataTable DAL_LoadData()
        {
            string sqlLoad = "select * from THELOAI";
            return lopChung.LoadData(sqlLoad);
        }
        public void DAL_TheLoai_Them(string matheloai, string tentheloai)
        {
            string sqlThem = "insert into THELOAI values(N'" + matheloai + "', N'" + tentheloai + "')";
            lopChung.Nonquery(sqlThem);
        }
        public void DAL_TheLoai_Xoa(string matheloai)
        {
            string sqlXoa = "Delete from THELOAI where matheloai = '" + matheloai + "'";
            lopChung.Nonquery(sqlXoa);
        }
        public void DAL_TheLoai_Sua(string matheloai, string tentheloai)
        {
            string sqlSua = "update THELOAI set tentheloai = N'" + tentheloai + "' where matheloai = '" + matheloai + "'";
            lopChung.Nonquery(sqlSua);
        }
    }
}
