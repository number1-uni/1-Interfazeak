using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ErronkaForm.Models;

namespace ErronkaForm.Models
{
    public class PhoneTicContext : DbContext
    {
        public PhoneTicContext() : base(nameOrConnectionString: "PhoneTicContext")
        { }
        public DbSet<sale_order_line> sale_order_line { get; set; }
        public DbSet<purchase_order_line> purchase_order_line { get; set; }
        public DbSet<res_partner> res_partner { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

