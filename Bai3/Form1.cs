namespace Bai1
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e) {
            Random rnd=new Random();
            Color x=Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            this.BackColor = x;
        }
    }
}
