using System;
namespace New_Estate_Baptist_Church.Models
{
    public class Devotional
    {
        public Guid id { get; set; }
        public DateTime date { get; set; }
        public string title { get; set; }
        public string message { get; set; }
        public string text { get; set; }
        public string memoryVerse { get; set; }
        public string bibleInaYear { get; set; }
        public string furtherReading { get; set; }
        public string prayers { get; set; }
        public string assignment { get; set; }
        public string audioUrl { get; set; }
        public string videoUrl { get; set; }
    }
}
