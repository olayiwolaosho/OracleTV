using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;
using Newtonsoft.Json;

namespace New_Estate_Baptist_Church.ChurchPlusServices
{
    public static class EventServices
    {
        private static readonly string CID = App.AppKey;
        private static readonly string GetAllEventsApiUrl = "https://churchplusapi.azurewebsites.net/api/EventsServiceApiController/getAllEvents";


        public static async Task<List<Event>> GetAllEvents()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("CID", CID);
            var response = await httpClient.GetAsync(GetAllEventsApiUrl);
            HttpContent content = response.Content;
            var json = await content.ReadAsStringAsync();
            try
            {
                var events = JsonConvert.DeserializeObject<List<Event>>(json);
                return events;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}
