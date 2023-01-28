using GroceryAppSql.Business.Abstract;
using GroceryAppSql.DataAccess.Abstract;
using GroceryAppSql.Entities;
using System.Linq.Expressions;

namespace GroceryAppSql.Business
{
    public class CartManager : ICartService
    {
        ICartRepository repo;

        public CartManager(ICartRepository repo)
        {
            this.repo = repo;
        }

        public void Add(Cart entity)
        {
            repo.Add(entity);
        }

        public void Delete(Cart entity)
        {
            repo.Delete(entity);
        }

        public List<Cart> GetAll()
        {
            return repo.GetAll().ToList();
        }

        public Cart GetById(int id)
        {
            return repo.GetById(id);
        }

        public List<Cart> GetEx(Expression<Func<Cart, bool>> predicate)
        {
            return repo.GetEx(predicate).ToList();
        }

        public void Update(Cart entity)
        {
            repo.Update(entity);
        }
    }
}
