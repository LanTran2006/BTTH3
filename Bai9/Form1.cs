using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai9 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            LoadData();
        }

        private void LoadData() {
            // Thêm các môn học vào listbox bên trái
            listBoxMonHoc.Items.Add("Cơ Sở Dữ Liệu");
            listBoxMonHoc.Items.Add("Cơ Sở Dữ Liệu Nâng Cao");
            listBoxMonHoc.Items.Add("Phân Tích Thiết Kế Hệ Thống Thông Tin");

            // Thêm chuyên ngành vào combobox
            cboChuyenNganh.Items.Add("Hệ Thống Thông Tin");
            cboChuyenNganh.Items.Add("Công Nghệ Phần Mềm");
            cboChuyenNganh.Items.Add("Khoa Học Máy Tính");
            cboChuyenNganh.SelectedIndex = 0;

            // Cấu hình DataGridView
            dgvSinhVien.Columns.Add("MSSV", "MSSV");
            dgvSinhVien.Columns.Add("HoTen", "Họ Tên");
            dgvSinhVien.Columns.Add("ChuyenNganh", "Chuyên Ngành");
            dgvSinhVien.Columns.Add("GioiTinh", "Giới Tính");
            dgvSinhVien.Columns.Add("SoMon", "Số Môn");
            foreach (DataGridViewColumn col in dgvSinhVien.Columns) {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnChon_Click(object sender, EventArgs e) {
            if (listBoxMonHoc.SelectedItem != null) {
                listBoxDaChon.Items.Add(listBoxMonHoc.SelectedItem);
                listBoxMonHoc.Items.Remove(listBoxMonHoc.SelectedItem);
            }
        }

        private void btnBoChon_Click(object sender, EventArgs e) {
            if (listBoxDaChon.SelectedItem != null) {
                listBoxMonHoc.Items.Add(listBoxDaChon.SelectedItem);
                listBoxDaChon.Items.Remove(listBoxDaChon.SelectedItem);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            string mssv = txtMSSV.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string chuyennganh = cboChuyenNganh.SelectedItem.ToString();
            string gioitinh = radNam.Checked ? "Nam" : "Nữ";
            int somon = listBoxDaChon.Items.Count;

            if (string.IsNullOrEmpty(mssv) || string.IsNullOrEmpty(hoten)) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!");
                return;
            }

            dgvSinhVien.Rows.Add(mssv, hoten, chuyennganh, gioitinh, somon);
            MessageBox.Show("Lưu thông tin thành công!");

            ClearForm();
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            ClearForm();
        }

        private void ClearForm() {
            txtMSSV.Clear();
            txtHoTen.Clear();
            radNam.Checked = false;
            radNu.Checked = false;

            listBoxDaChon.Items.Clear();
            listBoxMonHoc.Items.Clear();

            LoadData();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e) {

        }

        private void lblChuyenNganh_Click(object sender, EventArgs e) {

        }

        private void cboChuyenNganh_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
