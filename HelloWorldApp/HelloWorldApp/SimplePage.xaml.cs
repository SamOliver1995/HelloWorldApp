using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloWorldApp
{
    public partial class SimplePage : ContentPage
    {
        public SimplePage()
        {
            InitializeComponent();
        }

        private void HomeButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HelloWorldPage());
        }
    }
}
