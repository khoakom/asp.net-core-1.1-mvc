﻿using AspNetCoreVideo.Data;
using AspNetCoreVideo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Services
{
    public class SqlVideoData : IVideoData
    {
        public SqlVideoData(VideoDbContext db)
        {
            _db = db;
        }
        private VideoDbContext _db;

        public void Add(Video video)
        {
            _db.Add(video);
        }

        public Video Get(int id)
        {
            return _db.Find<Video>(id);
        }

        public IEnumerable<Video> GetAll()
        {
            return _db.Videos;
        }

        public int Commit()
        {
            return _db.SaveChanges();
        }
    }
}
