using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Org.Json;
using System;

namespace android12
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class Login : AppCompatActivity
    {
        Button btnLogin_login, btnLogin_register;
        EditText textLogin_name, textLogin_pwd;
        Handler handler = new Handler(Looper.MainLooper);

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.login);
            btnLogin_login = (Button)FindViewById(Resource.Id.btnLogin_login);
            btnLogin_register = (Button)FindViewById(Resource.Id.btnLogin_register);
            textLogin_name = (EditText)FindViewById(Resource.Id.textLogin_name);
            textLogin_pwd = (EditText)FindViewById(Resource.Id.textLogin_pwd);

            btnLogin_login.Click += login;
            btnLogin_register.Click += register;
        }

        private void register(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Register));
            StartActivity(intent);
        }

        private void login(object sender, System.EventArgs e)
        {
            try
            {
                string name = textLogin_name.Text;
                string resulStr = HttpUtil.sendGet(canshu.apiStr+"/getInfo/"+ name);
                RunOnUiThread(() =>
                {
                    JSONObject userInfo = new JSONObject(resulStr);
                    string pwd = userInfo.GetString("pwd");
                    string id = userInfo.GetString("id");
                    string type = userInfo.GetString("type");
                    string pos = userInfo.GetString("pos");
                    if (pwd.Equals(textLogin_pwd.Text) && type.Equals("客户"))
                    {
                        Toast.MakeText(this, "登录成功", ToastLength.Long).Show();
                        canshu.userId = id;
                        canshu.pos = pos;
                        Intent intent = new Intent(this, typeof(navigate));
                        StartActivity(intent);

                    }
                    else
                    {
                        Toast.MakeText(this, "登录失败", ToastLength.Long).Show();
                    }
                });
            }
            catch (System.Exception)
            {

                Toast.MakeText(this, "登录失败", ToastLength.Long).Show();
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

      
    }
}