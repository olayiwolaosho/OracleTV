using System;
using System.Collections.Generic;
using New_Estate_Baptist_Church.Models;
using Plugin.Connectivity;
using Xamarin.Forms;
using New_Estate_Baptist_Church.ViewModels;

namespace New_Estate_Baptist_Church.Views
{
    public partial class VideoLibrary : ContentPage
    {
        public VideoLibrary()
        {
            InitializeComponent();
            BindingContext = new SermonViewModel();
        }

        private async void OnSingleVideoSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //if (e.SelectedItem == null)
            //{
            //    return;
            //}

            //if (!CrossConnectivity.Current.IsConnected)
            //{
            //    await DisplayAlert("No Internet Connection", "You are currently not connected to the internet." +
            //                       " You need to have an active connection to watch this video.", "OK");
            //    return;
            //}

            //var youtubeItem = e.SelectedItem as Sermon;
            //var videoId = youtubeItem.VideoId;

            //await Navigation.PushAsync(new SermonSingleView(videoId)
            //{
            //    BindingContext = youtubeItem
            //});
            //listView.SelectedItem = null;

        }

      public async  void Handle_FlowItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {

            if (e.Item == null)
            {
                return;
            }

            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("No Internet Connection", "You are currently not connected to the internet." +
                                   " You need to have an active connection to watch this video.", "OK");
                return;
            }

            var youtubeItem = e.Item as Sermon;
            var videoId = youtubeItem.VideoId;

            await Navigation.PushAsync(new SermonSingleView(videoId)
            {
                BindingContext = youtubeItem
            });
            //listView.SelectedItem = null;
        }
    }
}
