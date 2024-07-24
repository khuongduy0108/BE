using Shop.Domain.Entities;
using Shop.Domain.Repositories;
using Shop.Infrastructure.Context;

namespace Shop.Infrastructure.Repositories
{
    public class PhongRepo : Repo<Phong>, IPhongRepo
    {
        public PhongRepo(ShopDbContext dbContext) : base(dbContext)
        {
        }
    }
}
