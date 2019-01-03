﻿using System;
using System.Collections.Generic;
using SQLite;

namespace New_Estate_Baptist_Church.Models
{
    public class Sermon
    {
        public string sermonId { get; set; }

        public string Title { get; set; }
        public string VideoId { get; set; }

        public string Description { get; set; }

        public string ChannelTitle { get; set; }

        public string DefaultThumbnailUrl { get; set; }

        public string MediumThumbnailUrl { get; set; }

        public string HighThumbnailUrl { get; set; }

        public string StandardThumbnailUrl { get; set; }

        public string MaxResThumbnailUrl { get; set; }

        public DateTime PublishedAt { get; set; }

        public int? ViewCount { get; set; }

        public int? LikeCount { get; set; }

        [Ignore]
        public int? DislikeCount { get; set; }

        [Ignore]
        public int? FavoriteCount { get; set; }

        [Ignore]
        public int? CommentCount { get; set; }

        [Ignore]
        public List<string> Tags { get; set; }

       
    }
}