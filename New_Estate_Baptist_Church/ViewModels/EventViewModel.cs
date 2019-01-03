using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;
using System.Windows.Input;
using Xamarin.Forms;
using Plugin.Connectivity;
namespace New_Estate_Baptist_Church.ViewModels
{

    public class EventViewModel:BaseViewModel
    {

        public ICommand RefreshCommand { get; set; }
        private ObservableCollection<Event> _events;
        public ObservableCollection<Event> Events
        {
            get { return _events; }
            set
            {
                _events = value;
                OnPropertyChanged();
            }
        }
        public EventViewModel()
        {

            RefreshCommand = new Command(async() =>
            {
                try
                {
                    IsBusy = true;
                    Events = new ObservableCollection<Event>(App.Database.GetAllEvents());

                    if (!CrossConnectivity.Current.IsConnected)
                    {
                        IsBusy = false;
                        return;


                    }
                    var UpdatedEvents = await ChurchPlusServices.EventServices.GetAllEvents();

                    App.Database.AddUpdatedEvents(UpdatedEvents);

                    Events = new ObservableCollection<Event>(App.Database.GetAllEvents());

                    IsBusy = false;
                }
                catch (Exception ex)
                {

                }

            });
            InitDataAsync();
        }

        public async Task InitDataAsync()
        {
            try
            {
                IsBusy = true;
                Events = new ObservableCollection<Event>(App.Database.GetAllEvents());

                if (!CrossConnectivity.Current.IsConnected)
                {
                    IsBusy = false;
                    return;


                }
                var UpdatedEvents = await ChurchPlusServices.EventServices.GetAllEvents();

                App.Database.AddUpdatedEvents(UpdatedEvents);

                Events = new ObservableCollection<Event>(App.Database.GetAllEvents());

                IsBusy = false;
            }
            catch (Exception ex)
            {

            }
           




        }
    }
}
