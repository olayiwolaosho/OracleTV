using System;
using SQLite;
using New_Estate_Baptist_Church.Models;
using New_Estate_Baptist_Church.ChurchPlusServices;
using System.Collections.Generic;

namespace New_Estate_Baptist_Church.Database
{
    public class DB
    {
         SQLiteConnection database;
        public DB(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
            database.CreateTable<Event>();
            database.CreateTable<Announcement>();
            database.CreateTable<Testimony>();
            database.CreateTable<Sermon>();
            database.CreateTable<Devotional>();
            database.CreateTable<Media>();
            
        }

        #region Events' Database

        public List<Event> GetAllEvents()
        {
            var events = database.Table<Event>().ToList();
            return events;


        }

        public int AddUpdatedEvents(List<Event> UpdatedEvents)
        {
            database.DropTable<Event>();
            database.CreateTable<Event>();
            var events = database.InsertAll(UpdatedEvents);
            return events;
        }
        #endregion

       

      
     

        #region Announcements' Database

        public List<Announcement> GetAllAnnouncements()
        {
            var announcements = database.Table<Announcement>().ToList();
            return announcements;
        }

        public int AddUpdatedAnnouncements(List<Announcement> UpdatedAnnouncements)
        {
            database.DropTable<Announcement>();
            database.CreateTable<Announcement>();
            var announcements = database.InsertAll(UpdatedAnnouncements);
            return announcements;
        }
        #endregion

        #region Testimonies' Database

        public List<Testimony> GetAllTestimonies()
        {
            var testimonies = database.Table<Testimony>().ToList();
            return testimonies;
        }

       

      

        public int AddUpdatedTestimonies(List<Testimony> UpdatedTestimonies)
        {
            database.DropTable<Testimony>();
            database.CreateTable<Testimony>();
            var testimonies = database.InsertAll(UpdatedTestimonies);
            return testimonies;
        }
        #endregion

        #region Sermons' Database
        public List<Sermon> GetAllSermons()
        {
            var Sermons = database.Table<Sermon>().ToList();
            return Sermons;
        }

        public int AddUpdatedSermons(List<Sermon> UpdatedSermons)
        {
            database.DropTable<Sermon>();
            database.CreateTable<Sermon>();
            var Sermons = database.InsertAll(UpdatedSermons);
            return Sermons;
        }
        #endregion

        #region Devotionals' Database
        public List<Devotional> GetAllDevotionals()
        {
            var Devotional = database.Table<Devotional>().OrderByDescending(c => c.date).ToList();
            return Devotional;
        }

        public int AddUpdatedDevotionals(List<Devotional> UpdatedDevotional)
        {
            database.DropTable<Devotional>();
            database.CreateTable<Devotional>();

            var devotional = database.InsertAll(UpdatedDevotional);
            return devotional;
        }
        #endregion

        #region Media' Database
        public List<Media> GetAllMedia()
        {
            var Media = database.Table<Media>().ToList();
            return Media;
        }

        public int AddUpdatedMedia(List<Media> UpdatedMedia)
        {
            database.DropTable<Media>();
            database.CreateTable<Media>();

            var Media = database.InsertAll(UpdatedMedia);
            return Media;
        }
        #endregion
    }
}
