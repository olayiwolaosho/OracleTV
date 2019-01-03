using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;
using System.Windows.Input;
using Xamarin.Forms;
using Plugin.Connectivity;

namespace New_Estate_Baptist_Church.ViewModels
{
    public class TestimonyViewModel:BaseViewModel
    {

        ICommand RefreshCommand { get; set; }
        private ObservableCollection<Testimony> _testimonies;
        public ObservableCollection<Testimony> Testimonies
        {
            get { return _testimonies; }
            set
            {
                _testimonies = value;
                OnPropertyChanged();
            }
        }
        public TestimonyViewModel()
        {
           

            RefreshCommand = new Command( async() => {
                IsBusy = true;
                var testimonies = App.Database.GetAllTestimonies();
                Testimonies = new ObservableCollection<Testimony>(testimonies);
                if (!CrossConnectivity.Current.IsConnected)
                {
                    IsBusy = false;
                    return;
                }
                var UpdatedTestimonies = await App.GetSortedTestimonies(); ;
                App.Database.AddUpdatedTestimonies(UpdatedTestimonies);
                Testimonies = new ObservableCollection<Testimony>(App.Database.GetAllTestimonies());
                IsBusy = false;
            });
            InitDataAsync();
        }

        public async Task InitDataAsync()
        {
            IsBusy = true;
            var testimonies = App.Database.GetAllTestimonies();
            Testimonies = new ObservableCollection<Testimony>(testimonies);
           
            var UpdatedTestimonies = await App.GetSortedTestimonies();
            App.Database.AddUpdatedTestimonies(UpdatedTestimonies);
            Testimonies = new ObservableCollection<Testimony>(App.Database.GetAllTestimonies());
            IsBusy = false;
        }

    }
}
