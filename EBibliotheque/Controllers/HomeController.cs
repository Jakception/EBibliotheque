using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using EBibliotheque.Models;

namespace EBibliotheque.Controllers
{
    public class HomeController : Controller
    {
        private IDal dal;

        public HomeController() : this(new Dal())
        {
        }

        public HomeController(IDal dalIoc)
        {
            dal = dalIoc;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}