using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Dto;
using Shop.Application.Services;

namespace Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhongController : ControllerBase
    {
        private readonly IPhongService _phongService;

        public PhongController(IPhongService phongService)
        {
            _phongService = phongService;
        }

        [HttpGet]
        public IActionResult GetPhongs()
        {
            return Ok(_phongService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetPhong(int id)
        {
            var phong = _phongService.Get(id);
            if (phong == null)
            {
                return NotFound();
            }
            return Ok(phong);
        }

        [HttpPost]
        public IActionResult AddPhong(PhongDto phong)
        {
            if (_phongService.Add(phong))
            {
                return CreatedAtAction("GetPhong", new { id = phong.MaPhong });
            }
            return Ok("Phòng đã tồn tại");
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePhong(PhongDto phong)
        {
            if (_phongService.Update(phong))
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePhong(int id)
        {
            if (_phongService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì Phòng không tồn tại");
        }
    }
}
