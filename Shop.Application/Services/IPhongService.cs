using Shop.Application.Dto;
using System.Collections.Generic;

namespace Shop.Application.Services
{
    public interface IPhongService
    {
        List<PhongDto> GetAll();
        PhongDto Get(int id);
        bool Add(PhongDto phong);
        bool Update(PhongDto phong);
        bool Delete(int id);
    }
}
