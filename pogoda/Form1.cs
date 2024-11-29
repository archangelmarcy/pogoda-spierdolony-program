using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace pogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,relative_humidity_2m,wind_speed_10m,wind_direction_10m";
            HttpResponseMessage response = client.GetAsync(url).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            pogodabox.Text = json;
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            temperaturabox.Text = apiResponse.current.temperature_2m.ToString();
            temperaturabox.Text += " ";
            temperaturabox.Text += apiResponse.current_units.temperature_2m;
            wilgocbox.Text += apiResponse.current.relative_humidity_2m;
        }
    }
}
