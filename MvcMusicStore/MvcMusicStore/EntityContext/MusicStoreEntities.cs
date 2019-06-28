﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MvcMusicStore.Models;

namespace MvcMusicStore.EntityContext
{
    public class MusicStoreEntities : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public MusicStoreEntities()
            : base("DefaultConnection")
        {

        }
    }
}