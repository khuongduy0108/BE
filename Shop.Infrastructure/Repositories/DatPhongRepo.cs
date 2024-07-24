using Shop.Domain.Entities;
using Shop.Domain.Entities.Shop.Domain.Entities;
using Shop.Domain.Repositories;
using Shop.Infrastructure.Context;

namespace Shop.Infrastructure.Repositories
{
    public class DatPhongRepo : Repo<DatPhong>, IDatPhongRepo
    {
        public DatPhongRepo(ShopDbContext dbContext) : base(dbContext)
        {
        }
    }
}
