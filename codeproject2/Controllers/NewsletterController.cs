using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using codeproject2.Database;
using codeproject2.Models;

namespace codeproject2.Controllers
{
    public class NewsletterController : Controller
    {
        [HttpGet]
        public ActionResult Index(int id = 0)
        {
            var model = new NewsletterViewModel();

            using (var context = new EntityModel())
            {
                model.Newsletters = context.Newsletters
                    .OrderByDescending(o => o.Date).ToList();
            }


            model.SelectedId = id == 0 ? model.Newsletters[0].Id : id;


                return View(model);
        }

        [HttpPost]
        public ActionResult Index(NewsletterViewModel vm)
        {

            if (ModelState.IsValid)
            {
                using (var context = new EntityModel())
                {
                    context.Comments.Add(new Comment() { Email = vm.Email, Content = vm.Comment, EditionId = vm.SelectedId });
                    context.SaveChanges();
                }

                 return RedirectToAction("Index", new { id = vm.SelectedId });
            }

            using (var context = new EntityModel())
            {
                vm.Newsletters = context.Newsletters
                    .OrderByDescending(o => o.Date).ToList();
            }

            return View(vm);
        }
    }
}