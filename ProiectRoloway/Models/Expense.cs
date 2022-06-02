using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProiectRoloway.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public string ExpenseName { get; set; }
        public string ExpenseAmount { get; set; }

        public string UserId { get; set; }

        public string Date { get; set; }

        public string Deleted { get; set; }

        public string Category { get; set; }

    }
    public class ExpenseDbContex : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
    }
}