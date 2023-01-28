using GroceryAppSql.Business.Abstract;
using GroceryAppSql.DataAccess.Abstract;
using GroceryAppSql.Entities;
using System.Linq.Expressions;

namespace GroceryAppSql.Business
{
    public class FavoriManager : IFavoriService
    {
        IFavoriRepository repo;

        public FavoriManager(IFavoriRepository repo)
        {
            this.repo = repo;
        }

        public void Add(Favori entity)
        {
            repo.Add(entity);
        }

        public void Delete(Favori entity)
        {
            repo.Delete(entity);
        }

        public List<Favori> GetAll()
        {
            return repo.GetAll().ToList();
        }

        public Favori GetById(int id)
        {
            return repo.GetById(id);
        }

        public List<Favori> GetEx(Expression<Func<Favori, bool>> predicate)
        {
            return repo.GetEx(predicate).ToList();
        }

        public void Update(Favori entity)
        {
            repo.Update(entity);
        }
    }
}
