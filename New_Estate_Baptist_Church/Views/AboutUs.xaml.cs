using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class AboutUs :TabbedPage
    {
        public AboutUs()
        {
            InitializeComponent();


            Children.Add(new AboutPastors()
            {

                Title = "Our Pastors",
                Icon = "priest.png"
            });
            Children.Add(new AboutChurch()
            {
                Title = "About Church",
                Icon = "church.png"
            });

        }
    }
}
