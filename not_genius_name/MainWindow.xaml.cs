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

        public Passport Passports { get; set; }
        public Snils Snilses { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            httpClient.BaseAddress = new Uri("http://localhost:5065/api/");
            DataContext = this;
        }



        private void AddPassport(object sender, RoutedEventArgs e)
        {

        }

        private void AddSnils(object sender, RoutedEventArgs e)
        {

        }

        private void SearchPassport(object sender, RoutedEventArgs e)
        {

        }

        private void SearchSnils(object sender, RoutedEventArgs e)
        {

        }

        private void DeletePassport(object sender, RoutedEventArgs e)
        {

        }
    }
}