using System;
using System.Drawing;
using Acr.UserDialogs.Extended;
using Acr.UserDialogs.Extended.Platforms.Android;
using Android.App;
using Android.OS;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CoordinatorLayout.Widget;
using Google.Android.Material.FloatingActionButton;

namespace Xamarin.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            UserDialogs.Init(this);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            // UserDialogs.Instance.Toast("dsds");

            var view = FindViewById<CoordinatorLayout>(Resource.Id.main);
            var view2 = (ViewGroup) Window.DecorView.RootView.FindViewById(global::Android.Resource.Id.Content);

            var aa = view2.GetChildAt(0);

            UserDialogs.Instance.Toast(new ToastConfig("message")
            {
                Duration = TimeSpan.FromMilliseconds(4000),
                Position = ToastPosition.Top,
                ShowProgress = true,
                Action = new ToastAction() {Text = "dsds"},
                ProgressColor = Color.Aquamarine
            });
        }
    }
}
