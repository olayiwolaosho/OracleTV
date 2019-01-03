using System;
using System.Collections.Generic;

using Xamarin.Forms;
using New_Estate_Baptist_Church.ViewModels;
using New_Estate_Baptist_Church.Models;

namespace New_Estate_Baptist_Church.Views
{
    public partial class MediaLibrary :TabbedPage
    {
        private int v;
        private string pushtitle;
        private string pushothers;
        private string pushimagelink;
        private string pushdetails;

        public MediaLibrary()
        {
            
            InitializeComponent();

            Title = "Media Library";
            Children.Add(new VideoLibrary()
            {
                Title = "Videos", Icon= "playbutton.png"

            });

            Children.Add(new AudioLibrary() {
            Title="Audios", Icon= "musicplayer.png"
            });

            Children.Add(new PictureLibrary()
            {
                Title ="Pictures", Icon = "pictureicon.png"

            });

        }

        public MediaLibrary(int page, string pushtitle, string pushothers, string pushimagelink, string Pushdetails)
        {
            InitializeComponent();
            Media de = new Media()
            {
                FilePath = pushothers,
                Title = pushtitle,
                ImagePath = pushimagelink,
                Description = Pushdetails
            };
            if (page == 1)
            {
                Navigation.PushAsync(new WebAudio(de)
                {
                    BindingContext = de
                });




            }
        }
    }
}
