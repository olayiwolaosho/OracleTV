using System;
using System.Collections.Generic;

using Xamarin.Forms;
using New_Estate_Baptist_Church.Models;

namespace New_Estate_Baptist_Church.Views
{
    public partial class AnnouncementSingleView : ContentPage
    {
       

        public AnnouncementSingleView()
        {

        }

        public AnnouncementSingleView(string pushtitle, string pushdate, string pushdetails)
        {
            InitializeComponent();
            BindingContext = new Announcement() { id = "", title = pushtitle, details = pushdetails, date = System.DateTime.Parse(pushdate) };
        }
          

        }



}
