using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DergiProjesi.Models
{
    public class Journal
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string imageURL { get; set; }

        public int categoryId { get; set; }
        public Category category { get; set; }
    }
}