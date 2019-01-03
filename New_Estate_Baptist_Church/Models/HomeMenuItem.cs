using System;
using System.Collections.Generic;
using System.Text;

namespace New_Estate_Baptist_Church.Models
{
    public enum MenuItemType
    {
        Home,
        About,Social,OnlineGiving,Testimonies,EventUpdates,DigitalLibary,Contact,devotionals
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string icon { get; set; }
    }
}
