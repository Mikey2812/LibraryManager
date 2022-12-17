using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_E_INDIVIDUAL_PROJECT.BLL
{
    class BLL_PhieuMuon
    {
        DAL.DAL_MuonTraSach dalmts;
        GUI.MUONTRASACH MTS;
        public BLL_PhieuMuon(GUI.MUONTRASACH f_MTS)
        {
            dalmts = new DAL.DAL_MuonTraSach();
            MTS = f_MTS;
        }
        public void BLL_Load_Data()
        {
            MTS.dataGridView1.DataSource = dalmts.DAL_LoadData();
        }
        public void BLL_Load_Combo()
        {
            MTS.cb_NhanVien.DataSource = dalmts.DAL_LoadComboBox();
            MTS.cb_NhanVien.DisplayMember = "hovaten";
            MTS.cb_NhanVien.ValueMember = "manhanvien";
        }

        public void BLL_PhieuMuon_Them()
        {
            dalmts.DAL_PhieuMuon_Them(MTS.txt_MaPhieu.Text, MTS.txt_MaDocGia.Text, MTS.cb_NhanVien.SelectedValue.ToString(), MTS.dtp_NgayMuon.Value, MTS.dtp_NgayTra.Value);
        }
        public void BLL_PhieuMuon_Xoa()
        {
            dalmts.DAL_PhieuMuon_Xoa(MTS.txt_MaPhieu.Text);
        }
        public void BLL_PhieuMuon_Sua()
        {
            dalmts.DAL_PhieuMuon_Sua(MTS.txt_MaPhieu.Text, MTS.txt_MaDocGia.Text, MTS.cb_NhanVien.SelectedValue.ToString(), MTS.dtp_NgayMuon.Value, MTS.dtp_NgayTra.Value);
        }
        public bool BLL_CheckPhieu()
        {
            if( dalmts.DAL_CheckPhieu(MTS.txt_MaDocGia.Text) < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool BLL_CheckDocGia()
        {
            if (dalmts.DAL_CheckDocGia(MTS.txt_MaDocGia.Text) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
