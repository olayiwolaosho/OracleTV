using System.Collections.Generic;
using System.Threading.Tasks;
using DLToolkit.Forms.Controls;
using New_Estate_Baptist_Church.Database;
using New_Estate_Baptist_Church.Models;
using New_Estate_Baptist_Church.Views;
using Plugin.FirebasePushNotification;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace New_Estate_Baptist_Church
{
    public partial class App : Application
    {
        public static string AppKey { get { return "42c6c172-5339-43fb-8ca5-21a38f2a4883"; } }


        public static async Task<List<Testimony>> GetSortedTestimonies()
        {

            var originaltestimony = await ChurchPlusServices.TestimonyServices.GetAllTestimonies();
            var index = 0;
            foreach (var item in originaltestimony)
            {
                item.currentid = index++;
            }
            return originaltestimony;

        }
        public App()
        {
            InitializeComponent();
            
            FlowListView.Init();
            MainPage = new MainPage();

            CrossFirebasePushNotification.Current.Subscribe("Announcement" + AppKey);
            CrossFirebasePushNotification.Current.Subscribe("Sermon" + AppKey);
            CrossFirebasePushNotification.Current.Subscribe("Testimony" + AppKey);
            CrossFirebasePushNotification.Current.Subscribe("event" + AppKey);
            CrossFirebasePushNotification.Current.OnTokenRefresh += (s, p) =>
            {
                System.Diagnostics.Debug.WriteLine($"TOKEN : {p.Token}");
            };

            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {


                System.Diagnostics.Debug.WriteLine("Received");

            };

         CrossFirebasePushNotification.Current.OnNotificationOpened += (s, p) =>
            {


                var pagefrompush = p.Data["page"].ToString();
                var pushtitle = p.Data["pushtitle"].ToString();
                var pushdat = p.Data["pushdate"].ToString();
                var pushdet = p.Data["pushdetails"].ToString();
                var pushothers = "";
                var pushimagelink = p.Data["pushimagelink"].ToString();

                if (p.Data["pushothers"] != null)
                {
                    pushothers = p.Data["pushothers"].ToString();
                };

                MainPage = new MainPage(pagefrompush, pushtitle, pushdat, pushdet, pushothers, pushimagelink);
                //MainPage = new TestimoniesView();

            };
            }
        private static DB _database;

        public static DB Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new DB(DependencyService.Get<IFileHelper>().GetLocalFilePath("NEBC.db3"));

                }
                return _database;

            }
        }

        public static bool videostart = false;
        public static string videourl;
        public static WebView videoView;
        protected override void OnStart()
        {
            CrossFirebasePushNotification.Current.Subscribe("Announcement" + AppKey);
            CrossFirebasePushNotification.Current.Subscribe("Sermon" + AppKey);
            CrossFirebasePushNotification.Current.Subscribe("Testimony" + AppKey);
            CrossFirebasePushNotification.Current.Subscribe("event" + AppKey);
            CrossFirebasePushNotification.Current.OnTokenRefresh += (s, p) =>
            {
                System.Diagnostics.Debug.WriteLine($"TOKEN : {p.Token}");
            };

            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {


                System.Diagnostics.Debug.WriteLine("Received");

            };


        }
        protected override void OnSleep()
        {
            CrossFirebasePushNotification.Current.Subscribe("Announcement" + AppKey);
            CrossFirebasePushNotification.Current.Subscribe("Sermon" + AppKey);
            CrossFirebasePushNotification.Current.Subscribe("Testimony" + AppKey);
            CrossFirebasePushNotification.Current.Subscribe("event" + AppKey);
            CrossFirebasePushNotification.Current.OnTokenRefresh += (s, p) =>
            {
                System.Diagnostics.Debug.WriteLine($"TOKEN : {p.Token}");
            };

            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {


                System.Diagnostics.Debug.WriteLine("Received");

            };


        }
        protected override void OnResume()
        {
            CrossFirebasePushNotification.Current.Subscribe("Announcement" + AppKey);
            CrossFirebasePushNotification.Current.Subscribe("Sermon" + AppKey);
            CrossFirebasePushNotification.Current.Subscribe("Testimony" + AppKey);
            CrossFirebasePushNotification.Current.Subscribe("event" + AppKey);
            CrossFirebasePushNotification.Current.OnTokenRefresh += (s, p) =>
            {
                System.Diagnostics.Debug.WriteLine($"TOKEN : {p.Token}");
            };

            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {


                System.Diagnostics.Debug.WriteLine("Received");

            };

        }
    }
}
