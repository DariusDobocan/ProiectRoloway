using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProiectRoloway.Models
{
    public class Income
    {
        public int IncomeId { get; set; }
        public string IncomeName { get; set; }
        public string IncomeAmount { get; set; }

        public string UserId { get; set; }

        public string Date { get; set; }

        public string Deleted { get; set; }

        public string Category { get; set; }

    }
    public class IncomeDbContex : DbContext
    {
        public DbSet<Income> Incomes { get; set; }
    }
}