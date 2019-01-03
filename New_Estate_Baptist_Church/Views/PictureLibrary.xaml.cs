using System;
using System.Collections.Generic;

using Xamarin.Forms;
using New_Estate_Baptist_Church.ViewModels;
using Plugin.Connectivity;
using New_Estate_Baptist_Church.Models;

namespace New_Estate_Baptist_Church.Views
{
    public partial class PictureLibrary : ContentPage
    {
        public PictureLibrary()
        {
            InitializeComponent();
            BindingContext = new PictureViewModel();
        }

        private async void OnSinglePictureSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //if (e.SelectedItem == null)
            //{
            //    return;
            //}

            //if (!CrossConnectivity.Current.IsConnected)
            //{
            //    await DisplayAlert("No Internet Connection", "You are currently not connected to the internet. You need to have an active connection to view this picture.", "OK");
            //    return;
            //}

            //var media = e.SelectedItem as Media;


            //await Navigation.PushAsync(new MediaPicturePage()
            //{
            //    BindingContext = media
            //});

        }
    }
}
