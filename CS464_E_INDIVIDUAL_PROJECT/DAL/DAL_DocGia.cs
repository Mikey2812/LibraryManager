using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_E_INDIVIDUAL_PROJECT.DAL
{
    class DAL_DocGia
    {
        LopDungChung lopChung;
        public DAL_DocGia()
        {
            lopChung = new LopDungChung();
        }
        public DataTable DAL_LoadData()
        {
            string sqlLoad = "select * from DOCGIA";
            return lopChung.LoadData(sqlLoad);
        }
        public void DAL_DocGia_Them(string madocgia, string hovaten, DateTime ngaysinh, object gioitinh, string cmnd, string hinhanh)
        {
            string sqlThem = "insert into DOCGIA values(N'" + madocgia + "', N'" + hovaten + "', Convert(DateTime,'" + ngaysinh + "', 103), N'"
                + gioitinh + "', N'" + cmnd + "', N'"+ hinhanh + "')";
            lopChung.Nonquery(sqlThem);
        }
        public void DAL_DocGia_Xoa(string madocgia)
        {
            string sqlXoa = "Delete from DOCGIA where madocgia = '" + madocgia + "'";
            lopChung.Nonquery(sqlXoa);
        }
        public void DAL_DocGia_Sua(string madocgia, string hovaten, DateTime ngaysinh, object gioitinh, string cmnd, string hinhanh)
        {
            string sqlSua = "update DOCGIA set hovaten = N'" + hovaten + "', ngaysinh = Convert(DateTime,'" + ngaysinh + "', 103), gioitinh = N'" +
                gioitinh + "', cmnd = N'" + cmnd + "', hinhanh = N'"+ hinhanh +"' where madocgia = '" + madocgia + "'";
            lopChung.Nonquery(sqlSua);
        }
    }
}
