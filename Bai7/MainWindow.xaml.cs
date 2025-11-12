using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Bai7 {
    public partial class MainWindow : Window {
        private Button[] ghe = new Button[15];
        private Dictionary<int, int> giaVe = new Dictionary<int, int>();
        private List<int> gheDangChon = new List<int>();

        public MainWindow() {
            InitializeComponent();
            KhoiTaoGiaVe();
            TaoGhe();
        }

        private void KhoiTaoGiaVe() {
            // A: 1-5 = 5000, B: 6-10 = 6500, C: 11-15 = 8000
            for (int i = 1; i <= 5; i++) giaVe[i] = 5000;
            for (int i = 6; i <= 10; i++) giaVe[i] = 6500;
            for (int i = 11; i <= 15; i++) giaVe[i] = 8000;
        }

        private void TaoGhe() {
            // SeatGrid được đặt tên trong XAML (x:Name="SeatGrid")
            for (int i = 0; i < 15; i++) {
                var btn = new Button
                {
                    Content = (i + 1).ToString(),
                    Margin = new Thickness(5),
                    Background = Brushes.White,
                    FontWeight = FontWeights.Bold
                };
                btn.Click += ChonGhe_Click;
                ghe[i] = btn;
                SeatGrid.Children.Add(btn);
            }
        }

        private void ChonGhe_Click(object sender, RoutedEventArgs e) {
            var btn = sender as Button;
            if (btn == null) return;

            if (!int.TryParse(btn.Content.ToString(), out int soGhe)) return;

            // Nếu đã bán (vàng) -> thông báo
            if (btn.Background == Brushes.Yellow) {
                MessageBox.Show($"Ghế {soGhe} đã được bán!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            // Chưa bán (trắng) -> chuyển sang chọn (xanh)
            if (btn.Background == Brushes.White) {
                btn.Background = Brushes.Blue;
                if (!gheDangChon.Contains(soGhe)) gheDangChon.Add(soGhe);
            }
            // Nếu đang chọn (xanh) -> bỏ chọn (trắng)
            else if (btn.Background == Brushes.Blue) {
                btn.Background = Brushes.White;
                gheDangChon.Remove(soGhe);
            }
        }

        private void btnChon_Click(object sender, RoutedEventArgs e) {
            int tongTien = 0;
            foreach (int soGhe in new List<int>(gheDangChon)) {
                // đánh dấu đã bán
                ghe[soGhe - 1].Background = Brushes.Yellow;
                if (giaVe.TryGetValue(soGhe, out int price)) tongTien += price;
            }
            gheDangChon.Clear();
            lblThanhTien.Text = tongTien.ToString();
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e) {
            foreach (int soGhe in new List<int>(gheDangChon)) {
                ghe[soGhe - 1].Background = Brushes.White;
            }
            gheDangChon.Clear();
            lblThanhTien.Text = "0";
        }

        private void btnKetThuc_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
