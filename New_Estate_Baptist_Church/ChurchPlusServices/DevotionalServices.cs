using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;
using Newtonsoft.Json;

namespace New_Estate_Baptist_Church.ChurchPlusServices
{
    public static class DevotionalServices
    {
        private  static readonly string CID = App.AppKey;

        private static string GetAllDevotionalApiUrl = "https://churchplusapi.azurewebsites.net/api/Devotional/GetCurrentMonthDevotional";

        public static async Task<List<Devotional>> GetAllDevotional()
        {
            try
            {
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("CID", CID);
                var response = await httpClient.GetAsync(GetAllDevotionalApiUrl);
                HttpContent content = response.Content;
                var json = await content.ReadAsStringAsync();
                var devotional = JsonConvert.DeserializeObject<List<Devotional>>(json);
                return devotional;
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
