using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464_E_INDIVIDUAL_PROJECT.BLL
{
    class BLL_Sach
    {
        DAL.DAL_Sach dalSach;
        GUI.QUANLYSACH QLS;
        public BLL_Sach(GUI.QUANLYSACH f_QLS)
        {
            dalSach = new DAL.DAL_Sach();
            QLS = f_QLS;
        }
        public void BLL_Load_Data()
        {
            QLS.dataGridView1.DataSource = dalSach.DAL_LoadData();
        }
        public void BLL_Load_NXB()
        {
            QLS.cb_NhaXB.DataSource = dalSach.DAL_LoadNXB();
            QLS.cb_NhaXB.DisplayMember = "tennhaxb";
            QLS.cb_NhaXB.ValueMember = "manhaxb";
        }

        public void BLL_Load_TL()
        {
            QLS.cb_TheLoai.DataSource = dalSach.DAL_LoadTL();
            QLS.cb_TheLoai.DisplayMember = "tentheloai";
            QLS.cb_TheLoai.ValueMember = "matheloai";
        }
        public void BLL_Sach_Them()
        {
            dalSach.DAL_Sach_Them(QLS.txt_MaSach.Text, QLS.txt_TenSach.Text, int.Parse(QLS.txt_NamXB.Text),
                QLS.cb_TheLoai.SelectedValue.ToString()/*QLS.cb_TheLoai.SelectedItem*/, QLS.cb_NhaXB.SelectedValue.ToString(), QLS.txt_TenTG.Text);
        }
        public void BLL_Sach_Xoa()
        {
            dalSach.DAL_Sach_Xoa(QLS.txt_MaSach.Text);
        }
        public void BLL_Sach_Sua()
        {
            dalSach.DAL_Sach_Sua(QLS.txt_MaSach.Text, QLS.txt_TenSach.Text, int.Parse(QLS.txt_NamXB.Text),
                QLS.cb_TheLoai.SelectedValue.ToString(), QLS.cb_NhaXB.SelectedValue.ToString(), QLS.txt_TenTG.Text);
        }
        public void BLL_Sach_Dem()
        {
            QLS.lbl_Dem.Text = "Số lượng sách: " + dalSach.DAL_Sach_Dem().ToString();
        }
        public void BLL_Sach_TimKiem()
        {
            QLS.dataGridView1.DataSource = dalSach.DAL_Sach_TimKiem(QLS.txt_TimKiem.Text);
        }
    }
}
