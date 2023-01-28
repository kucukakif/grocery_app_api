using GroceryAppSql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GroceryAppSql.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetEx(Expression<Func<Product, bool>> predicate);

        Product GetById(int id);

        void Add(Product entity);

        void Update(Product entity);

        void Delete(Product entity);
    }
}
