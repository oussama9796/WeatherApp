using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "b8b792ee3e47593ddd0fb29069d2aade";

        private void button1_Click(object sender, EventArgs e)
        {

            getWeather();

        }

        void getWeather() 
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", Stadnaam.Text, APIKey);
                var json = web.DownloadString(url);
                Weatherinfo.root Info = JsonConvert.DeserializeObject<Weatherinfo.root>(json);

                labelCondition.Text = Info.weather[0].main;
                labelDetails.Text = Info.weather[0].description;
                labSunset.Text = Info.sys.sunset.ToString();
                labSunrise.Text = Info.sys.sunrise.ToString();

                labWindSpeed.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString();
                labelTemp.Text = Info.main.temp.ToString();
            }


        }
    }
}
