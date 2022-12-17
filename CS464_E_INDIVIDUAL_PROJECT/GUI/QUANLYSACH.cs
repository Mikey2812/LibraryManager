using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_E_INDIVIDUAL_PROJECT.GUI
{
    public partial class QUANLYSACH : Form
    {
        BLL.BLL_Sach bllsach;
        public QUANLYSACH()
        {
            InitializeComponent();
            bllsach = new BLL.BLL_Sach(this);
        }

        private void QUANLYSACH_Load(object sender, EventArgs e)
        {
            LoadComboNXB();
            LoadComboTL();
            LoadDataGrid();
            dataGridView1.Columns[0].HeaderText = "Mã Sách";
            dataGridView1.Columns[1].HeaderText = "Tên Sách";
            dataGridView1.Columns[2].HeaderText = "Năm Xuất Bản";
            dataGridView1.Columns[3].HeaderText = "Thể Loại";
            dataGridView1.Columns[4].HeaderText = "Nhà Xuất Bản";
            dataGridView1.Columns[5].HeaderText = "Tác Giả";
        }

        public void LoadDataGrid()
        {
            bllsach.BLL_Load_Data();
        }

        public void LoadComboNXB()
        {
            bllsach.BLL_Load_NXB();
        }

        public void LoadComboTL()
        {
            bllsach.BLL_Load_TL();
        }

        private void them_Click(object sender, EventArgs e)
        {
            try
            {
                bllsach.BLL_Sach_Them();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            LoadDataGrid();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            try
            {
                bllsach.BLL_Sach_Sua();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            LoadDataGrid();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                bllsach.BLL_Sach_Xoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            LoadDataGrid();
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            bllsach.BLL_Sach_Dem();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            bllsach.BLL_Sach_TimKiem();
        }

        private void btn_LoadGrid_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSach.Text = dataGridView1.CurrentRow.Cells["masach"].Value.ToString();
            txt_TenSach.Text = dataGridView1.CurrentRow.Cells["tensach"].Value.ToString();
            txt_NamXB.Text = dataGridView1.CurrentRow.Cells["namxb"].Value.ToString();
            cb_TheLoai.SelectedValue = dataGridView1.CurrentRow.Cells["matheloai"].Value.ToString();
            //cb_TheLoai.SelectedItem = dataGridView1.CurrentRow.Cells["theloai"].Value.ToString();
            cb_NhaXB.SelectedValue = dataGridView1.CurrentRow.Cells["manhaxb"].Value.ToString();
            txt_TenTG.Text = dataGridView1.CurrentRow.Cells["tacgia"].Value.ToString();
        }

        private void rdo_Tang_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["namxb"], ListSortDirection.Ascending);
        }

        private void rdo_Giam_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["namxb"], ListSortDirection.Descending);
        }

    }
}
