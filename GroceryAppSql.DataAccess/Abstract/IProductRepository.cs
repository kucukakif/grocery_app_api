using GroceryAppSql.Core.Dal;
using GroceryAppSql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryAppSql.DataAccess.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
