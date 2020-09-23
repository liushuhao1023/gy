using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Net;
using System.IO;
using Org.Json;
using System.Text;

namespace android12
{
    public class HttpUtil
    {
        

        public static string sendGet(string url)
        {
            string urlstr = url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlstr);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            System.IO.Stream stream1 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream1, System.Text.Encoding.Default);
            string result = sr.ReadToEnd();
            return result;

        }

        public static string sendPost(string url, string data)
        {
            string urlstr = url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlstr);
            request.Method = "POST";
            request.ContentType = "application/json";
            string dataContent = data;
            using (StreamWriter dataStream = new StreamWriter(request.GetRequestStream()))
            {
                dataStream.WriteLine(dataContent);
                dataStream.Close();
            };
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            System.IO.Stream stream1 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream1, System.Text.Encoding.Default);
            string result = sr.ReadToEnd();
            return result;

        }


    }
}