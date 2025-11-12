namespace bai8
{
    public partial class money : Form {
        public money() {
            InitializeComponent();
            dataGridView1.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // Event handlers
            add.Click += Add_Click;
            delete.Click += Delete_Click;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

            // Setup DataGridView columns
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Số tài khoản";
            dataGridView1.Columns[1].Name = "Tên khách hàng";
            dataGridView1.Columns[2].Name = "Địa chỉ khách hàng";
            dataGridView1.Columns[3].Name = "Số tiền";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewColumn col in dataGridView1.Columns) {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }


        }

        private void Add_Click(object sender, EventArgs e) {
            string accountNumber = stk.Text.Trim();
            string customerName = name.Text.Trim();
            string customerAddress = address.Text.Trim();
            string balanceText = textBox2.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(accountNumber) ||
                string.IsNullOrEmpty(customerName) ||
                string.IsNullOrEmpty(customerAddress) ||
                string.IsNullOrEmpty(balanceText)) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!decimal.TryParse(balanceText, out decimal balance)) {
                MessageBox.Show("Số tiền không hợp lệ!");
                return;
            }

            // Check if account exists
            DataGridViewRow existingRow = null;
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == accountNumber) {
                    existingRow = row;
                    break;
                }
            }

            if (existingRow == null) {
                // Add new
                dataGridView1.Rows.Add(accountNumber, customerName, customerAddress, balance.ToString());
                MessageBox.Show("Thêm mới dữ liệu thành công!");
            } else {
                // Update
                existingRow.Cells[1].Value = customerName;
                existingRow.Cells[2].Value = customerAddress;
                existingRow.Cells[3].Value = balance.ToString();
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }

            UpdateTotal();
        }

        private void Delete_Click(object sender, EventArgs e) {
            string accountNumber = stk.Text.Trim();
            if (string.IsNullOrEmpty(accountNumber)) {
                MessageBox.Show("Vui lòng nhập số tài khoản cần xóa!");
                return;
            }

            DataGridViewRow rowToDelete = null;
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == accountNumber) {
                    rowToDelete = row;
                    break;
                }
            }

            if (rowToDelete == null) {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa tài khoản {accountNumber}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes) {
                dataGridView1.Rows.Remove(rowToDelete);
                MessageBox.Show("Xóa tài khoản thành công!");
                UpdateTotal();
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var row = dataGridView1.SelectedRows[0];
            stk.Text = row.Cells[0].Value?.ToString();
            name.Text = row.Cells[1].Value?.ToString();
            address.Text = row.Cells[2].Value?.ToString();
            textBox2.Text = row.Cells[3].Value?.ToString();
        }

        private void UpdateTotal() {
            decimal totalMoney = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                if (row.Cells[3].Value != null && decimal.TryParse(row.Cells[3].Value.ToString(), out decimal balance)) {
                    totalMoney += balance;
                }
            }
            total.Text = totalMoney.ToString();
        }
    }
}
