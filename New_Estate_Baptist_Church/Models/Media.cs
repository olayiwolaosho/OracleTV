using System;

namespace New_Estate_Baptist_Church.Models
{
    public class Media
    {
        private string _imagePath;

        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MediaType { get; set; }

        public string Category { get; set; }
        public DateTime DateAdded { get; set; }
        public string ImagePath
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_imagePath))
                {
                    if (MediaType == "Audio")
                    {
                        return "audioImage.png";
                    }
                    else if (MediaType == "Video")
                    {
                        return "videoImage.png";

                    }
                    else if (MediaType == "Ebook")
                    {
                        return "ebookImage.png";

                    }
                    else
                    {
                        return "ebookImage.png";
                    }
                }
                return _imagePath;

            }
            set => _imagePath = value;
        }
        public string FilePath { get; set; }
        public int ViewCount { get; set; }
        public int DownloadCount { get; set; }
        public string Price { get; set; }

        public bool IsFree { get; set; }
    }
}