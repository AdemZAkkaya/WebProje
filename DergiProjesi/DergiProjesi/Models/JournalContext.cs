using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DergiProjesi.Models
{
    public class JournalContext : DbContext
    {
        public JournalContext() : base("journalDb")
        {
            Database.SetInitializer(new JournalInitializer());
        }

        public DbSet<Journal> Journals { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}