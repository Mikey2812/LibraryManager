
namespace CS464_E_INDIVIDUAL_PROJECT.GUI
{
    partial class MUONTRASACH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_NhanVien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MaPhieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaDocGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_SoCTPM = new System.Windows.Forms.Label();
            this.btn_GiaHan = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_All = new System.Windows.Forms.Button();
            this.btn_XoaCT = new System.Windows.Forms.Button();
            this.btn_SuaCT = new System.Windows.Forms.Button();
            this.btn_ThemCT = new System.Windows.Forms.Button();
            this.rtb_TinhTrang = new System.Windows.Forms.RichTextBox();
            this.cb_MaPhieuMuon = new System.Windows.Forms.ComboBox();
            this.cb_MaSach = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1057, 45);
            this.label1.TabIndex = 60;
            this.label1.Text = "MƯỢN TRẢ SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 680);
            this.tabControl1.TabIndex = 61;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtp_NgayTra);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dtp_NgayMuon);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btn_Thoat);
            this.tabPage1.Controls.Add(this.btn_Xoa);
            this.tabPage1.Controls.Add(this.btn_Sua);
            this.tabPage1.Controls.Add(this.btn_Them);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.cb_NhanVien);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_MaPhieu);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_MaDocGia);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1004, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lập phiếu mượn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtp_NgayTra
            // 
            this.dtp_NgayTra.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtp_NgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayTra.Location = new System.Drawing.Point(718, 250);
            this.dtp_NgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(231, 22);
            this.dtp_NgayTra.TabIndex = 94;
            this.dtp_NgayTra.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(551, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 93;
            this.label5.Text = "Ngày hẹn trả:";
            // 
            // dtp_NgayMuon
            // 
            this.dtp_NgayMuon.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtp_NgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayMuon.Location = new System.Drawing.Point(248, 250);
            this.dtp_NgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgayMuon.Name = "dtp_NgayMuon";
            this.dtp_NgayMuon.Size = new System.Drawing.Size(231, 22);
            this.dtp_NgayMuon.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(91, 248);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 91;
            this.label8.Text = "Ngày mượn:";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Image = global::CS464_E_INDIVIDUAL_PROJECT.Properties.Resources.exit1;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.Location = new System.Drawing.Point(829, 177);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(90, 40);
            this.btn_Thoat.TabIndex = 90;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::CS464_E_INDIVIDUAL_PROJECT.Properties.Resources.delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.Location = new System.Drawing.Point(677, 177);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(90, 40);
            this.btn_Xoa.TabIndex = 89;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::CS464_E_INDIVIDUAL_PROJECT.Properties.Resources.update;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.Location = new System.Drawing.Point(829, 110);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(90, 40);
            this.btn_Sua.TabIndex = 88;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Them.Image = global::CS464_E_INDIVIDUAL_PROJECT.Properties.Resources.add;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.Location = new System.Drawing.Point(677, 110);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(90, 40);
            this.btn_Them.TabIndex = 87;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 338);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(894, 284);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cb_NhanVien
            // 
            this.cb_NhanVien.FormattingEnabled = true;
            this.cb_NhanVien.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_NhanVien.Location = new System.Drawing.Point(248, 193);
            this.cb_NhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cb_NhanVien.Name = "cb_NhanVien";
            this.cb_NhanVien.Size = new System.Drawing.Size(231, 24);
            this.cb_NhanVien.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(50, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 25);
            this.label7.TabIndex = 84;
            this.label7.Text = "Người lập phiếu:";
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.Location = new System.Drawing.Point(248, 91);
            this.txt_MaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.Size = new System.Drawing.Size(165, 22);
            this.txt_MaPhieu.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(111, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "Mã phiếu:";
            // 
            // txt_MaDocGia
            // 
            this.txt_MaDocGia.Location = new System.Drawing.Point(248, 144);
            this.txt_MaDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaDocGia.Name = "txt_MaDocGia";
            this.txt_MaDocGia.Size = new System.Drawing.Size(165, 22);
            this.txt_MaDocGia.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(94, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 76;
            this.label6.Text = "Mã độc giả:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1000, 45);
            this.label2.TabIndex = 60;
            this.label2.Text = "Lập phiếu mượn sách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_SoCTPM);
            this.tabPage2.Controls.Add(this.btn_GiaHan);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btn_All);
            this.tabPage2.Controls.Add(this.btn_XoaCT);
            this.tabPage2.Controls.Add(this.btn_SuaCT);
            this.tabPage2.Controls.Add(this.btn_ThemCT);
            this.tabPage2.Controls.Add(this.rtb_TinhTrang);
            this.tabPage2.Controls.Add(this.cb_MaPhieuMuon);
            this.tabPage2.Controls.Add(this.cb_MaSach);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1004, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi tiết mượn trả";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_SoCTPM
            // 
            this.lbl_SoCTPM.AutoSize = true;
            this.lbl_SoCTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_SoCTPM.Location = new System.Drawing.Point(43, 250);
            this.lbl_SoCTPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoCTPM.Name = "lbl_SoCTPM";
            this.lbl_SoCTPM.Size = new System.Drawing.Size(239, 25);
            this.lbl_SoCTPM.TabIndex = 101;
            this.lbl_SoCTPM.Text = "Số chi tiết phiếu mượn: ";
            // 
            // btn_GiaHan
            // 
            this.btn_GiaHan.Image = global::CS464_E_INDIVIDUAL_PROJECT.Properties.Resources.up;
            this.btn_GiaHan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GiaHan.Location = new System.Drawing.Point(607, 309);
            this.btn_GiaHan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GiaHan.Name = "btn_GiaHan";
            this.btn_GiaHan.Size = new System.Drawing.Size(112, 40);
            this.btn_GiaHan.TabIndex = 99;
            this.btn_GiaHan.Text = "Gia hạn";
            this.btn_GiaHan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GiaHan.UseVisualStyleBackColor = true;
            this.btn_GiaHan.Click += new System.EventHandler(this.btn_GiaHan_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(45, 372);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(912, 245);
            this.dataGridView2.TabIndex = 98;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btn_All
            // 
            this.btn_All.Image = global::CS464_E_INDIVIDUAL_PROJECT.Properties.Resources.exit1;
            this.btn_All.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_All.Location = new System.Drawing.Point(773, 309);
            this.btn_All.Margin = new System.Windows.Forms.Padding(4);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(133, 40);
            this.btn_All.TabIndex = 97;
            this.btn_All.Text = "Tất cả phiếu";
            this.btn_All.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // btn_XoaCT
            // 
            this.btn_XoaCT.Image = global::CS464_E_INDIVIDUAL_PROJECT.Properties.Resources.delete;
            this.btn_XoaCT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaCT.Location = new System.Drawing.Point(437, 309);
            this.btn_XoaCT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaCT.Name = "btn_XoaCT";
            this.btn_XoaCT.Size = new System.Drawing.Size(90, 40);
            this.btn_XoaCT.TabIndex = 96;
            this.btn_XoaCT.Text = "Xóa";
            this.btn_XoaCT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaCT.UseVisualStyleBackColor = true;
            this.btn_XoaCT.Click += new System.EventHandler(this.btn_XoaCT_Click);
            // 
            // btn_SuaCT
            // 
            this.btn_SuaCT.Image = global::CS464_E_INDIVIDUAL_PROJECT.Properties.Resources.update;
            this.btn_SuaCT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SuaCT.Location = new System.Drawing.Point(271, 309);
            this.btn_SuaCT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaCT.Name = "btn_SuaCT";
            this.btn_SuaCT.Size = new System.Drawing.Size(90, 40);
            this.btn_SuaCT.TabIndex = 95;
            this.btn_SuaCT.Text = "Sửa";
            this.btn_SuaCT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaCT.UseVisualStyleBackColor = true;
            this.btn_SuaCT.Click += new System.EventHandler(this.btn_SuaCT_Click);
            // 
            // btn_ThemCT
            // 
            this.btn_ThemCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ThemCT.Image = global::CS464_E_INDIVIDUAL_PROJECT.Properties.Resources.add;
            this.btn_ThemCT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemCT.Location = new System.Drawing.Point(117, 309);
            this.btn_ThemCT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemCT.Name = "btn_ThemCT";
            this.btn_ThemCT.Size = new System.Drawing.Size(90, 40);
            this.btn_ThemCT.TabIndex = 94;
            this.btn_ThemCT.Text = "Thêm";
            this.btn_ThemCT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemCT.UseVisualStyleBackColor = true;
            this.btn_ThemCT.Click += new System.EventHandler(this.btn_ThemCT_Click);
            // 
            // rtb_TinhTrang
            // 
            this.rtb_TinhTrang.Location = new System.Drawing.Point(239, 157);
            this.rtb_TinhTrang.Name = "rtb_TinhTrang";
            this.rtb_TinhTrang.Size = new System.Drawing.Size(701, 65);
            this.rtb_TinhTrang.TabIndex = 93;
            this.rtb_TinhTrang.Text = "";
            // 
            // cb_MaPhieuMuon
            // 
            this.cb_MaPhieuMuon.FormattingEnabled = true;
            this.cb_MaPhieuMuon.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_MaPhieuMuon.Location = new System.Drawing.Point(239, 85);
            this.cb_MaPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.cb_MaPhieuMuon.Name = "cb_MaPhieuMuon";
            this.cb_MaPhieuMuon.Size = new System.Drawing.Size(138, 28);
            this.cb_MaPhieuMuon.TabIndex = 92;
            this.cb_MaPhieuMuon.SelectedIndexChanged += new System.EventHandler(this.cb_MaPhieuMuon_SelectedIndexChanged);
            // 
            // cb_MaSach
            // 
            this.cb_MaSach.FormattingEnabled = true;
            this.cb_MaSach.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_MaSach.Location = new System.Drawing.Point(709, 86);
            this.cb_MaSach.Margin = new System.Windows.Forms.Padding(4);
            this.cb_MaSach.Name = "cb_MaSach";
            this.cb_MaSach.Size = new System.Drawing.Size(231, 28);
            this.cb_MaSach.TabIndex = 91;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(583, 88);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 25);
            this.label14.TabIndex = 90;
            this.label14.Text = "Tên sách:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(35, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 25);
            this.label9.TabIndex = 82;
            this.label9.Text = "Tình trạng sách:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(40, 85);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 25);
            this.label12.TabIndex = 77;
            this.label12.Text = "Mã phiếu mượn:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1001, 45);
            this.label4.TabIndex = 61;
            this.label4.Text = "Chi tiết mượn trả sách";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MUONTRASACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 765);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "MUONTRASACH";
            this.Text = "MuonTraSach";
            this.Load += new System.EventHandler(this.MuonTraSach_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cb_NhanVien;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_MaPhieu;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_MaDocGia;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.RichTextBox rtb_TinhTrang;
        public System.Windows.Forms.ComboBox cb_MaPhieuMuon;
        public System.Windows.Forms.ComboBox cb_MaSach;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Button btn_XoaCT;
        private System.Windows.Forms.Button btn_SuaCT;
        private System.Windows.Forms.Button btn_ThemCT;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DateTimePicker dtp_NgayTra;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dtp_NgayMuon;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbl_SoCTPM;
        private System.Windows.Forms.Button btn_GiaHan;
    }
}