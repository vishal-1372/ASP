﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Image.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Table> Images { get; set; }
    }
   
}