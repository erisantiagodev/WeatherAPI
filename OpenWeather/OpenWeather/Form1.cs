using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenWeather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HttpClient ApiClient = new HttpClient();

        public async Task GetWeather()
        {
            var apiKey = new ApiKey();
            var weatherResponse = new WeatherResponse();

            latitude.Text = Convert.ToString(weatherResponse.Lat);
            longitude.Text = Convert.ToString(weatherResponse.Lon);

            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                string url = $"http://api.openweathermap.org/data/2.5/onecall?lat={weatherResponse.Lat}&lon={weatherResponse.Lon}&exclude=minutely,hourly&units=imperial&appid={apiKey.key}";

                string response = await ApiClient.GetStringAsync(url);

                WeatherResponse weatherObject = JsonConvert.DeserializeObject<WeatherResponse>(response);

                weatherResults.Text = weatherObject.current.weather.FirstOrDefault().main + " " + weatherObject.current.weather.FirstOrDefault().description;
                //weatherResults.Text = weatherObject.daily.temp.FirstOrDefault().day;
            }

            catch
            {
                MessageBox.Show("Please load the weather.");
            }

        }

        private async void forecast_Click(object sender, EventArgs e)
        {
            try
            {
                await GetWeather();
            }

            catch
            {
                //moviePlot.Text = null;
            }
        }
    }
}
