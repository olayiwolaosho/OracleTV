using System;
using System.Collections.Generic;
using New_Estate_Baptist_Church.Models;
using Plugin.Connectivity;
using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class BiblePage : ContentPage
    {
        public List<Verses> getVerses { get; private set; }
        public List<Chapters> GetChapters
        {
            get;
            set;
        }
        public List<Book> GetBooks
        {
            get;
            set;
        }
        public BiblePage()
        {
            InitializeComponent();
            init();
        }

        public async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {


            if (e.SelectedItem == null)
            {
                return;
            }
            else if (CrossConnectivity.Current.IsConnected)
            {
                var chapter = e.SelectedItem as Book;

                await Navigation.PushAsync(new ChapterPage(chapter)
                {
                    BindingContext = chapter

                });

                listView.SelectedItem = null;
            }

            else
            {
                await DisplayAlert("Hello", "the bible service requires an active internet connection", "OK");
            }

        }
        public async void init()
        {


            GetBooks = new List<Book>(){
                new Book(){
                    BookName ="Genesis",BookChapter = Genesis()

                },
                 new Book(){
                    BookName ="Exodus",BookChapter = Exodus()

                },

                 new Book(){
                    BookName ="Leviticus",BookChapter = Leviticus()

                },
                new Book(){
                    BookName ="Numbers",BookChapter = Numbers()

                },

                 new Book(){
                    BookName ="Deuteronomy",BookChapter = Deuteronomy()

                },

                new Book(){
                    BookName ="Joshua",BookChapter = Joshua()

                },
                 new Book(){
                    BookName ="Judges",BookChapter = Judges()

                },
                new Book(){
                    BookName ="Ruth",BookChapter = Ruth()

                },
                 new Book(){
                    BookName ="1 Samuel",BookChapter = onesamuel()

                },
                 new Book(){
                    BookName ="2 Samuel",BookChapter = twosamuel()

                },
                new Book(){
                    BookName ="1 Kings",BookChapter = OneKings()

                },

                new Book(){
                    BookName ="2 Kings",BookChapter = twoKings()

                },

                new Book(){
                    BookName ="1 Chronicles",BookChapter = firstchronicles()

                },
                 new Book(){
                    BookName ="2 Chronicles",BookChapter = secondchronicles()

                },
                new Book(){
                    BookName ="Ezra",BookChapter = Ezra()

                },
                 new Book(){
                    BookName ="Nehemiah",BookChapter = Nehemiah()

                },
                new Book(){
                    BookName ="Esther",BookChapter = Esther()

                },
                new Book(){
                    BookName ="Job",BookChapter = Job()

                },

                 new Book(){
                    BookName ="Psalms",BookChapter = Psalm()

                },
                new Book(){
                    BookName ="Proverbs",BookChapter = Proverbs()

                },
                new Book(){
                    BookName ="Ecclesiastes",BookChapter = Ecclesiastes()

                },

                new Book(){
                    BookName ="Song of Solomon",BookChapter = SongOfSolomon()

                },
                 new Book(){
                    BookName ="Isaiah",BookChapter = Isaiah()

                },
                 new Book(){
                    BookName ="Jeremiah",BookChapter = Jeremiah()

                },
                 new Book(){
                    BookName ="Lamentations",BookChapter = Lamentations()

                },
                 new Book(){
                    BookName ="Ezekiel",BookChapter = Ezekiel()

                },
                 new Book(){
                    BookName ="Daniel",BookChapter = Daniel()

                },
                 new Book(){
                    BookName ="Hosea",BookChapter = Hosea()

                },
                 new Book(){
                    BookName ="Joel",BookChapter = Joel()

                },
                 new Book(){
                    BookName ="Amos",BookChapter = Amos()

                },
                 new Book(){
                    BookName ="Obadiah",BookChapter = Obadiah()

                },
                new Book(){
                    BookName ="Jonah",BookChapter = Jonah()

                },
                 new Book(){
                    BookName ="Micah",BookChapter = Micah()

                },
                new Book(){
                    BookName ="Nahum",BookChapter = Nahum()

                },
                  new Book(){
                    BookName ="Habakuk",BookChapter = Habakuk()

                },

                  new Book(){
                    BookName ="Zephaniah",BookChapter = Zephaniah()

                },
                new Book(){
                    BookName ="Haggai",BookChapter = Haggai()

                },
                new Book(){
                    BookName ="Zechariah",BookChapter = Zechariah()

                },
                new Book(){
                    BookName ="Malachi",BookChapter = Malachai()

                },
                 new Book(){
                    BookName ="Matthew",BookChapter = Matthew()

                },
                 new Book(){
                    BookName ="Mark",BookChapter = Mark()

                },
                 new Book(){
                    BookName ="Luke",BookChapter = Luke()

                },
                 new Book(){
                    BookName ="John",BookChapter = John()

                },
                new Book(){
                    BookName ="Acts",BookChapter = Acts()

                },
                 new Book(){
                    BookName ="Romans",BookChapter = Romans()

                },

                new Book(){
                    BookName ="1 Corinthians",BookChapter = FirstCorinthians()

                },
                new Book(){
                    BookName ="2 Corinthians",BookChapter = SecondCorinthians()

                },
                 new Book(){
                    BookName ="Galatians",BookChapter = Galatians()

                },

                new Book(){
                    BookName ="Ephesians",BookChapter = Ephesians()

                },
                new Book(){
                    BookName ="Philippians",BookChapter = Philippians()

                },
                 new Book(){
                    BookName ="Collosians",BookChapter = Collosians()

                },
                 new Book(){
                    BookName ="1 Thesalonians",BookChapter = FirstThesalonians()

                },
                new Book(){
                    BookName ="2 Thesalonians",BookChapter = SecondThesalonians()

                },
                new Book(){
                    BookName ="1 Timothy",BookChapter =FirstTimothy()

                },
                 new Book(){
                    BookName ="2 Timothy",BookChapter =SecondTimothy()

                },
                new Book(){
                    BookName ="Philemon",BookChapter =Philemon()

                },
                new Book(){
                    BookName ="Hebrews",BookChapter =Hebrews()

                },
                 new Book(){
                    BookName ="James",BookChapter =James()

                },
                 new Book(){
                    BookName ="1 Peter",BookChapter = FirstPeter()

                },

                 new Book(){
                    BookName ="2 Peter",BookChapter = SecondPeter()

                },

                 new Book(){
                    BookName ="1 John",BookChapter = FirstJohn()

                },

                new Book(){
                    BookName ="2 John",BookChapter = SecondJohn()

                },
                new Book(){
                    BookName ="3 John",BookChapter = ThirdJohn()

                },
                 new Book(){
                    BookName ="Jude",BookChapter = Jude()

                },
                 new Book(){
                    BookName ="Revelation",BookChapter = Revelation()

                },
            };
            listView.ItemsSource = GetBooks;

        }

        private List<Chapters> Revelation()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 22; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Revelation" });

            }

            return GetChapters;
        }

        private List<Chapters> Jude()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 1; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Jude" });

            }

            return GetChapters;
        }

        private List<Chapters> ThirdJohn()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 1; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "3 John" });

            }

            return GetChapters;
        }

        private List<Chapters> SecondJohn()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 1; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "2 John" });

            }

            return GetChapters;
        }

        private List<Chapters> FirstJohn()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 5; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "1 John" });

            }

            return GetChapters;
        }

        private List<Chapters> SecondPeter()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 3; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "2 Peter" });

            }

            return GetChapters;
        }

        private List<Chapters> FirstPeter()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 5; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "1 Peter" });

            }

            return GetChapters;
        }

        private List<Chapters> James()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 5; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "James" });

            }

            return GetChapters;
        }

        private List<Chapters> Hebrews()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 1; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Hebrews" });

            }

            return GetChapters;
        }

        private List<Chapters> Philemon()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 1; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Philemon" });

            }

            return GetChapters;
        }

        private List<Chapters> SecondTimothy()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 4; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "2 Timothy" });

            }

            return GetChapters;
        }

        private List<Chapters> FirstTimothy()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 6; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "1 Timothy" });

            }

            return GetChapters;
        }

        private List<Chapters> SecondThesalonians()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 3; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "2 Thesalonians" });

            }

            return GetChapters;
        }

        private List<Chapters> FirstThesalonians()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 5; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "1 Thesalonians" });

            }

            return GetChapters;
        }

        private List<Chapters> Collosians()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 4; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Collosians" });

            }

            return GetChapters;
        }

        private List<Chapters> Philippians()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 4; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Philippians" });

            }

            return GetChapters;
        }

        private List<Chapters> Ephesians()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 6; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Ephesians" });

            }

            return GetChapters;
        }

        private List<Chapters> Galatians()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 6; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Galatians" });

            }

            return GetChapters;
        }

        private List<Chapters> SecondCorinthians()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 13; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "2 Corinthians" });

            }

            return GetChapters;
        }

        private List<Chapters> FirstCorinthians()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 16; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "1 Corinthians" });

            }

            return GetChapters;
        }

        private List<Chapters> Romans()
        {

            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 16; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Romans" });

            }

            return GetChapters;
        }

        private List<Chapters> Acts()
        {

            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 28; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Acts" });

            }

            return GetChapters;
        }

        private List<Chapters> John()
        {

            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 21; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Luke" });

            }

            return GetChapters;
        }

        private List<Chapters> Luke()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 24; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Luke" });

            }

            return GetChapters;
        }

        private List<Chapters> Mark()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 16; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Mark" });

            }

            return GetChapters;
        }

        private List<Chapters> Matthew()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 28; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Matthew" });

            }

            return GetChapters;
        }

        private List<Chapters> Malachai()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 4; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Malachi" });

            }

            return GetChapters;
        }

        private List<Chapters> Zechariah()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 14; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Zechariah" });

            }

            return GetChapters;
        }

        private List<Chapters> Haggai()
        {

            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 2; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Haggai" });

            }

            return GetChapters;
        }

        private List<Chapters> Zephaniah()
        {

            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 3; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Zephaniah" });

            }

            return GetChapters;
        }

        private List<Chapters> Habakuk()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 3; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Habakuk" });

            }

            return GetChapters;
        }

        private List<Chapters> Nahum()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 3; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Nahum" });

            }

            return GetChapters;
        }

        private List<Chapters> Micah()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 7; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Micah" });

            }

            return GetChapters;
        }

        private List<Chapters> Jonah()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 4; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Jonah" });

            }

            return GetChapters;
        }

        private List<Chapters> Obadiah()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 1; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Obadiah" });

            }

            return GetChapters;
        }

        private List<Chapters> Amos()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 9; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Amos" });

            }

            return GetChapters;
        }

        private List<Chapters> Joel()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 3; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Joel" });

            }

            return GetChapters;
        }

        private List<Chapters> Hosea()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 14; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Hosea" });

            }

            return GetChapters;
        }

        private List<Chapters> Daniel()
        {

            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 12; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Daniel" });

            }

            return GetChapters;
        }

        private List<Chapters> Ezekiel()
        {

            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 48; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Ezekiel" });

            }

            return GetChapters;
        }

        private List<Chapters> Lamentations()
        {

            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 5; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Lamentations" });

            }

            return GetChapters;
        }

        private List<Chapters> Jeremiah()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 52; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Jeremiah" });

            }

            return GetChapters;
        }

        private List<Chapters> Isaiah()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 66; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Isaiah" });

            }

            return GetChapters;
        }

        private List<Chapters> SongOfSolomon()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 8; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Song of Solomon" });

            }

            return GetChapters;
        }

        private List<Chapters> Ecclesiastes()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 12; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Ecclesiastes" });

            }

            return GetChapters;
        }

        private List<Chapters> Proverbs()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 31; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Proverbs" });

            }

            return GetChapters;
        }

        private List<Chapters> Psalm()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 150; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Psalms" });

            }

            return GetChapters;
        }

        private List<Chapters> Job()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 42; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Job" });

            }

            return GetChapters;
        }

        private List<Chapters> Esther()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 10; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Esther" });

            }

            return GetChapters;
        }

        private List<Chapters> Nehemiah()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 13; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Nehemiah" });

            }

            return GetChapters;
        }

        private List<Chapters> Ezra()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 10; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Ezra" });

            }

            return GetChapters;
        }

        private List<Chapters> secondchronicles()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 36; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "2 Chronicles" });

            }

            return GetChapters;
        }

        private List<Chapters> firstchronicles()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 29; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "1 Chronicles" });

            }

            return GetChapters;
        }

        private List<Chapters> twoKings()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 25; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "2 Kings" });

            }

            return GetChapters;
        }

        private List<Chapters> OneKings()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 22; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "1 Kings" });

            }

            return GetChapters;
        }

        private List<Chapters> twosamuel()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 24; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "1 Samuel" });

            }

            return GetChapters;
        }

        private List<Chapters> onesamuel()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 31; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "1 Samuel" });

            }

            return GetChapters;
        }

        private List<Chapters> Ruth()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 4; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Ruth" });

            }

            return GetChapters;
        }

        private List<Chapters> Judges()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 24; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Judges" });

            }

            return GetChapters;
        }

        private List<Chapters> Joshua()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 24; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Joshua" });

            }

            return GetChapters;
        }

        public List<Chapters> Genesis()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 50; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Genesis" });

            }

            return GetChapters;
        }

        public List<Chapters> Exodus()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 40; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Exodus" });

            }

            return GetChapters;
        }

        public List<Chapters> Leviticus()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 27; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Leviticus" });

            }

            return GetChapters;
        }

        public List<Chapters> Numbers()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 36; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Numbers" });

            }

            return GetChapters;
        }


        public List<Chapters> Deuteronomy()
        {
            GetChapters = new List<Chapters>();

            for (int i = 1; i <= 34; i++)
            {
                GetChapters.Add(new Chapters() { ChapterNumber = i, BookName = "Deuteronomy" });

            }

            return GetChapters;
        }
    }
}
