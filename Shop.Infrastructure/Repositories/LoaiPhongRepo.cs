using Shop.Domain.Entities;
using Shop.Domain.Repositories;
using Shop.Infrastructure.Context;

namespace Shop.Infrastructure.Repositories
{
    public class LoaiPhongRepo : Repo<LoaiPhong>, ILoaiPhongRepo
    {
        public LoaiPhongRepo(ShopDbContext dbContext) : base(dbContext)
        {
        }
    }
}
