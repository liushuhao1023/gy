using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Threading;

namespace D0922T0913
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity_Order : AppCompatActivity
    {
        Button button_suborder;
        EditText editText_lx, editText_qty;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.order);
            button_suborder =(Button) FindViewById(Resource.Id.button_suborder);
            editText_lx = (EditText) FindViewById(Resource.Id.editText_lx);
            editText_qty = (EditText) FindViewById(Resource.Id.editText_qty);
            button_suborder.Click += Button_suborder_Click;
        }

        private void Button_suborder_Click(object sender, System.EventArgs e)
        {
            new Thread(() =>
            {
                string str = HttpUtli.GetFunction("http://172.21.0.101:8090/order/sub?lx=" + editText_lx.Text + "&qty=" + editText_qty.Text);
                RunOnUiThread(() =>
                {
                    if (str.Equals("\"1\""))
                    {
                        Toast.MakeText(this, "下单成功", ToastLength.Long).Show();
                    }
                    else
                    {
                        Toast.MakeText(this, "下单失败", ToastLength.Long).Show();
                    }
                });
            }).Start();
;
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}