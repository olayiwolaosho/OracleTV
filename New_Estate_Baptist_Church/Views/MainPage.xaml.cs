using New_Estate_Baptist_Church.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using New_Estate_Baptist_Church.ViewModels;

namespace New_Estate_Baptist_Church.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {

        protected async override void OnAppearing()
        {
            base.OnAppearing();
         


        }
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();


        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Home, (NavigationPage)Detail);
        }

        public MainPage(string pagefrompush, string pushtitle, string pushdate, string pushdetails, string pushothers, string pushimagelink)
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

          

            switch (pagefrompush)
            {
                case "Announcement":
                    Detail = new NavigationPage(new AnnouncementSingleView( pushtitle, pushdate, pushdetails));
                    break;
                case "Event":
                    Detail = new NavigationPage(new EventsView(0, pushtitle, pushdate, pushdetails, pushothers, pushimagelink));
                    break;
                case "Sermon":
                    Detail = new NavigationPage(new MediaLibrary(1, pushtitle, pushothers, pushimagelink, pushdetails));
                    break;
                case "Testimony":
                    //Detail = new NavigationPage( new TestimonySingleView());
                    Detail = new NavigationPage(new TestimonyDetails(pushtitle, pushdate, pushdetails, pushothers, pushimagelink));

                    break;


            }
        }
        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Home:
                        MenuPages.Add(id, new NavigationPage(new Home()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutUs()));
                        break;
                    case (int)MenuItemType.Social:
                        MenuPages.Add(id, new NavigationPage(new SocialProfile()));
                        break;
                    case (int)MenuItemType.OnlineGiving:
                        MenuPages.Add(id, new NavigationPage(new DaonattionPage()));
                        break;
                    case (int)MenuItemType.Testimonies:
                        MenuPages.Add(id, new NavigationPage(new TestimonyPage()));
                        break;
                    case (int)MenuItemType.EventUpdates:
                        MenuPages.Add(id, new NavigationPage(new EventAnnouncement()));
                        break;
                    case (int)MenuItemType.DigitalLibary:
                        MenuPages.Add(id, new NavigationPage(new MediaLibrary()));
                        break;
                    case (int)MenuItemType.Contact:
                        MenuPages.Add(id, new NavigationPage(new ContactPage()));
                        break;
                   

                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}