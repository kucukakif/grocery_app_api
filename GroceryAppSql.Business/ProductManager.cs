using GroceryAppSql.Business.Abstract;
using GroceryAppSql.DataAccess.Abstract;
using GroceryAppSql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GroceryAppSql.Business
{
    public class ProductManager : IProductService
    {
        IProductRepository repo;

        public ProductManager(IProductRepository repo)
        {
            this.repo = repo;
        }

        public void Add(Product entity)
        {
            repo.Add(entity);
        }

        public void Delete(Product entity)
        {
            repo.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return repo.GetAll().ToList();
        }

        public Product GetById(int id)
        {
            return repo.GetById(id);
        }

        public List<Product> GetEx(Expression<Func<Product, bool>> predicate)
        {
            return repo.GetEx(predicate).ToList();
        }

        public void Update(Product entity)
        {
            repo.Update(entity);
        }
    }
}
