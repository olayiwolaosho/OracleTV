using System;
using System.Collections.ObjectModel;
using New_Estate_Baptist_Church.ChurchPlusServices;
using New_Estate_Baptist_Church.Models;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using Plugin.Connectivity;

namespace New_Estate_Baptist_Church.ViewModels
{
    public class PictureViewModel:BaseViewModel
    {
        ICommand RefreshCommand { get; }
        ObservableCollection<Media> _Pictures;
        public ObservableCollection<Media> Pictures
        {
            get { return _Pictures; }
            set { SetProperty(ref _Pictures, value); }
        }
        public PictureViewModel()
        {
            Populate();
            RefreshCommand = new Command(async() =>
            {
                try
                {
                    IsBusy = true;
                    var pictures = App.Database.GetAllMedia().Where(c => c.MediaType == "Picture").ToList();
                    Pictures = new ObservableCollection<Media>(pictures);
                    if (!CrossConnectivity.Current.IsConnected)
                    {

                        IsBusy = false;
                        return;
                    }

                    var UpdatedAudio = await MediaServices.GetAllMedia();

                    App.Database.AddUpdatedMedia(UpdatedAudio);

                    pictures = App.Database.GetAllMedia().Where(c => c.MediaType == "Picture").ToList();

                    Pictures = new ObservableCollection<Media>(pictures);
                }
                catch (Exception ex)
                {

                }

            });
        }

        public async Task Populate()
        {
            try
            {
                IsBusy = true;
                var pictures = App.Database.GetAllMedia().Where(c => c.MediaType == "Picture").ToList();
                Pictures = new ObservableCollection<Media>(pictures);
                if (!CrossConnectivity.Current.IsConnected) {

                    IsBusy = false;
                    return;
                   }

                var UpdatedAudio = await MediaServices.GetAllMedia();

                App.Database.AddUpdatedMedia(UpdatedAudio);

                pictures = App.Database.GetAllMedia().Where(c => c.MediaType == "Picture").ToList();

                Pictures = new ObservableCollection<Media>(pictures);
            }
            catch (Exception ex)
            {

            }

           
        }
    }
}
