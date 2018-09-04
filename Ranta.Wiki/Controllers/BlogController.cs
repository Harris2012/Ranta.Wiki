using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ranta.Wiki.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index(string ename)
        {
            return View();
        }
    }
}