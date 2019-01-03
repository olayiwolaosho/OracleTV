using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;
using Newtonsoft.Json;

namespace New_Estate_Baptist_Church.ChurchPlusServices
{
    public static class AnnouncementServices
    {
        private static readonly string CID = App.AppKey;
        private static readonly string GetAllAnnouncementsApiUrl = "https://churchplusapi.azurewebsites.net/api/AnnoucementsServiceApiController/GetAnnoucmentsData";

        public static async Task<List<Announcement>> GetAllAnnouncements()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("CID", CID);
            var response = await httpClient.GetAsync(GetAllAnnouncementsApiUrl);
            HttpContent content = response.Content;
            var json = await content.ReadAsStringAsync();


            try
            {
                var announcements = JsonConvert.DeserializeObject<List<Announcement>>(json);
                return announcements;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
