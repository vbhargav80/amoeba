using Android.App;
using Android.OS;

namespace Instamart.Droid
{
    [Activity(Theme = "@style/Theme.Splash", Label = "Instamart", Icon = "@drawable/ic_launcher", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            StartActivity(typeof(MainActivity));
            OverridePendingTransition(0, 0);
            
            Finish();
        }
       
    
        protected override void OnResume()
        {
            base.OnResume();
            HockeyApp.Android.Tracking.StartUsage(this);
        }


        protected override void OnPause()
        {
            base.OnPause();
            HockeyApp.Android.Tracking.StopUsage(this);
        }

    }
}