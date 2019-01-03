using System;
using System.Collections.Generic;
using New_Estate_Baptist_Church.Models;
using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class EventsView : ContentPage
    {
        private int v;
       

        public EventsView()
        {
            InitializeComponent();
        }

        public EventsView(int v, string pushtitle, string pushdate, string pushdetails, string pushothers, string pushimagelink)
        {
            InitializeComponent();
            BindingContext = new Event() { id = "", name = pushtitle, venue = pushothers, description = pushdetails, startDate = System.DateTime.Parse(pushdate), imagePath = pushimagelink };
        }
    }
}
