using System;
using System.Collections.Generic;

namespace New_Estate_Baptist_Church.Models
{
    public class Book
    {
        public string BookName
        {
            get;
            set;
        }

        public List<Chapters> BookChapter
        {
            get;
            set;
        }
    }
}
