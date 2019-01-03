using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;
using Newtonsoft.Json;

namespace New_Estate_Baptist_Church.ChurchPlusServices
{
    public static class MediaServices
    {
        private static readonly string CID = App.AppKey;

        private static readonly string GetAllMediaApiUrl = "https://churchplusapi.azurewebsites.net/api/MediaServiceApiController/GetMediaFiles";
        public static async Task<List<Media>> GetAllMedia()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("CID", CID);
            var response = await httpClient.GetAsync(GetAllMediaApiUrl);
            HttpContent content = response.Content;
            var json = await content.ReadAsStringAsync();
            var media = JsonConvert.DeserializeObject<List<Media>>(json);
            return media;
        }

    }
}
