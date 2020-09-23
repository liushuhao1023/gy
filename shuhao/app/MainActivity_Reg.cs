using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using System.Threading;

namespace D0922T0913
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity_Reg : AppCompatActivity
    {
        Button button_reg2, button_back;
        EditText editText_reg_userid, editText_reg_pwd, editText_reg_address;

        protected override void OnCreate(Bundle savedInstanceState)
        {
        base.OnCreate(savedInstanceState);
        Xamarin.Essentials.Platform.Init(this, savedInstanceState);
        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.reg);

            button_reg2 =(Button)FindViewById(Resource.Id.button_reg2);
            button_back = (Button)FindViewById(Resource.Id.button_back);
            editText_reg_userid = (EditText)FindViewById(Resource.Id.editText_reg_userid);
            editText_reg_pwd = (EditText)FindViewById(Resource.Id.editText_reg_pwd);
            editText_reg_address = (EditText)FindViewById(Resource.Id.editText_reg_address);
            button_back.Click += Button_back_Click;
            button_reg2.Click += Button_reg2_Click;
        }

        private void Button_reg2_Click(object sender, System.EventArgs e)
        {
            new Thread(() =>
            {
                string str = HttpUtli.GetFunction("http://172.21.0.101:8090/user/reg?userid=" + editText_reg_userid.Text+"&pwd="+editText_reg_pwd.Text+"&address="+editText_reg_address.Text);
                RunOnUiThread(() =>
                {
                    if (str.Equals("\"{\\\"code\\\":0}\""))
                    {
                        Toast.MakeText(this, "注册成功", ToastLength.Long).Show();
                        Finish();
                    }
                    else
                    {
                        Toast.MakeText(this, "注册失败", ToastLength.Long).Show();
                    }

                });

            }).Start();
;
        }

        private void Button_back_Click(object sender, System.EventArgs e)
        {
            Finish();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
    {
        Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
    }
}
}