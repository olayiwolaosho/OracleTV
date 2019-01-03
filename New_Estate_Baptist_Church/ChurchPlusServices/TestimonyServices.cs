using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;
using Newtonsoft.Json;

namespace New_Estate_Baptist_Church.ChurchPlusServices
{
    public static class TestimonyServices
    {
        private static readonly string CID = App.AppKey;
        private static readonly string GetAllTestimoniesApiUrl = "https://churchplusapi.azurewebsites.net/api/Testimonies/GetTestimoniesData";
        private static string PostTestimonyUrl = "https://churchplusapi.azurewebsites.net/api/Testimonies/PostTestimony";


        public static async Task<List<Testimony>> GetAllTestimonies()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("CID", CID);
            var response = await httpClient.GetAsync(GetAllTestimoniesApiUrl);
            HttpContent content = response.Content;
            var json = await content.ReadAsStringAsync();
            try
            {
                var Testimonies = JsonConvert.DeserializeObject<List<Testimony>>(json);
                return Testimonies;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static async Task<bool> PostTestimony(Testimony testimony)
        {
            var request = new HttpRequestMessage();
            request.Headers.Add("CID", CID);
            request.RequestUri = new Uri(PostTestimonyUrl);
            request.Method = HttpMethod.Post;
            string json = JsonConvert.SerializeObject(testimony);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            request.Content = content;

            try
            {

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
