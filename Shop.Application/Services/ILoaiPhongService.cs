using Shop.Application.Dto;
using System.Collections.Generic;

namespace Shop.Application.Services
{
    public interface ILoaiPhongService
    {
        List<LoaiPhongDto> GetAll();
        LoaiPhongDto Get(int id);
        bool Add(LoaiPhongDto loaiPhong);
        bool Update(LoaiPhongDto loaiPhong);
        bool Delete(int id);
    }
}
