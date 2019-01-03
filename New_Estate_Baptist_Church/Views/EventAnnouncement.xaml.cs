using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace New_Estate_Baptist_Church.Views
{
    public partial class EventAnnouncement : TabbedPage
    {
        public EventAnnouncement()
        {
            InitializeComponent();
            Children.Add(new EventsPage() { 
            Title = "Events", Icon = "calendaricon.png"
            });
            Children.Add(new AnnouncementsPage() { 
            Title = "Announcements", Icon = "megaphone.png"
            });
        }
    }
}
