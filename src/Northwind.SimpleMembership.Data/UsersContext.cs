﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Northwind.MusicStore.Domain;

namespace Northwind.SimpleMembership.Data
{
    //TODO: Implement Repositories and a Unit Of Work
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("MusicStoreEntities")
        {
           
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
