using System;
using System.Collections.Generic;
using System.Linq;
using New_Estate_Baptist_Church.Models;
using Plugin.Share.Abstractions;
using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class TestimonyDetails : ContentPage
    {
        private string pushtitle;
        private string pushdate;
        private string pushdetails;
        private string pushothers;
        private string pushimagelink;

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TestimontyAdd());
        }


        public int currentId { get; set; }
        Testimony GetTestimony { get; set; }

        public TestimonyDetails()
        {
            InitializeComponent();
        }

        public TestimonyDetails(int currentid)
        {
            InitializeComponent();
            this.currentId = currentid;
        }

        public TestimonyDetails(string pushtitle, string pushdate, string pushdetails, string pushothers, string pushimagelink)
        {
            InitializeComponent();
            // BindingContext =  new TestimoniesViewModel();
            BindingContext = new Testimony()
            {
                title = pushtitle,
                date = DateTime.Parse(pushdate),
                details = pushdetails,
                testifiersName = pushothers,
                testifierImagePath = pushimagelink


            };
            backbutton.IsVisible = false;
            frontbutton.IsVisible = false;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (currentId == 0)
            {
                backbutton.IsEnabled = false;
            }
        }
        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            var app = App.Database.GetAllTestimonies();
            try
            {
                backbutton.IsEnabled = true;


                currentId = currentId + 1;
                if (currentId == app.Count)
                {
                    frontbutton.IsEnabled = false;

                    //  backbutton.IsEnabled = false;
                }
                else
                {
                    //frontbutton.IsEnabled = true;
                    var currentobj = app.FirstOrDefault((arg) => arg.currentid == currentId);
                    BindingContext = currentobj;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }




        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {


            var app = App.Database.GetAllTestimonies();

            frontbutton.IsEnabled = true;

            currentId = currentId - 1;
            if (currentId == 0)
            {

                backbutton.IsEnabled = false;

            }

            // backbutton.IsEnabled = true;


            var currentobj = app.FirstOrDefault((arg) => arg.currentid == currentId);
            BindingContext = currentobj;
        }
        void Handle_Share_Clicked(object sender, System.EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                Plugin.Share.CrossShare.Current.Share(new Plugin.Share.Abstractions.ShareMessage
                {
                    Title = "Lord Chosen testimony",
                    Text = "Download to read daily testimonies",
                    Url = ""

                }, new ShareOptions
                {
                    ExcludedUIActivityTypes = null

                }
                                                    );

            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                Plugin.Share.CrossShare.Current.Share(new Plugin.Share.Abstractions.ShareMessage
                {
                    Title = "Lord Chosen testimony",
                    Text = "Download to read daily testimonies",
                    Url = ""

                }, new ShareOptions
                {
                    ExcludedUIActivityTypes = null

                }
                                                   );
            }
        }

    }
}
