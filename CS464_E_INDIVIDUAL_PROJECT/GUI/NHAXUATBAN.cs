using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_E_INDIVIDUAL_PROJECT.GUI
{
    public partial class NHAXUATBAN : Form
    {
        BLL.BLL_NhaXuatBan bllnhaxb;
        string tempHinhAnh;
        public NHAXUATBAN()
        {
            InitializeComponent();
            bllnhaxb = new BLL.BLL_NhaXuatBan(this);
        }
        public void LoadDataGrid()
        {
            bllnhaxb.BLL_Load_Data();
        }
        public void LoadColumn()
        {
            dataGridView1.Columns[0].HeaderText = "Mã nhà xuất bản";
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].HeaderText = "Tên nhà xuất bản";
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[3].HeaderText = "Hình ảnh";
            dataGridView1.Columns[3].Width = 110;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void NHAXUATBAN_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            LoadColumn();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\NHAXUATBAN\\";
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                bllnhaxb.BLL_NhaXuatBan_Them();
                pictureBox1.Image.Save(duongdan + txt_HinhAnh.Text);
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
                bllnhaxb.BLL_NhaXuatBan_Sua();
                pictureBox1.Image.Save(duongdan + txt_HinhAnh.Text);
                if (tempHinhAnh != txt_HinhAnh.Text)
                {
                    File.Delete(duongdan + tempHinhAnh);
                }
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                bllnhaxb.BLL_NhaXuatBan_Xoa();
                File.Delete(duongdan + txt_HinhAnh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            LoadDataGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn File";
            OFD.Filter = "Tất cả File|*.*|file JPG|*.jpg|PNG|*.png|JPEG|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNXB.Text = dataGridView1.CurrentRow.Cells["manhaxb"].Value.ToString();
            txt_TenNXB.Text = dataGridView1.CurrentRow.Cells["tennhaxb"].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells["diachi"].Value.ToString();
            txt_HinhAnh.Text = dataGridView1.CurrentRow.Cells["hinhanh"].Value.ToString();
            tempHinhAnh = txt_HinhAnh.Text;
            pictureBox1.ImageLocation = duongdan + txt_HinhAnh.Text;
        }
    }
}


