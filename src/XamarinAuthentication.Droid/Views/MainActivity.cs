using Acr.UserDialogs;
using Android.App;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;
using Plugin.CurrentActivity;
using Plugin.Fingerprint;
using XamarinAuthentication.Core.ViewModels.Main;

namespace XamarinAuthentication.Droid.Views
{
    [Activity(Theme = "@style/AppTheme")]
    public class MainActivity : MvxFormsAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            CrossCurrentActivity.Current.Init(this, bundle);
            CrossFingerprint.SetCurrentActivityResolver(() => CrossCurrentActivity.Current.Activity);
            UserDialogs.Init(this);
        }
    }
}
