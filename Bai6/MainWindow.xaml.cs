using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Bai6 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        // Append button text to display
        private void Button_Click(object sender, RoutedEventArgs e) {
            Button button = (Button)sender;
            string value = button.Content.ToString();

            if (txtDisplay.Text == "0" || txtDisplay.Text == "Error")
                txtDisplay.Text = value;
            else
                txtDisplay.Text += value;
        }

        // Clear all
        private void Clear_Click(object sender, RoutedEventArgs e) {
            txtDisplay.Text = "0";
        }

        // Clear entry (only last number)
        private void ClearEntry_Click(object sender, RoutedEventArgs e) {
            if (txtDisplay.Text.Length > 0) {
                int i = txtDisplay.Text.LastIndexOfAny(new char[] { '+', '-', '*', '/' });
                if (i >= 0)
                    txtDisplay.Text = txtDisplay.Text.Substring(0, i + 1);
                else
                    txtDisplay.Text = "0";
            }
        }

        // Backspace
        private void Back_Click(object sender, RoutedEventArgs e) {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";
        }

        // Evaluate full expression
        private void Equal_Click(object sender, RoutedEventArgs e) {
            try {
                string expr = txtDisplay.Text.Replace("√", "Sqrt");
                var result = new DataTable().Compute(expr, null);
                txtDisplay.Text = result.ToString();
            }
            catch {
                txtDisplay.Text = "Error";
            }
        }

        // Square root
        private void Sqrt_Click(object sender, RoutedEventArgs e) {
            try {
                double value = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = Math.Sqrt(value).ToString();
            }
            catch {
                txtDisplay.Text = "Error";
            }
        }

        // Reciprocal (1/x)
        private void Reciprocal_Click(object sender, RoutedEventArgs e) {
            try {
                double value = Convert.ToDouble(txtDisplay.Text);
                if (value == 0) throw new DivideByZeroException();
                txtDisplay.Text = (1 / value).ToString();
            }
            catch {
                txtDisplay.Text = "Error";
            }
        }
    }
}
