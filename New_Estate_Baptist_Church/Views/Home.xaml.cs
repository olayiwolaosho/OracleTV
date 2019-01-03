using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AboutUs());
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MediaLibrary());
        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DaonattionPage());
        }


        void Handle_Clicked_3(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EventAnnouncement());
        }
    }
}
