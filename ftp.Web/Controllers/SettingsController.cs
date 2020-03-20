using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ftp.Web.Controllers
{
    public class SettingsController : Controller
    {
        // GET: Setings
        public ActionResult Index()
        {
            return View();
        }
    }
}