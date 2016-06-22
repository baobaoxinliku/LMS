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
    public class FCustomerController : Controller
    {
        private DAL.AccountContext db = new DAL.AccountContext();
        // GET: FCustomer
        public ActionResult FCustomerIndex()
        {
            return View();
        }

        //新增发货人
        public ActionResult FCustomerAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FCustomerAdd(Models.FCustomer FCustomer)
        {
            db.FCustomers.Add(FCustomer);
            db.SaveChanges();
            return RedirectToAction("FCustomerList");
        }

        //发货人列表
        public ActionResult FCustomerList(string Search)
        {
            List<Models.FCustomer> FCustomers;
            if (!string.IsNullOrEmpty(Search))
            {
                FCustomers = db.FCustomers.Where(u => u.FCustoName.Contains(Search)).ToList();
            }
            else
            {
                FCustomers = db.FCustomers.ToList();
            }
            ViewModels.AccountListViewModel aLVM = new ViewModels.AccountListViewModel();
            aLVM.FCustomer = FCustomers;
            return View(aLVM);
        }
        public ActionResult FCustomerList1(int? page)
        {
            var acc = db.FCustomers;
            int pageNumber = page ?? 1;
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"]);
            var acc1 = acc.OrderBy(x => x.FCustoName);
            IPagedList<Models.FCustomer> pageList = acc1.ToPagedList(pageNumber, pageSize);
            return View(pageList);
        }

        //发货人详情
        public ActionResult FCustomerDetail(int? id)
        {
            Models.FCustomer acc = db.FCustomers.Find(id);
            return View(acc);
        }

        //删除发货人
        public ActionResult FCustomerDelete(int id)
        {
            Models.FCustomer acc = db.FCustomers.Find(id);
            return View(acc);
        }
        [HttpPost, ActionName("FCustomerDelete")]
        public ActionResult FCustomerDeleteConfirmed(int id)
        {
            Models.FCustomer acc = db.FCustomers.Find(id);
            db.FCustomers.Remove(acc);
            db.SaveChanges();
            return RedirectToAction("FCustomerList");
        }

        //修改发货人
        public ActionResult FCustomerEdit(int id)
        {
            Models.FCustomer acc = db.FCustomers.Find(id);
            return View(acc);
        }
        [HttpPost]
        public ActionResult FCustomerEdit(Models.FCustomer acc)
        {
            db.Entry(acc).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("FCustomerList");
        }
    }
}