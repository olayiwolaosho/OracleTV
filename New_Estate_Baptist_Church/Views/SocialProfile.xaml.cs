using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class SocialProfile : ContentPage
    {
        public SocialProfile()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/NewEstateBaptistChurch/"));
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.instagram.com/newestatebaptistchurch/"));
        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.twitter.com/nebcsurulere"));

        }
    }
}
