using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;
using Plugin.Connectivity;

namespace New_Estate_Baptist_Church.ViewModels
{
  public  class DevotionalViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Devotional> _devotional;
        public ObservableCollection<Devotional> Devotional
        {
            get { return _devotional; }
            set
            {
                _devotional = value;
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

        public DevotionalViewModel()
        {
            IsBusy = true;
            InitDataAsync();
        }

        public async Task InitDataAsync()
        {
            IsBusy = true;

            Devotional = new ObservableCollection<Devotional>(App.Database.GetAllDevotionals().OrderBy(c => c.date));


            if (!CrossConnectivity.Current.IsConnected)
            {
                IsBusy = false;
                return;
            }

            var UpdatedDevotional = await ChurchPlusServices.DevotionalServices.GetAllDevotional();
            App.Database.AddUpdatedDevotionals(UpdatedDevotional);

            Devotional = new ObservableCollection<Devotional>(App.Database.GetAllDevotionals().OrderBy(c => c.date));

            IsBusy = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
