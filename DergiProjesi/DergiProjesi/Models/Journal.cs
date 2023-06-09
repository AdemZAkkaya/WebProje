﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DergiProjesi.Models
{
    public class Journal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}