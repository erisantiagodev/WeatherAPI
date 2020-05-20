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
            var weather = new Weather();
            var apiKey = new ApiKey();
            var examples = new Example();

            weather.lat = Convert.ToDouble(latitude.Text);
            weather.lon = Convert.ToDouble(longitude.Text);

            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                string url = $"http://api.openweathermap.org/data/2.5/onecall?lat={weather.lat}&lon={weather.lon}&exclude=minutely,hourly&units=imperial&appid={apiKey.key}";

                string response = await ApiClient.GetStringAsync(url);

                Example weatherObject = JsonConvert.DeserializeObject<Example>(response);
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
