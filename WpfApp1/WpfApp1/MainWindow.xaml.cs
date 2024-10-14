using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeColor_Click(object sender, RoutedEventArgs e)
        {
            string colorName = (sender as MenuItem)?.Tag?.ToString() ?? (sender as Button)?.Tag?.ToString();
            if (!string.IsNullOrEmpty(colorName))
            {
                this.Background = (System.Windows.Media.Brush)new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(colorName));
            }
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Ваше Имя\nВерсия: 1.0", "О разработчике", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StatusBar_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var element = e.OriginalSource as FrameworkElement;
            if (element != null)
            {
                StatusText.Text = element.ToolTip?.ToString() ?? "Готово";
            }
        }
    }
}