using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using New_Estate_Baptist_Church.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace New_Estate_Baptist_Church.ChurchPlusServices
{
     class YoutubeApi
    {
        #region Fields, Properties and Variables
        private static string NextPageToken;
        private static string channelID;
        private static string SermonChannelID = "UC9FHOeSf__ZOgJYSdtSub6w";
        private static string ApiKey = "AIzaSyAWzVgVF9WfBL0jUW0bJUDOAXCHB45Y_Ls";
        private string apiUrlForChannel = "https://www.googleapis.com/youtube/v3/search?part=id&order=date&maxResults=30&channelId=" + channelID + "&key=" + ApiKey;
        private string apiUrlForChannelNextPage = "https://www.googleapis.com/youtube/v3/search?part=id&order=date&pageToken=" + NextPageToken + "&maxResults=40&channelId=" + channelID + "&key=" + ApiKey;
        private string apiUrlForVideosDetails = "https://www.googleapis.com/youtube/v3/videos?part=snippet,statistics&id=" + "{0}" + "&key=" + ApiKey;
        List<Sermon> Sermons = new List<Sermon>();
        #endregion

        #region Callable Methods
        public async Task<List<Sermon>> GetSermons()
        {
            channelID = SermonChannelID;
            apiUrlForChannel = "https://www.googleapis.com/youtube/v3/search?part=id&order=date&maxResults=30" + "&channelId=" + channelID + "&key=" + ApiKey;
            var videoIds = await GetVideoIdsFromChannelAsync(SermonChannelID);
            while (!string.IsNullOrEmpty(NextPageToken))
            {
                apiUrlForChannelNextPage = "https://www.googleapis.com/youtube/v3/search?part=id&order=date&pageToken="
             + NextPageToken
             + "&maxResults=30&channelId="
             + channelID
             + "&key=" + ApiKey;
                await GetNextPageVideoIdsFromChannelAsync(SermonChannelID);
            }
            return Sermons;
        }


        #endregion

        #region Execution Methods
        private async Task<List<string>> GetVideoIdsFromChannelAsync(string ChannelID)
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(apiUrlForChannel);

            var videoIds = new List<string>();

            try
            {
                JObject response = JsonConvert.DeserializeObject<dynamic>(json);
                var items = response.Value<JArray>("items");

                foreach (var item in items)
                {
                    videoIds.Add(item.Value<JObject>("id")?.Value<string>("videoId"));
                }

                //Check for the caller's Channel Id so that the execution can be transferred to the appropraite channel's method
                if (ChannelID == SermonChannelID)
                {
                    await GetSermonDetailsAsync(videoIds);
                }



                NextPageToken = response.Value<string>("nextPageToken");

            }
            catch (Exception exception)
            {
            }

            return videoIds;
        }

        private async Task<List<string>> GetNextPageVideoIdsFromChannelAsync(string ChannelID)
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(apiUrlForChannelNextPage);

            var videoIds = new List<string>();

            try
            {
                JObject response = JsonConvert.DeserializeObject<dynamic>(json);

                var items = response.Value<JArray>("items");

                foreach (var item in items)
                {
                    videoIds.Add(item.Value<JObject>("id")?.Value<string>("videoId"));
                }

                //Check for the caller's Channel Id so that the execution can be transferred to the appropraite channel's method
                if (ChannelID == SermonChannelID)
                {
                    await GetSermonDetailsAsync(videoIds);
                }

                NextPageToken = response.Value<string>("nextPageToken");
            }
            catch (Exception exception)
            {
            }

            return videoIds;
        }

        private async Task<List<Sermon>> GetSermonDetailsAsync(List<string> videoIds)
        {
            var videoIdsString = "";
            foreach (var s in videoIds)
            {
                videoIdsString += s + ",";
            }

            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(string.Format(apiUrlForVideosDetails, videoIdsString));

            try
            {
                JObject response = JsonConvert.DeserializeObject<dynamic>(json);

                var items = response.Value<JArray>("items");

                foreach (var item in items)
                {
                    var snippet = item.Value<JObject>("snippet");
                    var statistics = item.Value<JObject>("statistics");

                    var youtubeItem = new Sermon
                    {
                        Title = snippet.Value<string>("title"),
                        Description = snippet.Value<string>("description"),
                        ChannelTitle = snippet.Value<string>("channelTitle"),
                        PublishedAt = snippet.Value<DateTime>("publishedAt"),
                        VideoId = item?.Value<string>("id"),
                        DefaultThumbnailUrl = snippet?.Value<JObject>("thumbnails")?.Value<JObject>("default")?.Value<string>("url"),
                        MediumThumbnailUrl = snippet?.Value<JObject>("thumbnails")?.Value<JObject>("medium")?.Value<string>("url"),
                        HighThumbnailUrl = snippet?.Value<JObject>("thumbnails")?.Value<JObject>("high")?.Value<string>("url"),
                        StandardThumbnailUrl = snippet?.Value<JObject>("thumbnails")?.Value<JObject>("standard")?.Value<string>("url"),
                        MaxResThumbnailUrl = snippet?.Value<JObject>("thumbnails")?.Value<JObject>("maxres")?.Value<string>("url"),

                        ViewCount = statistics?.Value<int>("viewCount"),
                        LikeCount = statistics?.Value<int>("likeCount"),
                        //DislikeCount = statistics?.Value<int>("dislikeCount"),
                        //FavoriteCount = statistics?.Value<int>("favoriteCount"),
                        //CommentCount = statistics?.Value<int>("commentCount"),

                        //Tags = (from tag in snippet?.Value<JArray>("tags") select tag.ToString())?.ToList()
                    };

                    Sermons.Add(youtubeItem);

                }

                return Sermons;
            }
            catch (Exception exception)
            {
                return Sermons;

            }
        }

        #endregion
    }
}
