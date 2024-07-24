using AutoMapper;
using Shop.Application.Dto;
using Shop.Domain.Entities;
using Shop.Domain.Repositories;
using Shop.Infrastructure.Repositories;
using System;
using System.Collections.Generic;

namespace Shop.Application.Services
{
    public class KhachHangService : IKhachHangService
    {
        private readonly IKhachHangRepo _khachHangRepo;
        private readonly IMapper _mapper;

        public KhachHangService(IKhachHangRepo khachHangRepo, IMapper mapper)
        {
            _khachHangRepo = khachHangRepo;
            _mapper = mapper;
        }

        public List<KhachHangDto> GetAll()
        {
            return _mapper.Map<List<KhachHangDto>>(_khachHangRepo.GetAll());
        }

        public KhachHangDto Get(int id)
        {
            return _mapper.Map<KhachHangDto>(_khachHangRepo.Get(id));
        }

        public bool Add(KhachHangDto khachHang)
        {
            return _khachHangRepo.Add(_mapper.Map<KhachHang>(khachHang));
        }

        public bool Update(KhachHangDto khachHang)
        {
            return _khachHangRepo.Update(_mapper.Map<KhachHang>(khachHang));
        }

        public bool Delete(int id)
        {
            return _khachHangRepo.Delete(id);
        }
    }
}
