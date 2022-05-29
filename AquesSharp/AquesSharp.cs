using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace KYapp.AquesSharp
{
    public static class AquesSharp
    {
        private static HttpClient client = new HttpClient();
        public static void Get()
        {
            Task<HttpResponseMessage> task = client.GetAsync("https://www.yukumo.net/api/v2/aqtk10/koe.mp3?type=f1e&effect=none&boyomi=false&speed=100&volume=100&pitch=100&accent=100&lmd=100&fsc=100&kanji=%E3%83%86%E3%82%B9%E3%83%88%E3%81%A7%E3%81%99%E3%82%88");
            task.Wait();
            Task<byte[]> res = task.Result.Content.ReadAsByteArrayAsync();
            res.Wait();
            foreach (var item in res.Result)
            {
                Console.Write(item);
            }
            Console.WriteLine(task.Result);
        }
    }
}
