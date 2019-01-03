using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class DaonattionPage : ContentPage
    {
        public DaonattionPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://churchplus.azurewebsites.net/onlinegiving/churchpluspay/?towerofdavid.org"));
        }
    }
}
