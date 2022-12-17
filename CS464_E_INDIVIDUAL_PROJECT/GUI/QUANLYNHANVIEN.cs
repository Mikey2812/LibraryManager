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
    public partial class QUANLYNHANVIEN : Form
    {
        BLL.BLL_NhanVien bllnhanvien;
        string tempHinhAnh;
        public QUANLYNHANVIEN()
        {
            InitializeComponent();
            bllnhanvien = new BLL.BLL_NhanVien(this);
        }
        public void LoadDataGrid()
        {
            bllnhanvien.BLL_Load_Data();
            dateTimePicker1.Value = DateTime.Now;
        }
        public void LoadColumn()
        {
            dataGridView1.Columns[0].HeaderText = "Mã NV";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].HeaderText = "Họ và tên";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].HeaderText = "SDT";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[5].HeaderText = "Giới tính";
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].HeaderText = "CMND";
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[7].HeaderText = "Hình ảnh";
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void QUANLYNHANVIEN_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            LoadColumn();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\NHANVIEN\\";
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                bllnhanvien.BLL_NhanVien_Them();
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
                bllnhanvien.BLL_NhanVien_Sua();
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                bllnhanvien.BLL_NhanVien_Xoa();
                File.Delete(duongdan + txt_HinhAnh.Text);
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
            txt_MaNhanVien.Text = dataGridView1.CurrentRow.Cells["manhanvien"].Value.ToString();
            txt_HoVaTen.Text = dataGridView1.CurrentRow.Cells["hovaten"].Value.ToString();
            txt_SDT.Text = dataGridView1.CurrentRow.Cells["sodienthoai"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["ngaysinh"].Value.ToString();
            cb_GioiTinh.SelectedItem = dataGridView1.CurrentRow.Cells["gioitinh"].Value.ToString();
            txt_CMND.Text = dataGridView1.CurrentRow.Cells["cmnd"].Value.ToString();
            txt_HinhAnh.Text = dataGridView1.CurrentRow.Cells["hinhanh"].Value.ToString();
            tempHinhAnh = txt_HinhAnh.Text;
            pictureBox1.ImageLocation = duongdan + txt_HinhAnh.Text;
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
    }
}
