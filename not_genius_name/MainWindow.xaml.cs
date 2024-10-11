using not_genius_name.Model;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using not_genius_name.Model;

namespace not_genius_name
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HttpClient httpClient = new HttpClient();

        public Passport Passport { get; set; }
        public Snils Snils { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            httpClient.BaseAddress = new Uri("http://localhost:5065/api/");
            DataContext = this;
        }



        private void AddPassport(object sender, RoutedEventArgs e)
        {
            AddPassportWin addPassportWin = new AddPassportWin();
            addPassportWin.Show();
        }

        private void AddSnils(object sender, RoutedEventArgs e)
        {
            AddSnilsWin addSnilsWin = new AddSnilsWin();
            addSnilsWin.Show();
        }

        private void SearchPassport(object sender, RoutedEventArgs e)
        {
            SearchPassportWin searchPassportWin = new SearchPassportWin();
            searchPassportWin.Show();
        }

        private void SearchSnils(object sender, RoutedEventArgs e)
        {
            SearchSnilsWin searchSnilsWin = new SearchSnilsWin();
            searchSnilsWin.Show();
        }


        private void DeletePassport(object sender, RoutedEventArgs e)
        {
            DeletePassportWin deletePassportWin = new DeletePassportWin();
            deletePassportWin.Show();
        }
    }
}