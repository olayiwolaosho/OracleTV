using System;
using System.Collections.ObjectModel;
using New_Estate_Baptist_Church.Models;
using System.Threading.Tasks;
using System.Linq;
using New_Estate_Baptist_Church.ChurchPlusServices;

namespace New_Estate_Baptist_Church.ViewModels
{
    public class EbookViewModel:BaseViewModel
    {

        ObservableCollection<Media> _Ebooks;
        public ObservableCollection<Media> Ebooks
        {
            get { return _Ebooks; }
            set { SetProperty(ref _Ebooks, value); }
        }
        public EbookViewModel()
        {

            populate();
        }

        private async Task populate()
        {
            IsBusy = true;
            var ebooks = App.Database.GetAllMedia().Where(c => c.MediaType == "Ebook").ToList();
            Ebooks = new ObservableCollection<Media>(ebooks);

            var UpdatedAudio = await MediaServices.GetAllMedia();

            App.Database.AddUpdatedMedia(UpdatedAudio);

            ebooks = App.Database.GetAllMedia().Where(c => c.MediaType == "Ebook").ToList();

            Ebooks = new ObservableCollection<Media>(ebooks);
        }
    }
}
