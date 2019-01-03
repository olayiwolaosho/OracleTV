using System;
using System.Collections.Generic;
using New_Estate_Baptist_Church.Models;
using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class SermonSingleView : ContentPage
    {
        private string videoId;

        public SermonSingleView()
        {
            InitializeComponent();
        }

        public SermonSingleView(string videoId)
        {
            //this.videoId = videoId;
            InitializeComponent();
            BindingContext = new Sermon();
            App.videourl = "https://www.youtube.com/embed/" + videoId;


            App.videoView = youtubeVideo;
            //  this.Content = App.videoView;
            App.videoView.Source = App.videourl;
            App.videostart = true;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await progressBar.ProgressTo(0.9, 900, Easing.SpringIn);

        }
        private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            progressBar.IsVisible = true;
        }

        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            progressBar.IsVisible = false;


        }
    }
}
