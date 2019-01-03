
using New_Estate_Baptist_Church.Models;
using Plugin.Connectivity;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace New_Estate_Baptist_Church
{
    class AnnouncementsViewModel : INotifyPropertyChanged
    {
        public Command RefreshCommand
        {
            get;
        }
        private ObservableCollection<Announcement> _announcements;
        public ObservableCollection<Announcement> Announcements
        {
            get
            { return _announcements; }
            set
            {
                _announcements = value;
                OnPropertyChanged();
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public AnnouncementsViewModel()
        {
            RefreshCommand = new Command(async() => {

                try
                {
                    IsBusy = true;
                    Announcements = new ObservableCollection<Announcement>(App.Database.GetAllAnnouncements());
                    if (!CrossConnectivity.Current.IsConnected)
                    {
                        IsBusy = false;
                        return;
                    }

                    var UpdatedAnnouncements = await ChurchPlusServices.AnnouncementServices.GetAllAnnouncements();
                    App.Database.AddUpdatedAnnouncements(UpdatedAnnouncements);
                    Announcements = new ObservableCollection<Announcement>(App.Database.GetAllAnnouncements());

                }
                catch (Exception e)
                {

                }
                IsBusy = false;
            });
            InitAsync();
        }

      

        public async Task InitAsync()
        {
            try
            {
                IsBusy = true;
                Announcements = new ObservableCollection<Announcement>(App.Database.GetAllAnnouncements());
                if (!CrossConnectivity.Current.IsConnected)
                {
                    IsBusy = false;
                    return;
                }

                var UpdatedAnnouncements = await ChurchPlusServices.AnnouncementServices.GetAllAnnouncements();
                App.Database.AddUpdatedAnnouncements(UpdatedAnnouncements);
                Announcements = new ObservableCollection<Announcement>(App.Database.GetAllAnnouncements());

            }
            catch (Exception e)
            {

            }
            IsBusy = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
