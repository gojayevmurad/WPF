using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace DataGrid_Dashboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            // create DataGrid Itmes Info

            members.Add(new Member { Number = 1, Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Email = "john.doe@gmail.com", Name = "John Doe", Phone = "415-954-1475", Position = "Coach" });
            members.Add(new Member { Number = 2, Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Email = "reza.alavi@gmail.com", Name = "Reza Alavi", Phone = "134-423-2435", Position = "Administrator" });
            members.Add(new Member { Number = 3, Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Email = "dennis.castillo@gmail.com", Name = "Dennis Castillo", Phone = "946-184-2812", Position = "Coach" });
            members.Add(new Member { Number = 4, Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Email = "gabriel.cox@gmail.com", Name = "Gabriel Cox", Phone = "194-195-4853", Position = "Coach" });
            members.Add(new Member { Number = 5, Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Email = "lena.jones@gmail.com", Name = "Lena Jones", Phone = "821-056-3956", Position = "Manager" });
            members.Add(new Member { Number = 6, Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741d9"), Email = "benjamin.caliword@gmail.com", Name = "Benjamin Caliword", Phone = "682-133-3947", Position = "Administrator" });
            members.Add(new Member { Number = 7, Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Email = "saphia.muris@gmail.com", Name = "Sophia Muris", Phone = "653-391-2034", Position = "Coach" });
            members.Add(new Member { Number = 8, Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Email = "ali.pormand@gmail.com", Name = "Ali Pormand", Phone = "593-163-5232", Position = "Manager" });
            members.Add(new Member { Number = 9, Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e6"), Email = "frank.underwood@gmail.com", Name = "Frank Underwood", Phone = "693-563-2952", Position = "Manager" });
            members.Add(new Member { Number = 10, Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Email = "saeed.dasman@gmail.com", Name = "Saeed Dasman", Phone = "392-687-2952", Position = "Coach" });

            members.Add(new Member { Number = 1, Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Email = "john.doe@gmail.com", Name = "John Doe", Phone = "415-954-1475", Position = "Coach" });
            members.Add(new Member { Number = 2, Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Email = "reza.alavi@gmail.com", Name = "Reza Alavi", Phone = "134-423-2435", Position = "Administrator" });
            members.Add(new Member { Number = 3, Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Email = "dennis.castillo@gmail.com", Name = "Dennis Castillo", Phone = "946-184-2812", Position = "Coach" });
            members.Add(new Member { Number = 4, Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Email = "gabriel.cox@gmail.com", Name = "Gabriel Cox", Phone = "194-195-4853", Position = "Coach" });
            members.Add(new Member { Number = 5, Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Email = "lena.jones@gmail.com", Name = "Lena Jones", Phone = "821-056-3956", Position = "Manager" });
            members.Add(new Member { Number = 6, Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741d9"), Email = "benjamin.caliword@gmail.com", Name = "Benjamin Caliword", Phone = "682-133-3947", Position = "Administrator" });
            members.Add(new Member { Number = 7, Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Email = "saphia.muris@gmail.com", Name = "Sophia Muris", Phone = "653-391-2034", Position = "Coach" });
            members.Add(new Member { Number = 8, Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Email = "ali.pormand@gmail.com", Name = "Ali Pormand", Phone = "593-163-5232", Position = "Manager" });
            members.Add(new Member { Number = 9, Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e6"), Email = "frank.underwood@gmail.com", Name = "Frank Underwood", Phone = "693-563-2952", Position = "Manager" });
            members.Add(new Member { Number = 10, Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Email = "saeed.dasman@gmail.com", Name = "Saeed Dasman", Phone = "392-687-2952", Position = "Coach" });

            members.Add(new Member { Number = 1, Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Email = "john.doe@gmail.com", Name = "John Doe", Phone = "415-954-1475", Position = "Coach" });
            members.Add(new Member { Number = 2, Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Email = "reza.alavi@gmail.com", Name = "Reza Alavi", Phone = "134-423-2435", Position = "Administrator" });
            members.Add(new Member { Number = 3, Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Email = "dennis.castillo@gmail.com", Name = "Dennis Castillo", Phone = "946-184-2812", Position = "Coach" });
            members.Add(new Member { Number = 4, Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Email = "gabriel.cox@gmail.com", Name = "Gabriel Cox", Phone = "194-195-4853", Position = "Coach" });
            members.Add(new Member { Number = 5, Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Email = "lena.jones@gmail.com", Name = "Lena Jones", Phone = "821-056-3956", Position = "Manager" });
            members.Add(new Member { Number = 6, Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741d9"), Email = "benjamin.caliword@gmail.com", Name = "Benjamin Caliword", Phone = "682-133-3947", Position = "Administrator" });
            members.Add(new Member { Number = 7, Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Email = "saphia.muris@gmail.com", Name = "Sophia Muris", Phone = "653-391-2034", Position = "Coach" });
            members.Add(new Member { Number = 8, Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Email = "ali.pormand@gmail.com", Name = "Ali Pormand", Phone = "593-163-5232", Position = "Manager" });
            members.Add(new Member { Number = 9, Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e6"), Email = "frank.underwood@gmail.com", Name = "Frank Underwood", Phone = "693-563-2952", Position = "Manager" });
            members.Add(new Member { Number = 10, Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Email = "saeed.dasman@gmail.com", Name = "Saeed Dasman", Phone = "392-687-2952", Position = "Coach" });

            membersDataGrid.ItemsSource = members;

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool isMaximized = false;

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount == 2)
            {
                if (isMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    isMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    isMaximized = true;
                }
            }
        }
    }

    public class Member
    {
        public string Character { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor { get; set; }
    }
}
