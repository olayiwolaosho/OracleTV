using System;
using System.Collections.ObjectModel;
using System.Linq;
using New_Estate_Baptist_Church.ChurchPlusServices;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;
using Plugin.Connectivity;
using System.Windows.Input;
using Xamarin.Forms;

namespace New_Estate_Baptist_Church.ViewModels
{
    public class AudioViewModel:BaseViewModel
    {
        public Command RefreshCommand
        {
            get;
        }
        ObservableCollection<Media> _Audios;
        public ObservableCollection<Media> Audios
        {
            get { return _Audios; }
            set { SetProperty(ref _Audios, value); }
        }

        public AudioViewModel()
        {
            populate();
            RefreshCommand = new Command(async() =>
            {
                try
                {
                    IsBusy = true;
                    var audios = App.Database.GetAllMedia().Where(c => c.MediaType == "Audio").ToList();
                    Audios = new ObservableCollection<Media>(audios);

                    if (!CrossConnectivity.Current.IsConnected)
                    {
                        IsBusy = false;
                        return;
                    }
                    var UpdatedAudio = await MediaServices.GetAllMedia();

                    App.Database.AddUpdatedMedia(UpdatedAudio);

                    audios = App.Database.GetAllMedia().Where(c => c.MediaType == "Audio").ToList();

                    Audios = new ObservableCollection<Media>(audios);
                }
                catch (Exception ex)
                {

                }
            });

        }

        public async Task populate()
        {
            try
            {
                IsBusy = true;
                var audios = App.Database.GetAllMedia().Where(c => c.MediaType == "Audio").ToList();
                Audios = new ObservableCollection<Media>(audios);

                if (!CrossConnectivity.Current.IsConnected)
                {
                    IsBusy = false;
                    return;
                }
                var UpdatedAudio = await MediaServices.GetAllMedia();

                App.Database.AddUpdatedMedia(UpdatedAudio);

                audios = App.Database.GetAllMedia().Where(c => c.MediaType == "Audio").ToList();

                Audios = new ObservableCollection<Media>(audios);
            }
            catch (Exception ex)
            {

            }
          


        }
    }
}
