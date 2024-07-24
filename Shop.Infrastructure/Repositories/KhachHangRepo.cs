using Shop.Domain.Entities;
using Shop.Domain.Repositories;
using Shop.Infrastructure.Context;

namespace Shop.Infrastructure.Repositories
{
    public class KhachHangRepo : Repo<KhachHang>, IKhachHangRepo
    {
        public KhachHangRepo(ShopDbContext dbContext) : base(dbContext)
        {
        }
    }
}
