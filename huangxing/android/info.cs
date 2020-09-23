using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Org.Json;
using System.IO.IsolatedStorage;

namespace android12
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class info : AppCompatActivity
    {
        TextView textInfo_Show;
        Handler handler = new Handler(Looper.MainLooper);

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.info);
            textInfo_Show = (TextView)FindViewById(Resource.Id.textInfo_Show);
            getInfo();
           
        }
         
        private void getInfo()
        {
            new System.Threading.Thread(() =>
            {
                string resultStr = HttpUtil.sendGet(canshu.apiStr + "/userOrders/"+canshu.userId);
                JSONArray resArr = new JSONArray(resultStr);
                System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
                for (int i = 0; i < resArr.Length(); i++)
                {
                    JSONObject oo = resArr.GetJSONObject(i);
                    stringBuilder.Append(string.Format("{0}{1}{2}{3}{4}{5}{6}\n",
                        oo.GetString("productType").PadRight(12,'\t'),
                         oo.GetString("storePos").PadRight(8,'\t'),
                          oo.GetString("num").PadRight(8,'\t'),
                           oo.GetString("finNum").PadRight(9,'\t'),
                            oo.GetString("beginTime").PadRight(11,'\t'),
                             oo.GetString("finTime").PadRight(10,'\t'),
                              oo.GetString("status")
                        ));
                }

                RunOnUiThread(() =>
                {
                    textInfo_Show.Text = stringBuilder.ToString();
                });
            }).Start();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }
}