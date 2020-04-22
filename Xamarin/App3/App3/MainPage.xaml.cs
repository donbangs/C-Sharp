using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    { 
        public MainPage()
        {
            InitializeComponent();
        }

       async private void Button_Clicked(object sender, EventArgs e)
        {
                string url = address.Text+property.Text;
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("appKey", appKey.Text);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                string result = await response.Content.ReadAsStringAsync();
                JObject jObject = JObject.Parse(result);
                currentValue.Text = "Current value: " +jObject["rows"][0][property.Text].ToString();
                }

        }

       async private void Button_Clicked_1(object sender, EventArgs e)
        {
            string url = address.Text + property.Text;
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("appKey", appKey.Text);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await httpClient.PutAsync(url,new StringContent("{\"" + property.Text + "\":" + ey.Text + "}", Encoding.UTF8, "application/json"));
        }
    }
}
