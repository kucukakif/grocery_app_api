using GroceryAppSql.Entities;
using System.Linq.Expressions;

namespace GroceryAppSql.Business.Abstract
{
    public interface IFavoriService
    {

        List<Favori> GetAll();

        List<Favori> GetEx(Expression<Func<Favori, bool>> predicate);

        Favori GetById(int id);

        void Add(Favori entity);

        void Update(Favori entity);

        void Delete(Favori entity);
    }
}
