using System;
namespace New_Estate_Baptist_Church.Models
{
    public class Event
    {
        public string id { get; set; }
        public string name { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public string eventTime { get; set; }
        public string venue { get; set; }
        public string description { get; set; }
        public string imagePath { get; set; }
    }
}
