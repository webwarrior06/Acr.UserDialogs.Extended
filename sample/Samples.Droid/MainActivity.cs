using System;
using Acr.UserDialogs.Extended;
using Acr.UserDialogs.Extended.Platforms.Android;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Samples.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


namespace Samples.Droid
{

    [Activity(
        Label = "User Dialogs",
        Icon = "@drawable/icon",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation
    )]
    public class MainActivity : FormsAppCompatActivity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Forms.Init(this, bundle);
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;

            UserDialogs.Init(this);
            this.LoadApplication(new App());
        }
    }
}

