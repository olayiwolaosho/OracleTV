using System;
using System.Collections.Generic;
using New_Estate_Baptist_Church.Models;
using Plugin.Connectivity;
using Xamarin.Forms;
using New_Estate_Baptist_Church.ViewModels;

namespace New_Estate_Baptist_Church.Views
{
    public partial class AudioLibrary : ContentPage
    {
        public AudioLibrary()
        {
            InitializeComponent();
            BindingContext = new AudioViewModel();
        }

        private async void OnSingleAudioSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("No Internet Connection", "You are currently not connected to the internet. " +
                                   "You need to have an active connection to listen to this audio.", "OK");
                return;
            }

            var media = e.SelectedItem as Media;


            //await Navigation.PushAsync(new MediaAudioPage()
            //{
            //    BindingContext = media
            //});

            await Navigation.PushAsync(new WebAudio(media)
            {
                BindingContext = media
            });

            listViewAudio.SelectedItem = null;
        }



    }
}
