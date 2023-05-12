using DergiProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DergiProjesi.Controllers
{
    public class HomeController : Controller
    {

        private JournalContext context = new JournalContext();

        public ActionResult Index()
        {
            var journals = context.Journals
                .Select(i => new JournalModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Anasayfa = i.Anasayfa,
                    Onay = i.Onay,
                    ImageURL = i.ImageURL
                })
                .Where(i => i.Onay == true && i.Anasayfa == true);

            return View(journals.ToList());
        }
    }
}