using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Threading;
using Org.Json;
using Android.Content;

namespace D0922T0913
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button button_reg, button_login;
        EditText editText_login_userid, editText_login_pwd;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            button_login = (Button)FindViewById(Resource.Id.button_login);
            button_reg = (Button)FindViewById(Resource.Id.button_reg);
            editText_login_userid = (EditText)FindViewById(Resource.Id.editText_login_userid);
            editText_login_pwd = (EditText)FindViewById(Resource.Id.editText_login_pwd);
            button_login.Click += Button_login_Click;
            button_reg.Click += Button_reg_Click;
        }

        private void Button_reg_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity_Reg));
            StartActivity(intent);
        }

        private void Button_login_Click(object sender, System.EventArgs e)
        {
            new Thread(() =>
            {
                string resultstr = HttpUtli.GetFunction(@"http://172.21.0.101:8090/user/login?userid=" + editText_login_userid.Text.Trim());
                RunOnUiThread(() =>
                {
                    JSONObject resultjson = new JSONObject(resultstr);
                    string pwd = resultjson.GetString("Pwd");
                    if (pwd.Equals(editText_login_pwd.Text))
                    {
                        Intent intent = new Intent(this, typeof(MainActivity_Nav));
                        StartActivity(intent);
                    }
                    else
                    {
                        Toast.MakeText(this, "登录失败",ToastLength.Long).Show();
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