﻿using AspNetCoreVideo.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Data
{
    public class VideoDbContext : IdentityDbContext<User>
    {
        public VideoDbContext(DbContextOptions<VideoDbContext> options) : base(options)
        {
        }
        public DbSet<Video> Videos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
