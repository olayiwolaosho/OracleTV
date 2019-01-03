using System;
using System.Collections.ObjectModel;
using System.Linq;
using New_Estate_Baptist_Church.ChurchPlusServices;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;

namespace New_Estate_Baptist_Church.ViewModels
{
    public class SermonViewModel:BaseViewModel
    {

        ObservableCollection<Sermon> _Videos;
        public ObservableCollection<Sermon> Videos { get { return _Videos; }
            set { SetProperty(ref _Videos, value); }
        }
        public SermonViewModel()
        {
            populate();
        }

        public async Task populate()
        {
            YoutubeApi youtube = new YoutubeApi();
            IsBusy = true;
            var videos = App.Database.GetAllSermons();
            Videos = new ObservableCollection<Sermon>(videos);

            var UpdatedAudio = await youtube.GetSermons();

            App.Database.AddUpdatedSermons(UpdatedAudio);
            videos = App.Database.GetAllSermons();

            Videos = new ObservableCollection<Sermon>(videos);
        }
    }
}
