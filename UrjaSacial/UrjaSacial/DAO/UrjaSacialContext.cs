using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace UrjaSacial.Models
{
    public class UrjaSacialContext : DbContext
    {

        public UrjaSacialContext() : base("name=UrjaSacialContext")
        {
        }

        public DbSet<Produto> Produtoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
