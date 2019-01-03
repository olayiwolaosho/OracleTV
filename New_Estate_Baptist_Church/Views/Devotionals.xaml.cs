using System;
using System.Collections.Generic;

using Xamarin.Forms;
using New_Estate_Baptist_Church.ViewModels;
using New_Estate_Baptist_Church.Models;

namespace New_Estate_Baptist_Church.Views
{
    public partial class Devotionals : ContentPage
    {
        public Devotionals()
        {
            InitializeComponent();
            BindingContext = new  DevotionalViewModel();
        }

        private async void OnSingleAnnouncementSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            var SingleDevotional = e.SelectedItem as Devotional;


            await Navigation.PushAsync(new DevotionalSingleView()
            {
                BindingContext = SingleDevotional
            });
        }
    }
}
