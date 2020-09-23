using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace android12
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class navigate : AppCompatActivity
    {
        Button btnNav_sendOrder, btnNav_info, btnNav_return;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.navigate);
            btnNav_sendOrder = (Button)FindViewById(Resource.Id.btnNav_sendOrder);
            btnNav_info = (Button)FindViewById(Resource.Id.btnNav_info);
            btnNav_return = (Button)FindViewById(Resource.Id.btnNav_return);

            btnNav_sendOrder.Click += senOrder;
            btnNav_info.Click += getInfo;
            btnNav_return.Click += returnLogin;
        }

        private void returnLogin(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Login));
            StartActivity(intent);
        }

        private void getInfo(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(info));
            StartActivity(intent);
        }

        private void senOrder(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(submit));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

      
    }
}