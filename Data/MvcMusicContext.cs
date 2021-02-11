﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMusic.Models;

namespace MvcMusic.Data
{
    public class MvcMusicContext : DbContext
    {
        public MvcMusicContext(DbContextOptions<MvcMusicContext> options)
            : base(options)
        {

        }
        public DbSet<Music> Music { get; set; }
    }
}
