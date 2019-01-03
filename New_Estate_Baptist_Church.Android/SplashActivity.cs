
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Plugin.FirebasePushNotification;

namespace New_Estate_Baptist_Church.Droid
{
    [Activity(Theme = "@style/Theme.Splash",Label = "NEBC", MainLauncher = true , NoHistory = true )]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            FirebasePushNotificationManager.ProcessIntent(this, Intent);
            StartActivity(typeof(MainActivity));
            // Create your application here
        }

        protected override void OnNewIntent(Intent intent)
        {
            FirebasePushNotificationManager.ProcessIntent(this, Intent);
        }









    }
}
