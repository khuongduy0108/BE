using AutoMapper;
using Shop.Application.Dto;
using Shop.Domain.Entities;
using Shop.Domain.Repositories;
using System.Collections.Generic;

namespace Shop.Application.Services
{
    public class PhongService : IPhongService
    {
        private readonly IPhongRepo _phongRepo;
        private readonly IMapper _mapper;

        public PhongService(IPhongRepo phongRepo, IMapper mapper)
        {
            _phongRepo = phongRepo;
            _mapper = mapper;
        }

        public List<PhongDto> GetAll()
        {
            return _mapper.Map<List<PhongDto>>(_phongRepo.GetAll());
        }

        public PhongDto Get(int id)
        {
            return _mapper.Map<PhongDto>(_phongRepo.Get(id));
        }

        public bool Add(PhongDto phong)
        {
            return _phongRepo.Add(_mapper.Map<Phong>(phong));
        }

        public bool Update(PhongDto phong)
        {
            return _phongRepo.Update(_mapper.Map<Phong>(phong));
        }

        public bool Delete(int id)
        {
            return _phongRepo.Delete(id);
        }
    }
}
