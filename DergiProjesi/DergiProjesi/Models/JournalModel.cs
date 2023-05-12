using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DergiProjesi.Models
{
    public class JournalModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }
    }
}