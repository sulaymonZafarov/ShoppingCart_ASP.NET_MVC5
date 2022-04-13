using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ShoppingCart_ASP.NET_MVC5.Models
{
    public class Context : DbContext 
    {
        public Context()
                : base("name=dbSMSEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public virtual DbSet<AllItemList>  AllItemLists { get; set; }
        public virtual DbSet<Cart>  Carts { get; set; }
        public virtual DbSet<Customer>   Customers { get; set; }
        public virtual DbSet<Product>   Products { get; set; }
        public virtual DbSet<PurchaseItems>   PurchaseItems { get; set; }

    }
}