
using Android.App;
using Android.Content;
using Android.OS;
using Android.Content.PM;

namespace MobileBDG.Droid
{
    [Activity(Label = "BDG", Theme = "@style/Theme.Splash", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }
    }
}