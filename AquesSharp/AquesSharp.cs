using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;


namespace KYapp.AquesSharp
{
    public static class AquesSharp
    {
        private static HttpClient client = new HttpClient();
        public static HttpResponseMessage Get()
        {
            Task<HttpResponseMessage> task = client.GetAsync("https://www.yukumo.net/api/v2/aqtk10/koe.mp3?type=f1e&effect=none&boyomi=false&speed=100&volume=100&pitch=100&accent=100&lmd=100&fsc=100&kanji=%E3%83%86%E3%82%B9%E3%83%88%E3%81%A7%E3%81%99%E3%82%88");
            task.Wait();
            return task.Result;
        }
        public static byte[] ByteGet()
        {
            var task = Get().Content.ReadAsByteArrayAsync();
            task.Wait();
            return task.Result;
        }
        public static Stream StreamGet()
        {
            var task = Get().Content.ReadAsStreamAsync();
            task.Wait();
            return task.Result;
        }
    }
}
