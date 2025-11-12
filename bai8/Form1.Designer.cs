namespace bai8
{
    partial class money
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
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            name = new TextBox();
            textBox2 = new TextBox();
            address = new TextBox();
            stk = new TextBox();
            label5 = new Label();
            add = new Button();
            delete = new Button();
            exit = new Button();
            label6 = new Label();
            total = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 0;
            label1.Text = "số tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 129);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(198, 37);
            label2.TabIndex = 1;
            label2.Text = "tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 184);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(238, 37);
            label3.TabIndex = 2;
            label3.Text = "địa chỉ khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 258);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(285, 37);
            label4.TabIndex = 3;
            label4.Text = "số tiền trong tài khoản";
            // 
            // name
            // 
            name.Location = new Point(260, 129);
            name.Margin = new Padding(2);
            name.Name = "name";
            name.Size = new Size(553, 43);
            name.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(352, 258);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(553, 43);
            textBox2.TabIndex = 5;
            // 
            // address
            // 
            address.Location = new Point(307, 193);
            address.Margin = new Padding(2);
            address.Name = "address";
            address.Size = new Size(553, 43);
            address.TabIndex = 6;
            // 
            // stk
            // 
            stk.Location = new Point(224, 60);
            stk.Margin = new Padding(2);
            stk.Name = "stk";
            stk.Size = new Size(553, 43);
            stk.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(271, -1);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(743, 59);
            label5.TabIndex = 8;
            label5.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // add
            // 
            add.Location = new Point(482, 332);
            add.Margin = new Padding(2);
            add.Name = "add";
            add.Size = new Size(219, 56);
            add.TabIndex = 9;
            add.Text = "Thêm/cập nhật";
            add.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(745, 338);
            delete.Margin = new Padding(2);
            delete.Name = "delete";
            delete.Size = new Size(148, 50);
            delete.TabIndex = 10;
            delete.Text = "xóa";
            delete.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            exit.Location = new Point(947, 341);
            exit.Margin = new Padding(2);
            exit.Name = "exit";
            exit.Size = new Size(118, 47);
            exit.TabIndex = 11;
            exit.Text = "thoát";
            exit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(849, 909);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 37);
            label6.TabIndex = 12;
            label6.Text = "Tổng tiền:";
            // 
            // total
            // 
            total.Location = new Point(1013, 903);
            total.Margin = new Padding(2);
            total.Name = "total";
            total.Size = new Size(392, 43);
            total.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 395);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1439, 416);
            dataGridView1.TabIndex = 14;
            // 
            // money
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1473, 995);
            Controls.Add(dataGridView1);
            Controls.Add(total);
            Controls.Add(label6);
            Controls.Add(exit);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(label5);
            Controls.Add(stk);
            Controls.Add(address);
            Controls.Add(textBox2);
            Controls.Add(name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "money";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox name;
        private TextBox textBox2;
        private TextBox address;
        private TextBox stk;
        private Label label5;
        private Button add;
        private Button delete;
        private Button exit;
        private Label label6;
        private TextBox total;
        private DataGridView dataGridView1;
    }
}
