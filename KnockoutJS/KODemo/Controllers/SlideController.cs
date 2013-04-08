using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KODemo.Controllers
{
    public class SlideController : Controller
    {
        //
        // GET: /Slide/

        public ActionResult Index(string id)
        {
            return View(id);
        }

    }
}
