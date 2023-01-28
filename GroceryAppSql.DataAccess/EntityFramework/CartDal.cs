using GroceryAppSql.Core.EntityFramework;
using GroceryAppSql.DataAccess.Abstract;
using GroceryAppSql.Entities;

namespace GroceryAppSql.DataAccess.EntityFramework
{
    public class CartDal : RepositoryBase<Cart, GroceryAppDbContext>, ICartRepository
    {
        public CartDal(GroceryAppDbContext context) : base(context)
        {
        }
    }
}
