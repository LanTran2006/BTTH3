using System;
using System.Windows.Forms;

namespace Bai5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            plus.Click += btnAdd_Click;
            minus.Click += btnMinus_Click;
            divide.Click += btnDivide_Click;
            multiply.Click += btnMultiply_Click;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            try {
                double a = double.Parse(num1.Text);
                double b = double.Parse(num2.Text);
                double result = a + b;
                answer.Text = result.ToString();
            }
            catch (FormatException) {
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e) {
            try {
                double a = double.Parse(num1.Text);
                double b = double.Parse(num2.Text);
                double result = a - b;
                answer.Text = result.ToString();
            }
            catch (FormatException) {
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e) {
            try {
                double a = double.Parse(num1.Text);
                double b = double.Parse(num2.Text);
                double result = a * b;
                answer.Text = result.ToString();
            }
            catch (FormatException) {
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e) {
            try {
                double a = double.Parse(num1.Text);
                double b = double.Parse(num2.Text);

                if (b == 0) {
                    MessageBox.Show("Cannot divide by zero.", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double result = a / b;
                answer.Text = result.ToString();
            }
            catch (FormatException) {
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
