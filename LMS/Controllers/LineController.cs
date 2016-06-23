using PagedList;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS.Controllers
{
    public class LineController : Controller
    {
        private DAL.AccountContext db = new DAL.AccountContext();
        // GET: Line
        public ActionResult LineIndex()
        {
            return View();
        }

        //新增发货人
        public ActionResult LineAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LineAdd(Models.Line Line)
        {
            db.Lines.Add(Line);
            db.SaveChanges();
            return RedirectToAction("LineList");
        }

        //发货人列表
        public ActionResult LineList(string Search)
        {
            List<Models.Line> Lines;
            if (!string.IsNullOrEmpty(Search))
            {
                Lines = db.Lines.Where(u => u.Start.Contains(Search)).ToList();
            }
            else
            {
                Lines = db.Lines.ToList();
            }
            ViewModels.AccountListViewModel aLVM = new ViewModels.AccountListViewModel();
            aLVM.Line = Lines;
            return View(aLVM);
        }
        public ActionResult LineList1(int? page)
        {
            var acc = db.Lines;
            int pageNumber = page ?? 1;
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"]);
            var acc1 = acc.OrderBy(x => x.Start);
            IPagedList<Models.Line> pageList = acc1.ToPagedList(pageNumber, pageSize);
            return View(pageList);
        }

        //发货人详情
        public ActionResult LineDetail(int? id)
        {
            Models.Line acc = db.Lines.Find(id);
            return View(acc);
        }

        //删除发货人
        public ActionResult LineDelete(int id)
        {
            Models.Line acc = db.Lines.Find(id);
            return View(acc);
        }
        [HttpPost, ActionName("LineDelete")]
        public ActionResult LineDeleteConfirmed(int id)
        {
            Models.Line acc = db.Lines.Find(id);
            db.Lines.Remove(acc);
            db.SaveChanges();
            return RedirectToAction("LineList");
        }

        //修改发货人
        public ActionResult LineEdit(int id)
        {
            Models.Line acc = db.Lines.Find(id);
            return View(acc);
        }
        [HttpPost]
        public ActionResult LineEdit(Models.Line acc)
        {
            db.Entry(acc).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("LineList");
        }
    }
}