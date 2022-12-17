using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464_E_INDIVIDUAL_PROJECT.DAL
{
    class DAL_NhanVien
    {
        LopDungChung lopChung;
        public DAL_NhanVien()
        {
            lopChung = new LopDungChung();
        }
        public DataTable DAL_LoadData()
        {
            string sqlLoad = "select * from NHANVIEN";
            return lopChung.LoadData(sqlLoad);
        }
        public void DAL_NhanVien_Them(string manhanvien, string hovaten, string sdt, DateTime ngaysinh, object gioitinh, string cmnd, string hinhanh)
        {
            string sqlThem = "insert into NHANVIEN values(N'" + manhanvien + "', N'" + hovaten + "', N'" + hovaten.Substring(hovaten.LastIndexOf(' ') + 1) + "', N'" + sdt + "', Convert(DateTime,'" + ngaysinh + "', 103), N'"
                + gioitinh + "', N'" + cmnd + "', N'" + hinhanh + "')";
            lopChung.Nonquery(sqlThem);
        }
        public void DAL_NhanVien_Xoa(string manhanvien)
        {
            string sqlXoa = "Delete from NHANVIEN where manhanvien = '" + manhanvien + "'";
            lopChung.Nonquery(sqlXoa);
        }
        public void DAL_NhanVien_Sua(string manhanvien, string hovaten, string sdt, DateTime ngaysinh, object gioitinh, string cmnd, string hinhanh)
        {
            string sqlSua = "update NHANVIEN set hovaten = N'" + hovaten + "', displayname = N'" + hovaten.Substring(hovaten.LastIndexOf(' ') + 1)+ "', sodienthoai = N'" + sdt + "', ngaysinh = Convert(DateTime,'" + ngaysinh + "', 103), gioitinh = N'" +
                gioitinh + "', cmnd = N'" + cmnd + "', hinhanh = N'" + hinhanh + "' where manhanvien = '" + manhanvien + "'";
            lopChung.Nonquery(sqlSua);
        }
    }
}
