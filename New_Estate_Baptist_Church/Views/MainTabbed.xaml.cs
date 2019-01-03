using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;

namespace New_Estate_Baptist_Church.Views
{
    public partial class MainTabbed : TabbedPage
    {
        public MainTabbed()
        {
            InitializeComponent();
            Children.Add(new Home());
            Children.Add(new TestimonyPage() { 
            
            Title ="Testimonies"
            });
            Children.Add(new EventsPage() { 
            Title = "Events"
            });
            Children.Add(new DaonattionPage() { 
            
            Title = "Giving"
            });
            Children.Add(new BiblePage() { 
            Title="Bible"
            });
        }
    }
}
