using Android.App;
using Android.Content.PM;
using Android.OS;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace WebBrowserSample.Android
{
    [Activity(Label = "WebBrowserSample", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            this.LoadApplication(new App());
        }
    }
}