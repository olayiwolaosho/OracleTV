using System;
using System.Collections.Generic;

using Xamarin.Forms;
using New_Estate_Baptist_Church.ViewModels;
using New_Estate_Baptist_Church.Models;

namespace New_Estate_Baptist_Church.Views
{
    public partial class EventsPage : ContentPage
    {
        public EventsPage()
        {
            InitializeComponent();

            BindingContext = new EventViewModel();
        }


        private async void OnSingleEventSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            var SingleEvent = e.SelectedItem as Event;


            await Navigation.PushAsync(new EventsView()
            {
                BindingContext = SingleEvent
            });
            eventlist.SelectedItem = null;
        }
    }
}
