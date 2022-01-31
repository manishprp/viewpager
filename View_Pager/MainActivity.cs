using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using AndroidX.ViewPager.Widget;

namespace View_Pager
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ViewPager myView;
        ocean oc;
        Adapter adapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            myView = FindViewById<ViewPager>(Resource.Id.viewPager1);
            oc = new ocean();

            adapter = new Adapter(this, oc);
            myView.Adapter = adapter;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}