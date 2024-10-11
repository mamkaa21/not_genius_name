using not_genius_name.Model;
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

namespace not_genius_name
{
    /// <summary>
    /// Логика взаимодействия для DeletePassportWin.xaml
    /// </summary>
    public partial class DeletePassportWin : Window
    {
        public Passport Passport { get; set; } = new();

        HttpClient httpClient = new HttpClient();

        public DeletePassportWin()
        {
            InitializeComponent();
            DataContext = this;
            httpClient.BaseAddress = new Uri("http://localhost:5065/api/");
        }

        private async void Delete_Post(object sender, RoutedEventArgs e)
        {
            string arg = JsonSerializer.Serialize(Passport);
            var responce = await httpClient.PostAsync($"PersonalData/SendClaim",
                new StringContent(arg, Encoding.UTF8, "application/json"));

            if (responce.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var result = await responce.Content.ReadAsStringAsync();
                return;
            }
            else
            {
                var result = await responce.Content.ReadAsStringAsync();
                MessageBox.Show($"{result.ToString()}))))))))))))))))))))))))))))))))))))))))))))))))))");
                Close();
            }
        }
    }
}
