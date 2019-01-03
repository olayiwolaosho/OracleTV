using New_Estate_Baptist_Church.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace New_Estate_Baptist_Church.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Home, Title="Home", icon="homeIcon.png"},
                new HomeMenuItem {Id = MenuItemType.About, Title="About", icon="aboutIcon.png" },
                new HomeMenuItem{Id= MenuItemType.Social , Title="Social Chanenels", icon="AnnouncementsIcon.png"},
                new HomeMenuItem{Id= MenuItemType.OnlineGiving, Title="Online Giving", icon="offeringIcon.png"},
                new HomeMenuItem{Id = MenuItemType.Testimonies, Title="Testimonies", icon="TestimoniesIcon.png"},
                new HomeMenuItem{Id=MenuItemType.EventUpdates, Title="Event Updates", icon="eventsIcon.png"},
                new HomeMenuItem{Id=MenuItemType.DigitalLibary, Title="Digital Library", icon="digitallibraryIcon.png"},
                new HomeMenuItem{Id= MenuItemType.Contact, Title="Contact", icon="ContactIcons.png"},
               
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.ItemSelected += async (sender, e) =>
            {

                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);

                ListViewMenu.SelectedItem = null;
                
            };
        }
    }
}