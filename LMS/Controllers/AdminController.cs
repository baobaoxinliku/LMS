using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS.Controllers
{
    public class AdminController : Controller
    {
        private DAL.AccountContext db = new DAL.AccountContext();
        // GET: Admin

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexAdmin()
        {
            return View();
        }

        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Models.Admin admin)
        {
            db.Admins.Add(admin);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}