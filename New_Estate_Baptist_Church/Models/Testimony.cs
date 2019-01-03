using System;
namespace New_Estate_Baptist_Church.Models
{
    public class Testimony
    {
        public string id { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public string details { get; set; }
        public bool IsVideoAvailable { get; set; }
        public string VideoLink { get; set; }
        public string testifiersName
        {
            get;
            set;
        }
        private string _testifierImagePath;
        public int currentid { get; set; }

        public string testifierImagePath
        {
            get
            {


                if (string.IsNullOrWhiteSpace(_testifierImagePath) || _testifierImagePath == "")
                {
                    _testifierImagePath = "tenets.png";


                }

                return _testifierImagePath;
            }

            set
            {

                _testifierImagePath = value;
            }
        }



        // public string testifierImagePath { get; set; }
        public string phone { get; set; }
    }
    }

