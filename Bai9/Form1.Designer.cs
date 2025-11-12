namespace Bai9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private Label lblMSSV, lblHoTen, lblChuyenNganh, lblGioiTinh, lblMonHoc;
        private TextBox txtMSSV, txtHoTen;
        private ComboBox cboChuyenNganh;
        private RadioButton radNam, radNu;
        private ListBox listBoxMonHoc, listBoxDaChon;
        private Button btnChon, btnBoChon, btnLuu, btnXoa;
        private DataGridView dgvSinhVien;

        private void InitializeComponent() {
            lblMSSV = new Label();
            lblHoTen = new Label();
            lblChuyenNganh = new Label();
            lblGioiTinh = new Label();
            lblMonHoc = new Label();
            txtMSSV = new TextBox();
            txtHoTen = new TextBox();
            cboChuyenNganh = new ComboBox();
            radNam = new RadioButton();
            radNu = new RadioButton();
            listBoxMonHoc = new ListBox();
            listBoxDaChon = new ListBox();
            btnChon = new Button();
            btnBoChon = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            dgvSinhVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // lblMSSV
            // 
            lblMSSV.Location = new Point(50, 40);
            lblMSSV.Name = "lblMSSV";
            lblMSSV.Size = new Size(237, 36);
            lblMSSV.TabIndex = 0;
            lblMSSV.Text = "Mã Sinh Viên";
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(50, 113);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(163, 32);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ Tên";
            // 
            // lblChuyenNganh
            // 
            lblChuyenNganh.Location = new Point(35, 180);
            lblChuyenNganh.Name = "lblChuyenNganh";
            lblChuyenNganh.Size = new Size(200, 37);
            lblChuyenNganh.TabIndex = 2;
            lblChuyenNganh.Text = "Chuyên Ngành";
            lblChuyenNganh.Click += lblChuyenNganh_Click;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(35, 246);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(172, 54);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // lblMonHoc
            // 
            lblMonHoc.Location = new Point(21, 371);
            lblMonHoc.Name = "lblMonHoc";
            lblMonHoc.Size = new Size(376, 57);
            lblMonHoc.TabIndex = 4;
            lblMonHoc.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(300, 45);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(380, 43);
            txtMSSV.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(304, 110);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(376, 43);
            txtHoTen.TabIndex = 6;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // cboChuyenNganh
            // 
            cboChuyenNganh.Location = new Point(304, 180);
            cboChuyenNganh.Name = "cboChuyenNganh";
            cboChuyenNganh.Size = new Size(390, 45);
            cboChuyenNganh.TabIndex = 7;
            cboChuyenNganh.SelectedIndexChanged += cboChuyenNganh_SelectedIndexChanged;
            // 
            // radNam
            // 
            radNam.Location = new Point(284, 231);
            radNam.Name = "radNam";
            radNam.Size = new Size(164, 63);
            radNam.TabIndex = 8;
            radNam.Text = "Nam";
            // 
            // radNu
            // 
            radNu.Location = new Point(464, 231);
            radNu.Name = "radNu";
            radNu.Size = new Size(94, 63);
            radNu.TabIndex = 9;
            radNu.Text = "Nữ";
            // 
            // listBoxMonHoc
            // 
            listBoxMonHoc.ItemHeight = 37;
            listBoxMonHoc.Location = new Point(425, 327);
            listBoxMonHoc.Name = "listBoxMonHoc";
            listBoxMonHoc.Size = new Size(348, 152);
            listBoxMonHoc.TabIndex = 10;
            // 
            // listBoxDaChon
            // 
            listBoxDaChon.ItemHeight = 37;
            listBoxDaChon.Location = new Point(1027, 327);
            listBoxDaChon.Name = "listBoxDaChon";
            listBoxDaChon.Size = new Size(389, 152);
            listBoxDaChon.TabIndex = 11;
            // 
            // btnChon
            // 
            btnChon.Location = new Point(842, 338);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(108, 60);
            btnChon.TabIndex = 12;
            btnChon.Text = ">";
            btnChon.Click += btnChon_Click;
            // 
            // btnBoChon
            // 
            btnBoChon.Location = new Point(842, 423);
            btnBoChon.Name = "btnBoChon";
            btnBoChon.Size = new Size(108, 56);
            btnBoChon.TabIndex = 13;
            btnBoChon.Text = "<";
            btnBoChon.Click += btnBoChon_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(516, 517);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(220, 62);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu Thông Tin";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(801, 517);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(237, 62);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa Chọn";
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeight = 46;
            dgvSinhVien.Location = new Point(1, 606);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 82;
            dgvSinhVien.Size = new Size(1789, 527);
            dgvSinhVien.TabIndex = 16;
            // 
            // Form1
            // 
            ClientSize = new Size(1786, 1204);
            Controls.Add(lblMSSV);
            Controls.Add(lblHoTen);
            Controls.Add(lblChuyenNganh);
            Controls.Add(lblGioiTinh);
            Controls.Add(lblMonHoc);
            Controls.Add(txtMSSV);
            Controls.Add(txtHoTen);
            Controls.Add(cboChuyenNganh);
            Controls.Add(radNam);
            Controls.Add(radNu);
            Controls.Add(listBoxMonHoc);
            Controls.Add(listBoxDaChon);
            Controls.Add(btnChon);
            Controls.Add(btnBoChon);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(dgvSinhVien);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Nhập Liệu Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
    }
}
