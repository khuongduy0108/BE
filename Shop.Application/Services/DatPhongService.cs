using AutoMapper;
using Shop.Application.Dto;
using Shop.Domain.Entities;
using Shop.Domain.Entities.Shop.Domain.Entities;
using Shop.Domain.Repositories;
using System.Collections.Generic;

namespace Shop.Application.Services
{
    public class DatPhongService : IDatPhongService
    {
        private readonly IDatPhongRepo _datPhongRepo;
        private readonly IMapper _mapper;

        public DatPhongService(IDatPhongRepo datPhongRepo, IMapper mapper)
        {
            _datPhongRepo = datPhongRepo;
            _mapper = mapper;
        }

        public List<DatPhongDto> GetAll()
        {
            return _mapper.Map<List<DatPhongDto>>(_datPhongRepo.GetAll());
        }

        public DatPhongDto Get(int id)
        {
            return _mapper.Map<DatPhongDto>(_datPhongRepo.Get(id));
        }

        public bool Add(DatPhongDto datPhong)
        {
            return _datPhongRepo.Add(_mapper.Map<DatPhong>(datPhong));
        }

        public bool Update(DatPhongDto datPhong)
        {
            return _datPhongRepo.Update(_mapper.Map<DatPhong>(datPhong));
        }

        public bool Delete(int id)
        {
            return _datPhongRepo.Delete(id);
        }
    }
}