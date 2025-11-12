namespace Bai4
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e) {
            // T?o h?p tho?i ch?n màu
            using (ColorDialog colorDialog = new ColorDialog()) {
                // Hi?n th? h?p tho?i
                if (colorDialog.ShowDialog() == DialogResult.OK) {
                    // ??i màu n?n form theo màu ???c ch?n
                    this.BackColor = colorDialog.Color;
                }
            }
        }
    }
}
