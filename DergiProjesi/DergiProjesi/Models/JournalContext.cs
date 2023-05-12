using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DergiProjesi.Models
{
    public class JournalContext : DbContext
    {
        public DbSet<Journal> journals { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}