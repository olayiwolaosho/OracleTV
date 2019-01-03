using System;
using System.Collections.Generic;
using New_Estate_Baptist_Church.ChurchPlusServices;

namespace New_Estate_Baptist_Church.Models
{
    public class Chapters
    {
        public int ChapterNumber
        {
            get;
            set;
        }
        public string BookName
        {
            get;
            set;
        }
        public List<Verses> Verses
        {
            get;
            set;
        }

        public bool IsBusy
        {
            get;
            set;
        }
    }
}
