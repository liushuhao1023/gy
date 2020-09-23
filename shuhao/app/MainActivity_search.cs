using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Threading;
using Org.Json;
using System.Text;

namespace D0922T0913
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity_search : AppCompatActivity
    {
        TextView textView_order;

        protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        Xamarin.Essentials.Platform.Init(this, savedInstanceState);
        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.search);

           
            textView_order = (TextView)FindViewById(Resource.Id.textView_order);
            search();
    }

        void search()
        {
            new Thread(() => {

                string str = HttpUtli.GetFunction("http://172.21.0.101:8090/order/search");
                JSONArray array = new JSONArray(str);
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < array.Length(); i++)
                {
                    JSONObject jSONObject = array.GetJSONObject(i);
                    stringBuilder.Append(string.Format("{0}{1}{2}{3}{4}{5}\n",
                        jSONObject.GetString("orderid").PadRight(10, '\t'),
                        jSONObject.GetString("lx").PadRight(5, '\t'),
                        jSONObject.GetString("qty").PadRight(5, '\t'),
                        jSONObject.GetString("fqty").PadRight(5, '\t'),
                        jSONObject.GetString("otime").PadRight(20, '\t'),
                        jSONObject.GetString("status").PadRight(10, '\t')
                        ));
                }
                RunOnUiThread(() =>
                {
                    textView_order.Text = stringBuilder.ToString();
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