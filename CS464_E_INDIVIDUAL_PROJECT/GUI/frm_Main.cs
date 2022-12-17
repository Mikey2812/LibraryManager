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
    public partial class frm_Main : Form
    {
        public frm_Main(string x)
        {
            InitializeComponent();
            lbl_Name.Text = "Hi "+x+" !!!";
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DANGNHAP DN = new DANGNHAP();
            DN.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void quanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QUANLYSACH QLS = new QUANLYSACH();
            QLS.MdiParent = this;
            QLS.Show();
        }

        private void quanLyDocGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QUANLYDOCGIA QLDG = new QUANLYDOCGIA();
            QLDG.MdiParent = this;
            QLDG.Show();
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.NHAXUATBAN QLNXB = new GUI.NHAXUATBAN();
            QLNXB.MdiParent = this;
            QLNXB.Show();
        }

        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.QUANLYTHELOAI QLTL = new GUI.QUANLYTHELOAI();
            QLTL.MdiParent = this;
            QLTL.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.QUANLYNHANVIEN QLNV = new GUI.QUANLYNHANVIEN();
            QLNV.MdiParent = this;
            QLNV.Show();
        }

        private void mượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.MUONTRASACH MTS = new GUI.MUONTRASACH();
            MTS.MdiParent = this;
            MTS.Show();
        }
    }
}
