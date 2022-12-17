using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_E_INDIVIDUAL_PROJECT.DAL
{
    class DAL_ChiTietPM
    {
        LopDungChung lopChung;
        public DAL_ChiTietPM()
        {
            lopChung = new LopDungChung();
        }
        public DataTable DAL_LoadDataGrid()
        {
            string sqlLoad = "SELECT ct.maphieumuon, ct.masach, ct.tinhtrangsach, pm.ngaymuon, pm.ngayhentra " +
                "FROM CHITIETPM ct, PHIEUMUON pm " +
                "WHERE ct.maphieumuon = pm.maphieumuon";
            return lopChung.LoadData(sqlLoad);
        }
        public DataTable DAL_LoadData(string maphieumuon)
        {
            string sqlLoad = "SELECT ct.maphieumuon, ct.masach, ct.tinhtrangsach, pm.ngaymuon, pm.ngayhentra " +
                "FROM CHITIETPM ct, PHIEUMUON pm " +
                "WHERE ct.maphieumuon = pm.maphieumuon and ct.maphieumuon = '" + maphieumuon + "'";
            return lopChung.LoadData(sqlLoad);
        }
        public DataTable DAL_LoadMASACH()
        {
            string sqlLoadNXB = "select * from SACH";
            return lopChung.LoadData(sqlLoadNXB);
        }

        public DataTable DAL_LOADMAPM()
        {
            string sqlLoadNXB = "select * from PHIEUMUON";
            return lopChung.LoadData(sqlLoadNXB);
        }
        public void DAL_CTPM_Them(string maphieumuon, string masach, string tinhtrang)
        {
            string sqlThem = "insert into CHITIETPM values(N'" + maphieumuon + "', N'" + masach + "', N'" + tinhtrang + "')";
            lopChung.Nonquery(sqlThem);
        }
        public void DAL_CTPM_Xoa(string maphieumuon)
        {
            string sqlXoa = "Delete from CHITIETPM where maphieumuon = '" + maphieumuon + "'";
            lopChung.Nonquery(sqlXoa);
        }
        public void DAL_CTPM_Sua(string maphieumuon, string masach, string tinhtrang)
        {
            string sqlSua = "update CHITIETPM set masach = N'" + masach + "', tinhtrang = N'" + tinhtrang + "'" +
                " where maphieumuon = '" + maphieumuon + "'";
            lopChung.Nonquery(sqlSua);
        }
        public int DAL_CTPM_Dem()
        {
            string sqlDem = "select count(*) from CHITIETPM";
            return (int)lopChung.Scalar(sqlDem);
        }
        public int DAL_CTPM_DemFilter(string maphieumuon)
        {
            string sqlDem = "select count(*) from CHITIETPM where maphieumuon = '" + maphieumuon + "'";
            return (int)lopChung.Scalar(sqlDem);
        }
        public DateTime DAL_CTPM_FindDay (string maphieumuon)
        {
            string sqlDem = "select ngayhentra from PHIEUMUON where maphieumuon = '" + maphieumuon + "'";
            //return (DateTime)lopChung.Scalar(sqlDem);
            MessageBox.Show(lopChung.DataReader(sqlDem));
            DateTime dt = DateTime.Parse(lopChung.DataReader(sqlDem));
            return dt;
        }
        public void DAL_CTPM_GiaHan(string maphieumuon, DateTime ngaytra)
        {
            string sqlSua = "update PHIEUMUON set ngayhentra = Convert(DateTime, '" + ngaytra + "', 103) where maphieumuon = '" + maphieumuon + "'";
            lopChung.Nonquery(sqlSua);
        }
    }
}
