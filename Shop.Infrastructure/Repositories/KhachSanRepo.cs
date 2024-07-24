using Shop.Domain.Entities;
using Shop.Domain.Repositories;
using Shop.Infrastructure.Context;

namespace Shop.Infrastructure.Repositories
{
    public class KhachSanRepo : Repo<KhachSan>, IKhachSanRepo
    {
        public KhachSanRepo(ShopDbContext dbContext) : base(dbContext)
        {
        }
    }
}
