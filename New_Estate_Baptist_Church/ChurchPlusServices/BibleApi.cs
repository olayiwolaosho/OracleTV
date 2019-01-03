using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;
using Newtonsoft.Json;

namespace New_Estate_Baptist_Church.ChurchPlusServices
{
    public class BibleApi
    {

        private HttpClient client = new HttpClient();
        //http://labs.bible.org/api/?passage=peter+3:&type=json

        public async Task<List<Verses>> GetChapterwithverses(string book, int chapter)
        {
            string url = "https://labs.bible.org/api/?passage=" + book + " " + chapter + "&type=json&v=asv";

            try
            {
                var content = await client.GetStringAsync(url);

                var verses = JsonConvert.DeserializeObject<List<Verses>>(content);

                foreach (var item in verses)
                {
                    if (item.bookname == "Revelation" && item.chapter == "12" && item.verse == "11")
                    {
                        item.text = "But they overcame him by the blood of the lamb and by the word of their testimony , and they did not love their lives so much that they were afraid to die";
                    }
                }

                return verses;
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                return null;
            }

        }
    }
}
