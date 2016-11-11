using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Nettbank.Model
{

    public class Payments
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public string AccNumber { get; set; }
        public string Kid { get; set; }
        public string Date { get; set; }

    }
    public class Accounts
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AccNumber { get; set; }
        public int Balance { get; set; }
    }

    public class Users
    {
        [Key]
        public long PersNr { get; set; }
        public string Passord { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public int zip { get; set; }

    }

    public class Admins
    {
        [Key]
        public long UserName { get; set; }
        public string Password { get; set; }

    }

    public class PaymentContext : DbContext
    {
        public PaymentContext()
            : base("name=Payments")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Payments> Payments { get; set; }
    }

    public class AccountContext : DbContext
    {
        public AccountContext()
            : base("name=Accounts")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Accounts> Accounts { get; set; }
    }

    public class UserContext : DbContext
    {

        public UserContext()
            : base("name=Users")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<UserContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }

    public class AdminContext : DbContext
    {

        public AdminContext()
            : base("name=Admins")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Admins> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<AdminContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}