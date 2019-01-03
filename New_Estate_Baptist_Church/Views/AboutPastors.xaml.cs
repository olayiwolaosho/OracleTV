using System;
using System.Collections.Generic;

using Xamarin.Forms;
using New_Estate_Baptist_Church.Models;

namespace New_Estate_Baptist_Church.Views
{
    public partial class AboutPastors : ContentPage
    {
        public AboutPastors()
        {
            InitializeComponent();
            Ourpastor ourpastor = new Ourpastor();
            Listview.ItemsSource = ourpastor.GetPastors();
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var item = e.SelectedItem as pastor;

            Navigation.PushAsync(new singlepastor() {

                BindingContext = item
            });
            Listview.SelectedItem = null;
        }
    }
}
