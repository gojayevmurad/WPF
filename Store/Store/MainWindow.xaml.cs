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

namespace Store
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public class Filter
    {
        public string Title { get; set; }
    }

    public partial class MainWindow : Window
    {
        public List<Filter> Filters { get; set; } = new List<Filter>
        {
            new Filter
            {
                Title="Salam"
            },
            new Filter
            {
                Title = "BismiAllah"
            }
        };

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                
        }


    }
}
