using System;
using System.Collections.Generic;
using New_Estate_Baptist_Church.Models;
using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class TestimontyAdd : ContentPage
    {
        public TestimontyAdd()
        {
            InitializeComponent();
        }

        private async void OnSendTestimonyClicked(object sender, EventArgs e)
        {
            var testimony = (Testimony)BindingContext;

            var status = await ChurchPlusServices.TestimonyServices.PostTestimony(testimony);

            if (status == true)
            {
                await DisplayAlert("Successful", "Your Testimony has been Uploaded Successfully. It will be reviewed and approved in due time. Thank you for sharing!", "OK");
            }
            else
            {
                await DisplayAlert("An Error Occured", "There was a problem sending your testimony. Please try again later", "OK");
            }
            await Navigation.PopAsync();
        }

        private async void OnCancelTestimonyClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

