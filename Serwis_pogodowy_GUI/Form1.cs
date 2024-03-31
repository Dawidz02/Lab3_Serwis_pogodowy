
using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Linq;
using System;


namespace Serwis_pogodowy_GUI
{
    public partial class Form1 : Form
    {
        string APIkey = "3ff33f75991ed3dc61c41462c58bbaf4";
        private BazaPogoda Baza_pogody;
        public Form1()
        {
            InitializeComponent();
            Baza_pogody = new BazaPogoda();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var pogodaRecords = Baza_pogody.PogodaInicjalizuj.ToList<Pogoda_inicjalizuj>();
            int numberOfRecords = pogodaRecords.Count;
            getWeather();
            Baza_pogody.PogodaInicjalizuj.Add(new Pogoda_inicjalizuj()
            {
                Id = numberOfRecords + 1,
                temperatura = float.Parse(labelTemp.Text),
                cisnienie = float.Parse(labelCisnienie.Text),
                miasto = TBCity.Text
            });
            Baza_pogody.SaveChanges();
            pogodaRecords = Baza_pogody.PogodaInicjalizuj.ToList<Pogoda_inicjalizuj>();
            listBox1.DataSource = pogodaRecords;
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={TBCity.Text}&appid={APIkey}&units=metric&lang=pl";
                var json = web.DownloadString(url);
                Pogoda.root r = JsonConvert.DeserializeObject<Pogoda.root>(json);

                pictureBox1.ImageLocation = "http://openweathermap.org/img/w/" + r.weather[0].icon + ".png";
                //pictureBox1.ImageLocation = "https://png.pngtree.com/png-vector/20230408/ourmid/pngtree-picture-of-blue-dreamy-glowing-butterfly-png-image_6681316.png";

                labelTest.Text = pictureBox1.ImageLocation;
                labelTemp.Text = r.main.temp.ToString();
                labelCisnienie.Text = r.main.pressure.ToString();
            }
        }

        private void button_usun_Click(object sender, EventArgs e)
        {
            Baza_pogody.PogodaInicjalizuj.RemoveRange(Baza_pogody.PogodaInicjalizuj);
            Baza_pogody.SaveChanges();
        }

        private void buttonSortowanie_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Baza_pogody.PogodaInicjalizuj.OrderBy(s => s.temperatura).Reverse().ToList<Pogoda_inicjalizuj>();
        }
    }
}

