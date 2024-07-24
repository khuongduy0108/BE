using AutoMapper;
using Shop.Application.Dto;
using Shop.Domain.Entities;
using Shop.Domain.Entities.Shop.Domain.Entities;

namespace Shop.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Category
            CreateMap<Category, CategoryDto>().ReverseMap();

            // KhachHang
            CreateMap<KhachHang, KhachHangDto>().ReverseMap();

            // KhachSan
            CreateMap<KhachSan, KhachSanDto>().ReverseMap();

            // LoaiPhong
            CreateMap<LoaiPhong, LoaiPhongDto>().ReverseMap();

            // Phong
            CreateMap<Phong, PhongDto>().ReverseMap();

            // DatPhong
            CreateMap<DatPhong, DatPhongDto>().ReverseMap();
        }
    }
}
