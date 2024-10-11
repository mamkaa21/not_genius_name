using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using not_genius_name.Model;

namespace not_genius_name
{
    /// <summary>
    /// Логика взаимодействия для SearchPassportWin.xaml
    /// </summary>
    public partial class SearchPassportWin : Window
    {
        public Search Search { get; set; } = new();

        HttpClient httpClient = new HttpClient();

        public SearchPassportWin()
        {
            InitializeComponent();
            DataContext = this;
            httpClient.BaseAddress = new Uri("http://localhost:5065/api/");
        }
        private async void Check_Post(object sender, RoutedEventArgs e)
        {
            string arg = JsonSerializer.Serialize(Search);
            var responce = await httpClient.PostAsync($"PersonalData/SearchHumanPassport",
                new StringContent(arg, Encoding.UTF8, "application/json"));

            if (responce.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var result = await responce.Content.ReadAsStringAsync();
                return;
            }
            else
            {
                var answer = await responce.Content.ReadFromJsonAsync<Search>();
                MessageBox.Show($"Нашелся человек по паспорту - {answer.ToString()}");
                Close();
            }
        }

    }
}
