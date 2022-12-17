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
    public partial class QUANLYTHELOAI : Form
    {
        BLL.BLL_TheLoai blltl;
        public QUANLYTHELOAI()
        {
            InitializeComponent();
            blltl = new BLL.BLL_TheLoai(this);
        }

        public void LoadDataGrid()
        {
            blltl.BLL_Load_Data();
        }
        public void LoadColumn()
        {
            dataGridView1.Columns[0].HeaderText = "Mã thể loại";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].HeaderText = "Tên thể loại";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void QUANLYTHELOAI_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            LoadColumn();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                blltl.BLL_TheLoai_Them();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            LoadDataGrid();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                blltl.BLL_TheLoai_Sua();
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
                blltl.BLL_TheLoai_Xoa();
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
            txt_MaTL.Text = dataGridView1.CurrentRow.Cells["matheloai"].Value.ToString();
            txt_TenTL.Text = dataGridView1.CurrentRow.Cells["tentheloai"].Value.ToString();
        }
    }
}
