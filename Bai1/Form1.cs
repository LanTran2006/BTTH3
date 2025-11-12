namespace Bai1
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // S? ki?n x?y ra khi kh?i t?o Form (tr??c Load)
            this.HandleCreated += Form1_HandleCreated;
            this.Load += Form1_Load;
            this.Shown += Form1_Shown;
            this.Activated += Form1_Activated;
            this.Deactivate += Form1_Deactivate;
            this.Resize += Form1_Resize;
            this.FormClosing += Form1_FormClosing;
            this.FormClosed += Form1_FormClosed;
        }

        private void Form1_HandleCreated(object sender, EventArgs e) {
            MessageBox.Show("HandleCreated: Tay c?m (Handle) c?a form ???c t?o!");
        }

        private void Form1_Load(object sender, EventArgs e) {
            MessageBox.Show("Load: D? li?u ???c n?p và Form s?n sàng hi?n th?!");
        }

        private void Form1_Shown(object sender, EventArgs e) {
            MessageBox.Show("Shown: Form ?ã hi?n th? trên màn hình!");
        }

        private void Form1_Activated(object sender, EventArgs e) {
            Console.WriteLine("Activated: Form ???c kích ho?t!");
        }

        private void Form1_Deactivate(object sender, EventArgs e) {
            Console.WriteLine("Deactivate: Form m?t tiêu ?i?m!");
        }

        private void Form1_Resize(object sender, EventArgs e) {
            Console.WriteLine("Resize: Kích th??c Form thay ??i!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            MessageBox.Show("FormClosing: Form s?p ?óng!");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            MessageBox.Show("FormClosed: Form ?ã ?óng!");
        }
    }
}
