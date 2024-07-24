using Shop.Application.Dto;
using System.Collections.Generic;

namespace Shop.Application.Services
{
    public interface IKhachSanService
    {
        List<KhachSanDto> GetAll();
        KhachSanDto Get(int id);
        bool Add(KhachSanDto khachSan);
        bool Update(KhachSanDto khachSan);
        bool Delete(int id);
    }
}
