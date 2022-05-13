using DomainLayer.Entities.ProductGroups;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class ProductTariningContext:DbContext
    {
        public ProductTariningContext(DbContextOptions<ProductTariningContext> options):base(options)
        {

        }

        #region Dbset
        public DbSet<ProductGroup> productGroups { get; set; }
        #endregion
        #region ModelBuilder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductGroup>().HasQueryFilter(p => !p.IsDeleted);
        }
        #endregion

    }
}
