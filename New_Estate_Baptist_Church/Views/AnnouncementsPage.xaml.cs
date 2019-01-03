using System;
using System.Collections.Generic;
using New_Estate_Baptist_Church.Models;
using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class AnnouncementsPage : ContentPage
    {
        public AnnouncementsPage()
        {
            InitializeComponent();
            BindingContext = new AnnouncementsViewModel();
        }

        private async void OnSingleAnnouncementSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            var SingleAnnouncement = e.SelectedItem as Announcement;


            await Navigation.PushAsync(new AnnouncementSingleView()
            {
                BindingContext = SingleAnnouncement
            });

            announcementlist.SelectedItem = null;
        }
    }
}
