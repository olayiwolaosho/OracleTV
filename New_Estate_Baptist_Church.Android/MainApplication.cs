using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Plugin.FirebasePushNotification;

namespace New_Estate_Baptist_Church.Droid
{
    //You can specify additional application information in this attribute
    [Application]
    public class MainApplication : Application, Application.IActivityLifecycleCallbacks
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transer)
          : base(handle, transer)
        {
            //FirebasePushNotificationManager.IconResource = 2130837527;
            FirebasePushNotificationManager.NotificationContentTitleKey = "Title";
           //FirebasePushNotificationManager.Color = Android.Graphics.Color.OrangeRed;
        }

        public override void OnCreate()
        {
            base.OnCreate();
            RegisterActivityLifecycleCallbacks(this);
            //A great place to initialize Xamarin.Insights and Dependency Services!


            if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
            {
                //Change for your default notification channel id here
                FirebasePushNotificationManager.DefaultNotificationChannelId = "FirebasePushNotificationChannel";

                //Change for your default notification channel name here
                FirebasePushNotificationManager.DefaultNotificationChannelName = "General";
            }


            //If debug you should reset the token each time.
#if DEBUG
            FirebasePushNotificationManager.Initialize(this, true);


            //FirebasePushNotificationManager.NotificationActivityType = typeof(MainActivity);


#else
            FirebasePushNotificationManager.Initialize(this,true);
#endif

            //Handle notification when app is closed here
            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {
               // FirebasePushNotificationManager.IconResource = 2130837527;
            };

            CrossFirebasePushNotification.Current.OnNotificationOpened += (s, p) =>
            {
                FirebasePushNotificationManager.NotificationActivityType = typeof(MainActivity);

                // Xamarin.Forms.Application.Current.MainPage = new TestimoniesView();

                //BaseChurchApp.MainPage = new TestimoniesView();
                //MainPage = new TestimoniesView();
            };


        }

        public override void OnTerminate()
        {
            base.OnTerminate();
            UnregisterActivityLifecycleCallbacks(this);
        }

        public void OnActivityCreated(Activity activity, Bundle savedInstanceState)
        {
            // CrossCurrentActivity.Current.Activity = activity;
        }

        public void OnActivityDestroyed(Activity activity)
        {
        }

        public void OnActivityPaused(Activity activity)
        {

            if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
            {
                //Change for your default notification channel id here
                FirebasePushNotificationManager.DefaultNotificationChannelId = "FirebasePushNotificationChannel";

                //Change for your default notification channel name here
                FirebasePushNotificationManager.DefaultNotificationChannelName = "General";
            }


            //If debug you should reset the token each time.
#if DEBUG
            FirebasePushNotificationManager.Initialize(this, true);


            //FirebasePushNotificationManager.NotificationActivityType = typeof(MainActivity);


#else
            FirebasePushNotificationManager.Initialize(this,true);
#endif

            //Handle notification when app is closed here
            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {
                // FirebasePushNotificationManager.IconResource = 2130837527;
            };

            CrossFirebasePushNotification.Current.OnNotificationOpened += (s, p) =>
            {
                FirebasePushNotificationManager.NotificationActivityType = typeof(MainActivity);

                // Xamarin.Forms.Application.Current.MainPage = new TestimoniesView();

                //BaseChurchApp.MainPage = new TestimoniesView();
                //MainPage = new TestimoniesView();
            };

        }

        public void OnActivityResumed(Activity activity)
        {
            //CrossCurrentActivity.Current.Activity = activity;
        }

        public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
        {


            if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
            {
                //Change for your default notification channel id here
                FirebasePushNotificationManager.DefaultNotificationChannelId = "FirebasePushNotificationChannel";

                //Change for your default notification channel name here
                FirebasePushNotificationManager.DefaultNotificationChannelName = "General";
            }


            //If debug you should reset the token each time.
#if DEBUG
            FirebasePushNotificationManager.Initialize(this, true);


            //FirebasePushNotificationManager.NotificationActivityType = typeof(MainActivity);


#else
            FirebasePushNotificationManager.Initialize(this,true);
#endif

            //Handle notification when app is closed here
            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {
                // FirebasePushNotificationManager.IconResource = 2130837527;
            };

            CrossFirebasePushNotification.Current.OnNotificationOpened += (s, p) =>
            {
                FirebasePushNotificationManager.NotificationActivityType = typeof(MainActivity);

                // Xamarin.Forms.Application.Current.MainPage = new TestimoniesView();

                //BaseChurchApp.MainPage = new TestimoniesView();
                //MainPage = new TestimoniesView();
            };

        }

        public void OnActivityStarted(Activity activity)
        {
            //  CrossCurrentActivity.Current.Activity = activity;

            if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
            {
                //Change for your default notification channel id here
                FirebasePushNotificationManager.DefaultNotificationChannelId = "FirebasePushNotificationChannel";

                //Change for your default notification channel name here
                FirebasePushNotificationManager.DefaultNotificationChannelName = "General";
            }


            //If debug you should reset the token each time.
#if DEBUG
            FirebasePushNotificationManager.Initialize(this, true);


            //FirebasePushNotificationManager.NotificationActivityType = typeof(MainActivity);


#else
            FirebasePushNotificationManager.Initialize(this,true);
#endif

            //Handle notification when app is closed here
            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {
                // FirebasePushNotificationManager.IconResource = 2130837527;
            };

            CrossFirebasePushNotification.Current.OnNotificationOpened += (s, p) =>
            {
                FirebasePushNotificationManager.NotificationActivityType = typeof(MainActivity);

                // Xamarin.Forms.Application.Current.MainPage = new TestimoniesView();

                //BaseChurchApp.MainPage = new TestimoniesView();
                //MainPage = new TestimoniesView();
            };

        }

        public void OnActivityStopped(Activity activity)
        {

            if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
            {
                //Change for your default notification channel id here
                FirebasePushNotificationManager.DefaultNotificationChannelId = "FirebasePushNotificationChannel";

                //Change for your default notification channel name here
                FirebasePushNotificationManager.DefaultNotificationChannelName = "General";
            }


            //If debug you should reset the token each time.
#if DEBUG
            FirebasePushNotificationManager.Initialize(this, true);


            //FirebasePushNotificationManager.NotificationActivityType = typeof(MainActivity);


#else
            FirebasePushNotificationManager.Initialize(this,true);
#endif

            //Handle notification when app is closed here
            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {
                // FirebasePushNotificationManager.IconResource = 2130837527;
            };

            CrossFirebasePushNotification.Current.OnNotificationOpened += (s, p) =>
            {
                FirebasePushNotificationManager.NotificationActivityType = typeof(MainActivity);

                // Xamarin.Forms.Application.Current.MainPage = new TestimoniesView();

                //BaseChurchApp.MainPage = new TestimoniesView();
                //MainPage = new TestimoniesView();
            };

        }


    }
}