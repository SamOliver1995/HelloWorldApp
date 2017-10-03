using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloWorldApp
{
    public partial class HelloWorldPage : ContentPage
    {
        public HelloWorldPage()
        {
            InitializeComponent();
        }
        private async void GenerateNFCCodeButton_OnClicked(object sender, EventArgs e)
        {
            //var name = NameEntry.Text;

            var NFC_Code = GenerateNFC_Code();
            //await DisplayAlert("Greeting", $"Hello {name}!", "Howdy");
            await DisplayAlert("NFC Code: ", $"{NFC_Code}!", "Thanks!");
        }

        private void PropertiesButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimplePage());
        }


        private String GenerateNFC_Code()
        {
            String NFC_Code = "13025151";

            return NFC_Code;
        }

        private void sendNFC_Code()
        {

        }

    }
}
