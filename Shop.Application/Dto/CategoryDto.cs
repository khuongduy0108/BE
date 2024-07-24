using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Dto
{
	public class CategoryDto
	{
		public int CategoryId { get; set; }
		[StringLength(100, MinimumLength = 5, ErrorMessage ="Tên danh mục phải từ 5 đến 100 kí tự")]
		public string CategoryName { get; set; }
	}
}
