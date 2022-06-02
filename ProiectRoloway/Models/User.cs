using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProiectRoloway.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
    public class UserDbContex : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}