using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace D0922T0913
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity_Nav : AppCompatActivity
    {
        Button button_nav_order, button_nav_search, button_nav_back;

        protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        Xamarin.Essentials.Platform.Init(this, savedInstanceState);
        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.nav);

            button_nav_order = (Button)FindViewById(Resource.Id.button_nav_order);
            button_nav_search = (Button)FindViewById(Resource.Id.button_nav_search);
            button_nav_back = (Button)FindViewById(Resource.Id.button_nav_back);

            button_nav_order.Click += Button_nav_order_Click;
            button_nav_search.Click += Button_nav_search_Click;
            button_nav_back.Click += Button_nav_back_Click;
    }

        private void Button_nav_back_Click(object sender, System.EventArgs e)
        {
            Finish();
        }

        private void Button_nav_search_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity_search));
            StartActivity(intent);
        }

        private void Button_nav_order_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity_Order));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
    {
        Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
    }
}
}