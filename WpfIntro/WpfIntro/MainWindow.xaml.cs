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

namespace WpfIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeButtons();
            this.Title = "Buttons :-)";
        }

        private void InitializeButtons()
        {
            Button[] buttons = { btn1, btn2, btn3, btn4, btn5, btn6 };
            foreach (var currentBtn in buttons)
            {
                currentBtn.Background = new SolidColorBrush(getRandomColor());
            }
        }

        private Color getRandomColor()
        {
            Random random = new Random();
            return Color.FromRgb((byte)random.Next(1, 256), (byte)random.Next(1, 256), (byte)random.Next(1, 256));
        }


        private void BtnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(sender is Button btn)
            {
                if(e.LeftButton == MouseButtonState.Pressed)
                {
                    btn.Background = new SolidColorBrush(getRandomColor());
                    MessageBox.Show($"Button {btn.Content} pressed", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if(e.RightButton== MouseButtonState.Pressed)
                {
                    this.Title = btn.Content.ToString();
                    container.Children.Remove(btn);
                }
            }
        }
    }
}
