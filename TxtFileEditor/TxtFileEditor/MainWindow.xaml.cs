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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TxtFileEditor
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

        private void autoSaveBtn_Checked(object sender, RoutedEventArgs e)
        {
            #region UI
            autoSaveBg.Background = Brushes.Green;
            autoSaveBtn.Background = Brushes.Transparent;
            autoSaveEllipse.ClearValue(Canvas.LeftProperty);
            Canvas.SetRight(autoSaveEllipse, 2);
            #endregion
        }

        private void autoSaveBtn_Unchecked(object sender, RoutedEventArgs e)
        {
            #region UI
            autoSaveBg.Background = Brushes.Red;
            autoSaveBtn.Background = Brushes.Transparent;
            autoSaveEllipse.ClearValue(Canvas.RightProperty);
            Canvas.SetLeft(autoSaveEllipse, 1);
            #endregion
        }
    }
}
