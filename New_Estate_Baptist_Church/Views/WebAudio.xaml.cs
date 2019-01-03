using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;
using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class WebAudio : ContentPage
    {
        Media media;


        public WebAudio(Media _media)
        {
            InitializeComponent();
            BindingContext = media;

            media = _media;
           // CrossDownloadManager.Current.CollectionChanged += (sender, e) => System.Diagnostics.Debug.WriteLine("[DownloadManager] " + e.Action + "-> New Items: " + (e.NewItems?.Count ?? 0) + " at " + e.NewStartingIndex + "|| Old items:" + (e.OldItems?.Count ?? 0) + " at " + e.OldStartingIndex);


        }



        bool isDownloading = true;
        public async void DownloadFile(string filename)
        {

            //await Task.Yield();
            //await Task.Run(() =>
            //{

            //    var downloadManager = CrossDownloadManager.Current;
            //    var file = downloadManager.CreateDownloadFile(filename);
            //    downloadManager.Start(file, true);
            //    while (isDownloading)
            //    {
            //        isDownloading = IsDownloading(file);
            //    }

            //    if (!!isDownloading)
            //    {
            //        DisplayAlert("File Downloaded", "File Downloaded", "OK");

            //    }
            //});

        }
        //public bool IsDownloading(IDownloadFile file)
        //{
        //    if (file == null) return false;
        //    switch (file.Status)
        //    {
        //        case DownloadFileStatus.INITIALIZED:
        //        case DownloadFileStatus.PAUSED:
        //        case DownloadFileStatus.PENDING:
        //        case DownloadFileStatus.RUNNING:
        //            return true;

        //        case DownloadFileStatus.COMPLETED:
        //        case DownloadFileStatus.CANCELED:
        //        case DownloadFileStatus.FAILED:
        //            return true;
        //        default:
        //            throw new ArgumentOutOfRangeException();
        //    }
        //}

        public void Button_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Download", "Download Started", "OK");
            Device.OpenUri(new Uri(media.FilePath));
            try
            {

                //DownloadFile(media.FilePath);

            }
            catch (Exception)
            {


            }
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            if (media.FilePath != null)
            {

                var source = new HtmlWebViewSource();

                var html1 = @"<html><body>
               
<audio controls> 
  <source src=""#"" type=""audio/mpeg"" >
Your browser does not support the audio element.
</ audio >
 </ body></html>";
                string html2 = html1.Replace("#", media.FilePath);
                source.Html = html2;

                webview.Source = source;
                webview.BackgroundColor = new Color(3, 0, 2);
            }
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
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    var Media = (Media)BindingContext;

        //    if (Media.FilePath != null)
        //    {
        //        // webview.Source = Media.FilePath;

        //        //      var source = new HtmlWebViewSource
        //        //      {
        //        //          Html = @"<html><body>
        //        //<h1>Xamarin.Forms</h1>
        //        //<p>Welcome to WebView.</p>
        //        //</body></html>"
        //        //      };

        //        //      var labelhtml = new Xamarin.Forms.Label
        //        //      {
        //        //          VerticalOptions = LayoutOptions.FillAndExpand,
        //        //          HorizontalOptions = LayoutOptions.Fill,
        //        //          Text = source.Html,
        //        //      };
        //        //      var webview = new WebView
        //        //      {
        //        //          Source = Media.FilePath,
        //        //          HorizontalOptions = LayoutOptions.FillAndExpand,
        //        //          VerticalOptions = LayoutOptions.FillAndExpand,
        //        //      };
        //        //      var inMemoryScrollView = new ScrollView
        //        //      {
        //        //          VerticalOptions = LayoutOptions.FillAndExpand,
        //        //          HorizontalOptions = LayoutOptions.Fill,
        //        //          IsClippedToBounds = true,
        //        //          Content = labelhtml
        //        //      };

        //        //      Content = new StackLayout
        //        //      {
        //        //          Children = { webview }
        //        //      };
        //    }
        //}
    }
}
