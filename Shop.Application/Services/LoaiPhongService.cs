using AutoMapper;
using Shop.Application.Dto;
using Shop.Domain.Entities;
using Shop.Domain.Repositories;
using System.Collections.Generic;

namespace Shop.Application.Services
{
    public class LoaiPhongService : ILoaiPhongService
    {
        private readonly ILoaiPhongRepo _loaiPhongRepo;
        private readonly IMapper _mapper;

        public LoaiPhongService(ILoaiPhongRepo loaiPhongRepo, IMapper mapper)
        {
            _loaiPhongRepo = loaiPhongRepo;
            _mapper = mapper;
        }

        public List<LoaiPhongDto> GetAll()
        {
            return _mapper.Map<List<LoaiPhongDto>>(_loaiPhongRepo.GetAll());
        }

        public LoaiPhongDto Get(int id)
        {
            return _mapper.Map<LoaiPhongDto>(_loaiPhongRepo.Get(id));
        }

        public bool Add(LoaiPhongDto loaiPhong)
        {
            return _loaiPhongRepo.Add(_mapper.Map<LoaiPhong>(loaiPhong));
        }

        public bool Update(LoaiPhongDto loaiPhong)
        {
            return _loaiPhongRepo.Update(_mapper.Map<LoaiPhong>(loaiPhong));
        }

        public bool Delete(int id)
        {
            return _loaiPhongRepo.Delete(id);
        }
    }
}
