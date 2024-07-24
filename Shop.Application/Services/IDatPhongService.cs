using Shop.Application.Dto;
using System.Collections.Generic;

namespace Shop.Application.Services
{
    public interface IDatPhongService
    {
        List<DatPhongDto> GetAll();
        DatPhongDto Get(int id);
        bool Add(DatPhongDto datPhong);
        bool Update(DatPhongDto datPhong);
        bool Delete(int id);
    }
}
