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
    public class Register : AppCompatActivity
    {
        Button btnReg_Reg, btnReg_Return;
        EditText textReg_name, textReg_pwd, textReg_pos;
        Handler handler = new Handler(Looper.MainLooper);

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.register);
            Intent.GetStringExtra("aaa");
            btnReg_Reg = (Button)FindViewById(Resource.Id.btnReg_Reg);
            btnReg_Return = (Button)FindViewById(Resource.Id.btnReg_Return);
            textReg_name = (EditText)FindViewById(Resource.Id.textReg_name);
            textReg_pwd = (EditText)FindViewById(Resource.Id.textReg_pwd);
            textReg_pos = (EditText)FindViewById(Resource.Id.textReg_pos);
            btnReg_Reg.Click += Reg;
            btnReg_Return.Click += Return_Login;
        }

        private void Return_Login(object sender, System.EventArgs e)
        {
            Finish();
        }

        private void Reg(object sender, System.EventArgs e)
        {
            try
            {
                string name = textReg_name.Text;
                string pwd = textReg_pwd.Text;
                string pos = textReg_pos.Text;
                JSONObject regInfo = new JSONObject();
                regInfo.Put("name", name);
                regInfo.Put("pwd", pwd);
                regInfo.Put("pos", pos);
                regInfo.Put("type", "客户");

                string resultStr = HttpUtil.sendPost(canshu.apiStr + "/api/accounts", regInfo.ToString());
                RunOnUiThread(() =>
                {
                    JSONObject resJson = new JSONObject(resultStr);
                    string accountName = resJson.GetString("name");
                    if (accountName.Equals(name))
                    {
                        Toast.MakeText(this, accountName + "注册成功", ToastLength.Long).Show();
                        Intent intent = new Intent(this, typeof(Login));
                        StartActivity(intent);
                    }
                    else
                    {
                        Toast.MakeText(this, "注册失败", ToastLength.Long).Show();
                    }
                });
            }
            catch (System.Exception)
            {

                Toast.MakeText(this, "注册失败", ToastLength.Long).Show();
            }
            
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        
    }
}