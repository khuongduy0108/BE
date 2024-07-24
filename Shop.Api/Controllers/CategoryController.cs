using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Dto;
using Shop.Application.Services;

namespace Shop.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;
		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}
		[HttpGet]
		public IActionResult GetCategories()
		{
			return Ok(_categoryService.GetAll());
		}

		[HttpGet("{id}")]
		public IActionResult GetCategory(int id)
		{
			var category = _categoryService.Get(id);
			if(category == null)
			{
				return NotFound();//trả về mã 404
			}
			return Ok(category);//trả về mã 200 cho category
		}

		[HttpPost]
		public IActionResult AddCategory(CategoryDto category)
		{
			if(_categoryService.Add(category))
			{
				return CreatedAtAction("GetCategory", new {id=category.CategoryId});
			}
			return Ok("category đã tồn tại");//trả về 1 chuỗi category đã tồn tại
		}

		[HttpPut("{id}")]
		public IActionResult UpdateCategory(CategoryDto category)
		{
			if(_categoryService.Update(category))
			{
				return NoContent();
			}
			return NotFound();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteCategory(int id) 
		{ 
			if(_categoryService.Delete(id))
			{
				return NoContent();
			}
			return NotFound("Không thể xóa cì Category không tồn tại");
		}
	}
}
