using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public ActionResult AdminAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminAdd(Models.Admin admin)
        {
            db.Admins.Add(admin);
            db.SaveChanges();
            return RedirectToAction("AdminList");
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

        public ActionResult Car()
        {
            return View();
        }
        public ActionResult Line()
        {
            return View();
        }

        //用户列表
        //[Authorize]
        public ActionResult AdminList(string Search)
        {
            List<Models.Admin> Admins;
            if (!string.IsNullOrEmpty(Search))
            {
                Admins = db.Admins.Where(u => u.AdminName.Contains(Search)).ToList();
            }
            else
            {
                Admins = db.Admins.ToList();
            }
            ViewModels.AccountListViewModel aLVM = new ViewModels.AccountListViewModel();
            aLVM.Admin = Admins;
            return View(aLVM);
        }

        //用户详情
        public ActionResult AdminDetail(int ? id)
        {
            Models.Admin acc = db.Admins.Find(id);
            return View(acc);
        }

        //删除用户
        public ActionResult AdminDelete(int id)
        {
            Models.Admin acc = db.Admins.Find(id);
            return View(acc);
        }
        [HttpPost, ActionName("AdminDelete")]
        public ActionResult AdminDeleteConfirmed(int id)
        {
            Models.Admin acc = db.Admins.Find(id);
            db.Admins.Remove(acc);
            db.SaveChanges();
            return RedirectToAction("AdminList");
        }

        //修改用户
        public ActionResult AdminEdit(int id)
        {
            Models.Admin acc = db.Admins.Find(id);
            return View(acc);
        }
        [HttpPost]
        public ActionResult AdminEdit(Models.Admin acc)
        {
            db.Entry(acc).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("AdminList");
        }
    }
}