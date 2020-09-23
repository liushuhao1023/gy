using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Org.Json;
using Android.Content;

namespace android12
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class submit : AppCompatActivity
    {
        Button btnSub_Submit, btnSub_Return;
        EditText textSub_ProductType, textSub_Pos, textSub_Num;
        Handler handler = new Handler(Looper.MainLooper);

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.submit);
            btnSub_Submit = (Button)FindViewById(Resource.Id.btnSub_Submit);
            btnSub_Return = (Button)FindViewById(Resource.Id.btnSub_Return);
            textSub_ProductType = (EditText)FindViewById(Resource.Id.textSub_ProductType);
            textSub_Pos = (EditText)FindViewById(Resource.Id.textSub_Pos);
            textSub_Num = (EditText)FindViewById(Resource.Id.textSub_Num);
            textSub_Pos.Text = canshu.pos;

            btnSub_Submit.Click += submitOrder;
            btnSub_Return.Click += ReturnNav;

        }

        private void ReturnNav(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(navigate));
            StartActivity(intent);
        }

        private void submitOrder(object sender, System.EventArgs e)
        {
            string type = textSub_ProductType.Text;
            string pos = textSub_Pos.Text;
            string num = textSub_Num.Text;

            JSONObject orderInfo = new JSONObject();
            orderInfo.Put("userId",canshu.userId);
            orderInfo.Put("productType", type);
            orderInfo.Put("storePos", pos);
            orderInfo.Put("num", num);
            orderInfo.Put("finNum", "0");
            orderInfo.Put("status", "待启动");

            string resultStr = HttpUtil.sendPost(canshu.apiStr + "/api/orders", orderInfo.ToString());
            RunOnUiThread(() =>
            {
                JSONObject resJson = new JSONObject(resultStr);
                string backUserId = resJson.GetString("userId");
                if (backUserId.Equals(canshu.userId))
                {
                    Toast.MakeText(this, "下单成功", ToastLength.Long).Show();
                }
                else
                {
                    Toast.MakeText(this, "下单失败", ToastLength.Long).Show();
                }
            });

        }

       

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

       
    }
}