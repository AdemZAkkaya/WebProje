﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DergiProjesi.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int JournalCount { get; set; }
    }
}