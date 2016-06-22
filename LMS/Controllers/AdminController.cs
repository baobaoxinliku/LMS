using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.Admin admin)
        {
            var user = db.Admins.Where(b => b.AdminAccount == admin.AdminAccount & b.AdminPwd == admin.AdminPwd);
            if (user.Count() > 0)
            {
                ViewBag.LoginState = "登录成功";
                FormsAuthentication.SetAuthCookie(admin.AdminAccount, false);
                //Session["UserID"] = user.First().UserName;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.LoginState = "登录失败";
                //ModelState.AddModelError("CredentitalError", "Invalid Username or Password");
                return View();
            }
        }

    }
}