using GroceryAppSql.Core.EntityFramework;
using GroceryAppSql.DataAccess.Abstract;
using GroceryAppSql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryAppSql.DataAccess.EntityFramework
{
    public class ProductDal : RepositoryBase<Product, GroceryAppDbContext>, IProductRepository
    {
        public ProductDal(GroceryAppDbContext context) : base(context)
        {
        }
    }
}
