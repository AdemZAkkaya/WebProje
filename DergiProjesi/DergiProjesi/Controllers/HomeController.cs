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
            return View(context.Journals.ToList());
        }
    }
}