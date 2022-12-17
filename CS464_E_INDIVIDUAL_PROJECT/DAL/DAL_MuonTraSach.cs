using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_E_INDIVIDUAL_PROJECT.DAL
{
    class DAL_MuonTraSach
    {
        LopDungChung lopChung;
        public DAL_MuonTraSach()
        {
            lopChung = new LopDungChung();
        }
        public DataTable DAL_LoadData()
        {
            string sqlLoad = "select * from PHIEUMUON";
            return lopChung.LoadData(sqlLoad);
        }
        public DataTable DAL_LoadComboBox()
        {
            string sqlLoadComboBox = "select * from NHANVIEN";
            return lopChung.LoadData(sqlLoadComboBox);
        }

        public void DAL_PhieuMuon_Them(string maphieu, string madocgia, string nhanvien, DateTime ngaymuon, DateTime ngaytra)
        {
            string sqlThem = "insert into PHIEUMUON values(N'" + maphieu + "', N'" + madocgia + "', '" + nhanvien
                + "', Convert(DateTime,'" + ngaymuon + "', 103), Convert(DateTime,'" + ngaytra + "', 103))";
            lopChung.Nonquery(sqlThem);
        }
        public void DAL_PhieuMuon_Xoa(string maphieu)
        {
            string sqlXoa = "Delete from PHIEUMUON where maphieumuon = '" + maphieu + "'";
            lopChung.Nonquery(sqlXoa);
        }
        public void DAL_PhieuMuon_Sua(string maphieu, string madocgia, string nhanvien, DateTime ngaymuon, DateTime ngaytra)
        {
            string sqlSua = "update PHIEUMUON set madocgia = N'" + madocgia + "', manhanvien = N'" + nhanvien +
                "', ngaymuon = Convert(DateTime, '" + ngaymuon + "', 103), ngayhentra = Convert(DateTime, '" + ngaytra + "', 103) where maphieumuon = '" + maphieu + "'";
            lopChung.Nonquery(sqlSua);
        }
        public int DAL_CheckDocGia(string madocgia)
        {
            string sqlDem = "select count(*) from DOCGIA where madocgia = '" + madocgia + "'";
            return (int)lopChung.Scalar(sqlDem);
        }
        public int DAL_CheckPhieu(string madocgia)
        {
            string sqlDem = "select count(*) from PHIEUMUON where madocgia = '" + madocgia + "'";
            return (int)lopChung.Scalar(sqlDem);
        }
    }
}
