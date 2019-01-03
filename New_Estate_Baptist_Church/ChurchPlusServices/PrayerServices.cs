using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace New_Estate_Baptist_Church.ChurchPlusServices
{
    public static class PrayerServices
    {
        private static readonly string CID = App.AppKey;

        private static string PostPrayerUrl = "https://churchplusapi.azurewebsites.net/api/Prayer/SavePrayerRequest";

        public static async Task<bool> PostPrayer(Prayer prayer)
        {
            var request = new HttpRequestMessage();
            request.Headers.Add("CID", CID);
            request.RequestUri = new Uri(PostPrayerUrl);
            request.Method = HttpMethod.Post;
            try
            {
                string json = JsonConvert.SerializeObject(prayer);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                request.Content = content;

                var httpClient = new HttpClient();
                var response = await httpClient.SendAsync(request);
                var status = response.IsSuccessStatusCode;
                return status;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
