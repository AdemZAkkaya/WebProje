using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DergiProjesi.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }

        public List<Journal> journals { get; set; }
    }
}