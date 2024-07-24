using Shop.Application.Dto;
using System.Collections.Generic;

namespace Shop.Application.Services
{
    public interface IKhachHangService
    {
        List<KhachHangDto> GetAll();
        KhachHangDto Get(int id);
        bool Add(KhachHangDto khachHang);
        bool Update(KhachHangDto khachHang);
        bool Delete(int id);
    }
}
