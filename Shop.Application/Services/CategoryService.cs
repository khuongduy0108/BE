using AutoMapper;
using Shop.Application.Dto;
using Shop.Domain.Entities;
using Shop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly ICategoryRepo _categoryRepo; //gọi thông qua Interface
		private readonly IMapper _mapper;
		public CategoryService(ICategoryRepo categoryRepo, IMapper mapper)
		{
			_categoryRepo = categoryRepo;
			_mapper = mapper;
		}
		public List<CategoryDto> GetAll() 
		{ 
			return _mapper.Map<List<CategoryDto>>(_categoryRepo.GetAll());
		}

		public CategoryDto Get(int id) 
		{
			return _mapper.Map<CategoryDto>(_categoryRepo.Get(id));
		}

		public bool Add(CategoryDto category) 
		{
			return _categoryRepo.Add(_mapper.Map<Category>(category));
		}
		public bool Update(CategoryDto category)
		{
			return _categoryRepo.Update(_mapper.Map<Category>(category));
		}

		public bool Delete(int id) 
		{
			return _categoryRepo.Delete(id);
		}
	}
}
