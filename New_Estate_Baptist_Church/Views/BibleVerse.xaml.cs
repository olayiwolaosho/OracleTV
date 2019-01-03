using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;
using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class BibleVerse : ContentPage
    {
        private Task<List<Verses>> verfromback;
        private Chapters chapters;

        public BibleVerse()
        {
            InitializeComponent();
        }


        public ObservableCollection<Verses> GetVerses
        {
            get;
            set;
        }









        public BibleVerse(List<Verses> verfromback, int chapterNumber)
        {
            InitializeComponent();
            //var sort = from ver in verfromback
            //where ver.chapter == "Revelation" && ver.chapter == "12"
            //select new Verses()
            //{
            //    text = "thtghtgtbgbckndhvdghcndjchjnhdbnkndbgvbkdbgdvchdg"
            //           //};
            //foreach(var ver in verfromback){
            //    if(ver.bookname=="Revelation"&&ver.chapter=="12"&&ver.verse=="11"){
            //        ver.text = "fhfhfvhdfhvhvhfhbvfhv";

            //    }
            //    verfromback.Add(ver);

            //}

            Title = chapterNumber.ToString();
            myList.ItemsSource = verfromback;


        }


    
}
}
