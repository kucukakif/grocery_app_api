using GroceryAppSql.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryAppSql.DataAccess.EntityFramework
{
    public class GroceryAppDbContext : DbContext
    {
        public GroceryAppDbContext(DbContextOptions<GroceryAppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Favori> Favoris { get; set; }
        public DbSet<Cart> Categories{ get; set; }
    }
}
