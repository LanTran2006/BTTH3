using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Bai2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Random rd = new Random();

            // Lấy giới hạn chiều rộng và chiều cao thực tế của canvas
            double maxX = canvas.ActualWidth - text.ActualWidth;
            double maxY = canvas.ActualHeight - text.ActualHeight;

            // Sinh toạ độ ngẫu nhiên trong giới hạn
            int x = rd.Next(0, (int)Math.Max(0, maxX));
            int y = rd.Next(0, (int)Math.Max(0, maxY));

            // Đặt vị trí mới cho TextBlock (hoặc Label)
            Canvas.SetLeft(text, x);
            Canvas.SetTop(text, y);
        }
    }
}
