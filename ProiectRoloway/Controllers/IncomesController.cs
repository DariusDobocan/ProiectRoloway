using ProiectRoloway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProiectRoloway.Controllers
{
    public class IncomesController : Controller
    {
        // GET: Incomes
        private IncomeDbContex idb = new IncomeDbContex();
        
        public ActionResult Index()
        {

            return View(idb.Incomes.ToList());
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit(int Id)
        {

            Income i1 = idb.Incomes.SingleOrDefault(i => i.IncomeId == Id);
            Income i2 = idb.Incomes.SingleOrDefault(i => i.IncomeId == Id);
            if (i2 != null)
            {
                idb.Incomes.Remove(i2);
                idb.SaveChanges();
            }
            return View(i1);
        }

        public ActionResult Delete(int Id)
        {
            Income i = idb.Incomes.SingleOrDefault(m => m.IncomeId == Id);
            if (i != null)
            {
                i.Deleted = "yes";
                idb.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Adauga(Income income)
        {

            Income i = new Income();
            i.IncomeName = income.IncomeName;
            i.IncomeAmount = income.IncomeAmount;  
            i.UserId = income.UserId;
            i.Date = income.Date;
            i.Category = income.Category;
            
            idb.Incomes.Add(i);
            idb.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Income income)
        {
            Income i = new Income();
            i.IncomeName = income.IncomeName;
            i.IncomeAmount = income.IncomeAmount;
            i.UserId = income.UserId;
            i.Date = income.Date;
            i.Category = income.Category;

            idb.Incomes.Add(i);
            idb.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}