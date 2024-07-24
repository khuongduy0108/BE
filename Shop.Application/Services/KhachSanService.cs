using AutoMapper;
using Shop.Application.Dto;
using Shop.Domain.Entities;
using Shop.Domain.Repositories;
using System.Collections.Generic;

namespace Shop.Application.Services
{
    public class KhachSanService : IKhachSanService
    {
        private readonly IKhachSanRepo _khachSanRepo;
        private readonly IMapper _mapper;

        public KhachSanService(IKhachSanRepo khachSanRepo, IMapper mapper)
        {
            _khachSanRepo = khachSanRepo;
            _mapper = mapper;
        }

        public List<KhachSanDto> GetAll()
        {
            return _mapper.Map<List<KhachSanDto>>(_khachSanRepo.GetAll());
        }

        public KhachSanDto Get(int id)
        {
            return _mapper.Map<KhachSanDto>(_khachSanRepo.Get(id));
        }

        public bool Add(KhachSanDto khachSan)
        {
            return _khachSanRepo.Add(_mapper.Map<KhachSan>(khachSan));
        }

        public bool Update(KhachSanDto khachSan)
        {
            return _khachSanRepo.Update(_mapper.Map<KhachSan>(khachSan));
        }

        public bool Delete(int id)
        {
            return _khachSanRepo.Delete(id);
        }
    }
}
