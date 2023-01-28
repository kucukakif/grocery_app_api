using GroceryAppSql.Entities;
using System.Linq.Expressions;

namespace GroceryAppSql.Business.Abstract
{
    public interface ICartService
    {
        List<Cart> GetAll();

        List<Cart> GetEx(Expression<Func<Cart, bool>> predicate);

        Cart GetById(int id);

        void Add(Cart entity);

        void Update(Cart entity);

        void Delete(Cart entity);
    }
}
