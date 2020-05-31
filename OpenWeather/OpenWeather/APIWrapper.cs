using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather
{
    public class APIWrapper
    {
        public string key = "";
        public string url;
        public string weatherAndTemp;
        public double longitude { get; set; }
        public double latitude { get; set; }

        HttpClient ApiClient = new HttpClient();

        public APIWrapper(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public async Task GetWeathercData()
        {

            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                string url = $"http://api.openweathermap.org/data/2.5/onecall?lat={latitude}&lon={longitude}&exclude=minutely,hourly&units=imperial&appid={key}";

                string response = await ApiClient.GetStringAsync(url);

                WeatherResponse weatherObject = JsonConvert.DeserializeObject<WeatherResponse>(response);

                string weatherInfo = $"The current weather is {weatherObject.current.weather.FirstOrDefault().main} with some {weatherObject.current.weather.FirstOrDefault().description}.";
                string tempInfo = $"The current temperature is {weatherObject.current.temp}";

                weatherAndTemp = weatherInfo + tempInfo;
            }

            catch
            {
                //report.Text = "LOAD DATA";
            }

        }
    }
}
