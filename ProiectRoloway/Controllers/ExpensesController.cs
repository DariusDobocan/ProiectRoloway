using ProiectRoloway.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProiectRoloway.Controllers
{
    public class ExpensesController : Controller
    {
        private ExpenseDbContex edb = new ExpenseDbContex();
        // GET: Expenses
        public ActionResult Index()
        {

            return View(edb.Expenses.ToList());
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit(int Id)
        {

            Expense e1 = edb.Expenses.SingleOrDefault(m => m.ExpenseId == Id);
            Expense e2 = edb.Expenses.SingleOrDefault(m => m.ExpenseId == Id);
            if (e2 != null)
            {
                edb.Expenses.Remove(e2);
                edb.SaveChanges();
            }
                return View(e1);
        }

        public ActionResult Delete(int Id)
        {
            Expense e = edb.Expenses.SingleOrDefault(m => m.ExpenseId == Id);
            if (e != null)
            {
                e.Deleted = "yes";
                edb.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Adauga(Expense expense)
        {
            
                Expense e = new Expense();
                e.ExpenseName = expense.ExpenseName;
                e.ExpenseAmount = expense.ExpenseAmount;
                e.UserId = expense.UserId;
                e.Date = expense.Date;
                e.Category = expense.Category;
                edb.Expenses.Add(e); 
                edb.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Expense expense)
        {
            Expense e = new Expense();
            e.ExpenseName = expense.ExpenseName;
            e.ExpenseAmount = expense.ExpenseAmount;
            e.UserId = expense.UserId;
            e.Date = expense.Date;
            e.Category = expense.Category;
 
            edb.Expenses.Add(e);
            edb.SaveChanges(); 
        
            return RedirectToAction("Index");
        }

    }
}