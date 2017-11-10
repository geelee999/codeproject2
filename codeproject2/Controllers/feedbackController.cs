using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codeproject2.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: feedback
        public ActionResult Index()
        {
            return View();
        }
    }
}