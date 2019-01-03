using System;
using System.Collections.Generic;
using New_Estate_Baptist_Church.Models;
using Xamarin.Forms;
using New_Estate_Baptist_Church.ViewModels;
using System.Collections.ObjectModel;
using System.Linq;

namespace New_Estate_Baptist_Church.Views
{
    public partial class TestimonyPage : ContentPage
    {
        public TestimonyPage()
        {
            InitializeComponent();
            BindingContext = new TestimonyViewModel();
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItem == null)
                return;
            var testimony = e.SelectedItem as Testimony;

            Navigation.PushAsync(new TestimonyDetails(testimony.currentid)
            {
                BindingContext = testimony
            });
            Listview.SelectedItem = null;
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (e.NewTextValue == null) return;
            var list = BindingContext as TestimonyViewModel;
            list.Testimonies = new ObservableCollection<Testimony>(App.Database.GetAllTestimonies().Where((arg) => arg.title.ToLower().Contains(e.NewTextValue.ToLower()) || arg.details.Contains(e.NewTextValue.ToLower())));

        }
    }
}
