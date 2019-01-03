using System;
using System.Collections.Generic;
using New_Estate_Baptist_Church.Models;
using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class ChapterPage : ContentPage
    {
        public List<Verses> getVerses
        {
            get;
            set;
        }


        public ChapterPage()
        {
            InitializeComponent();
            BindingContext = new Chapters();
        }

        public ChapterPage(Book chapters)
        {
            InitializeComponent();
            BindingContext = new Chapters();

            Title = chapters.BookName;
            listView.ItemsSource = chapters.BookChapter;

        }





        public async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {

                return;
            }


            //IsBusy = true;
            ActivityIndicator.IsEnabled = true;
            ActivityIndicator.IsRunning = true;
            ActivityIndicator.IsVisible = true;
            var chapters = e.SelectedItem as Chapters;


            //  Services.BibleServices bible = new Services.BibleServices();

            ChurchPlusServices.BibleApi bible = new ChurchPlusServices.BibleApi();
            var bibleChapters = await bible.GetChapterwithverses(chapters.BookName, chapters.ChapterNumber);
            getVerses = new List<Verses>(bibleChapters);
            await Navigation.PushAsync(new BibleVerse(getVerses, chapters.ChapterNumber)
            {

                BindingContext = new Verses()

            });

            ActivityIndicator.IsEnabled = false;
            ActivityIndicator.IsRunning = false;
            ActivityIndicator.IsVisible = false;
            // IsBusy = false;
        }
    }
}
