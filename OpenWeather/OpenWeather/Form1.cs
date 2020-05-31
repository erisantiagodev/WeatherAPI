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

        public async Task PrintGetWeathercData()
        {
            double userlatitude = Convert.ToDouble(latitude.Text);
            double userlongitude = Convert.ToDouble(longitude.Text);

            var apiWrapper = new APIWrapper(userlatitude, userlongitude);

            await apiWrapper.GetWeathercData();

            try
            {
                weatherResults.Text = apiWrapper.weatherAndTemp;
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
                await PrintGetWeathercData();
            }

            catch
            {
                //moviePlot.Text = null;
            }
        }
    }
}
