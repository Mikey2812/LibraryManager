using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464_E_INDIVIDUAL_PROJECT.BLL
{
    class BLL_ChiTietPhieuMuon
    {
        DAL.DAL_ChiTietPM dalCTPM;
        GUI.MUONTRASACH MTS;
        public BLL_ChiTietPhieuMuon(GUI.MUONTRASACH f_MTS)
        {
            dalCTPM = new DAL.DAL_ChiTietPM();
            MTS = f_MTS;
        }
        public void BLL_Load_DataGrid()
        {
            MTS.dataGridView2.DataSource = dalCTPM.DAL_LoadDataGrid();
            MTS.lbl_SoCTPM.Text = "Số chi tiết phiếu mượn: " + dalCTPM.DAL_CTPM_Dem();
        }
        public void BLL_Load_Data()
        {
            MTS.dataGridView2.DataSource = dalCTPM.DAL_LoadData(MTS.cb_MaPhieuMuon.SelectedValue.ToString());
            MTS.lbl_SoCTPM.Text = "Số chi tiết phiếu mượn: " + dalCTPM.DAL_CTPM_DemFilter(MTS.cb_MaPhieuMuon.SelectedValue.ToString());
        }
        public void BLL_Load_MASACH()
        {
            MTS.cb_MaSach.DataSource = dalCTPM.DAL_LoadMASACH();
            MTS.cb_MaSach.DisplayMember = "tensach";
            MTS.cb_MaSach.ValueMember = "masach";
        }

        public void BLL_Load_MAPM()
        {
            MTS.cb_MaPhieuMuon.DataSource = dalCTPM.DAL_LOADMAPM();
            MTS.cb_MaPhieuMuon.DisplayMember = "maphieumuon";
            MTS.cb_MaPhieuMuon.ValueMember = "maphieumuon";
        }
        public void BLL_CTPM_Them()
        {
            dalCTPM.DAL_CTPM_Them(MTS.cb_MaPhieuMuon.SelectedValue.ToString(), MTS.cb_MaSach.SelectedValue.ToString(), MTS.rtb_TinhTrang.Text);
        }
        public void BLL_CTPM_Xoa()
        {
            dalCTPM.DAL_CTPM_Xoa(MTS.cb_MaPhieuMuon.SelectedValue.ToString());
        }
        public void BLL_CTPM_Sua()
        {
            dalCTPM.DAL_CTPM_Sua(MTS.cb_MaPhieuMuon.SelectedValue.ToString(), MTS.cb_MaSach.SelectedValue.ToString(), MTS.rtb_TinhTrang.Text);
        }
        public void BLL_CTPM_GiaHan()
        {
            dalCTPM.DAL_CTPM_GiaHan(MTS.cb_MaPhieuMuon.SelectedValue.ToString(), dalCTPM.DAL_CTPM_FindDay(MTS.cb_MaPhieuMuon.SelectedValue.ToString()).AddDays(7));
        }
    }
}
