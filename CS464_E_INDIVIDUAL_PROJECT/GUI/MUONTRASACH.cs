using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_E_INDIVIDUAL_PROJECT.GUI
{
    public partial class MUONTRASACH : Form
    {
        BLL.BLL_PhieuMuon bllpm;
        BLL.BLL_ChiTietPhieuMuon bllctpm;
        bool checkComboBoxChange = false;
        public MUONTRASACH()
        {
            InitializeComponent();
            bllpm = new BLL.BLL_PhieuMuon(this);
            bllctpm = new BLL.BLL_ChiTietPhieuMuon(this);
        }

        private void MuonTraSach_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadDataGrid();
            LoadColumn();
            LoadComboMAPM();
            LoadComboMAS();
            LoadDataGridCT();
        }
        public void LoadComboBox()
        {
            bllpm.BLL_Load_Combo();
        }
        public void LoadDataGrid()
        {
            bllpm.BLL_Load_Data();
        }

        public void LoadDataGridCT()
        {
            bllctpm.BLL_Load_DataGrid();
        }
        public void LoadComboMAPM()
        {
            bllctpm.BLL_Load_MAPM();
        }
        public void LoadComboMAS()
        {
            bllctpm.BLL_Load_MASACH();
        }
        public void LoadComboBoxChange()
        {
            bllctpm.BLL_Load_Data();
        }
        public void LoadColumn()
        {
            dataGridView1.Columns[0].HeaderText = "Mã phiếu mượn";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].HeaderText = "Mã độc giả";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].HeaderText = "Ngày mượn";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[4].HeaderText = "Ngày hẹn trả";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (bllpm.BLL_CheckDocGia())
            {
                if (bllpm.BLL_CheckPhieu())
                {
                    try
                    {
                        bllpm.BLL_PhieuMuon_Them(); 
                        LoadDataGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi", "Thông báo");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Độc giả chưa trả sách ");
                }
            }
            else
            {
                MessageBox.Show("Độc giả chưa đăng kí thành viên");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                bllpm.BLL_PhieuMuon_Sua();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            LoadDataGrid();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                bllpm.BLL_PhieuMuon_Xoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            LoadDataGrid();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Close(); 
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaPhieu.Text = dataGridView1.CurrentRow.Cells["maphieumuon"].Value.ToString();
            txt_MaDocGia.Text = dataGridView1.CurrentRow.Cells["madocgia"].Value.ToString();
            cb_NhanVien.SelectedValue = dataGridView1.CurrentRow.Cells["manhanvien"].Value.ToString();
        }

        private void cb_MaPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkComboBoxChange == true)
            {
                LoadComboBoxChange();
            }
            else
            {
                checkComboBoxChange = true;
            }
        }

        private void dtp_NgayTra_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime day = dtp_NgayTra.Value;
            if (today >= day)
            {
                MessageBox.Show("Bạn phải chọn ngày lớn hơn ngày hiện tại");
                dtp_NgayTra.Value = today.AddDays(1);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime day = dtp_NgayTra.Value;
            if (today >= day)
            {
                MessageBox.Show("Bạn phải chọn ngày lớn hơn ngày hiện tại");
                dtp_NgayTra.Value = today.AddDays(1);
            }
            else if (today.AddMonths(2) < day)
            {
                MessageBox.Show("Bạn không được mượn quá 2 tháng");
                dtp_NgayTra.Value = today.AddMonths(2);
            }
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            bllctpm.BLL_Load_DataGrid();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkComboBoxChange = false;
            cb_MaPhieuMuon.SelectedValue = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            cb_MaSach.SelectedValue = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            rtb_TinhTrang.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            checkComboBoxChange = true;
        }

        private void btn_ThemCT_Click(object sender, EventArgs e)
        {
            try
            {
                bllctpm.BLL_CTPM_Them();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            LoadDataGridCT();
        }

        private void btn_SuaCT_Click(object sender, EventArgs e)
        {
            try
            {
                bllctpm.BLL_CTPM_Sua();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            LoadDataGridCT();
        }

        private void btn_GiaHan_Click(object sender, EventArgs e)
        {
            bllctpm.BLL_CTPM_GiaHan();
            MessageBox.Show("Bạn đã gia hạn 1 tuần thành công");
            LoadDataGridCT();
        }

        private void btn_XoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                bllctpm.BLL_CTPM_Xoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            LoadDataGridCT();
        }
    }
}
