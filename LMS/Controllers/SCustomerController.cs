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
    public class SCustomerController : Controller
    {
        private DAL.AccountContext db = new DAL.AccountContext();
        // GET: SCustomer
        public ActionResult SCustomerIndex()
        {
            return View();
        }

        //新增发货人
        public ActionResult SCustomerAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SCustomerAdd(Models.SCustomer SCustomer)
        {
            db.SCustomers.Add(SCustomer);
            db.SaveChanges();
            return RedirectToAction("SCustomerList");
        }

        //发货人列表
        public ActionResult SCustomerList(string Search)
        {
            List<Models.SCustomer> SCustomers;
            if (!string.IsNullOrEmpty(Search))
            {
                SCustomers = db.SCustomers.Where(u => u.SCustoName.Contains(Search)).ToList();
            }
            else
            {
                SCustomers = db.SCustomers.ToList();
            }
            ViewModels.AccountListViewModel aLVM = new ViewModels.AccountListViewModel();
            aLVM.SCustomer = SCustomers;
            return View(aLVM);
        }
        public ActionResult SCustomerList1(int? page)
        {
            var acc = db.SCustomers;
            int pageNumber = page ?? 1;
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"]);
            var acc1 = acc.OrderBy(x => x.SCustoName);
            IPagedList<Models.SCustomer> pageList = acc1.ToPagedList(pageNumber, pageSize);
            return View(pageList);
        }

        //发货人详情
        public ActionResult SCustomerDetail(int? id)
        {
            Models.SCustomer acc = db.SCustomers.Find(id);
            return View(acc);
        }

        //删除发货人
        public ActionResult SCustomerDelete(int id)
        {
            Models.SCustomer acc = db.SCustomers.Find(id);
            return View(acc);
        }
        [HttpPost, ActionName("SCustomerDelete")]
        public ActionResult SCustomerDeleteConfirmed(int id)
        {
            Models.SCustomer acc = db.SCustomers.Find(id);
            db.SCustomers.Remove(acc);
            db.SaveChanges();
            return RedirectToAction("SCustomerList");
        }

        //修改发货人
        public ActionResult SCustomerEdit(int id)
        {
            Models.SCustomer acc = db.SCustomers.Find(id);
            return View(acc);
        }
        [HttpPost]
        public ActionResult SCustomerEdit(Models.SCustomer acc)
        {
            db.Entry(acc).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("SCustomerList");
        }
    }
}