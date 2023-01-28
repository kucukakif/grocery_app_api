using GroceryAppSql.Core.EntityFramework;
using GroceryAppSql.DataAccess.Abstract;
using GroceryAppSql.Entities;

namespace GroceryAppSql.DataAccess.EntityFramework
{
    public class FavoriDal : RepositoryBase<Favori, GroceryAppDbContext>, IFavoriRepository
    {
        public FavoriDal(GroceryAppDbContext context) : base(context)
        {
        }
    }
}
