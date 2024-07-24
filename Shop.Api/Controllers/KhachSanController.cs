using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Dto;
using Shop.Application.Services;

namespace Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachSanController : ControllerBase
    {
        private readonly IKhachSanService _khachSanService;

        public KhachSanController(IKhachSanService khachSanService)
        {
            _khachSanService = khachSanService;
        }

        [HttpGet]
        public IActionResult GetKhachSans()
        {
            return Ok(_khachSanService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetKhachSan(int id)
        {
            var khachSan = _khachSanService.Get(id);
            if (khachSan == null)
            {
                return NotFound();
            }
            return Ok(khachSan);
        }

        [HttpPost]
        public IActionResult AddKhachSan(KhachSanDto khachSan)
        {
            if (_khachSanService.Add(khachSan))
            {
                return CreatedAtAction("GetKhachSan", new { id = khachSan.MaKhachSan });
            }
            return Ok("Khách sạn đã tồn tại");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateKhachSan(KhachSanDto khachSan)
        {
            if (_khachSanService.Update(khachSan))
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteKhachSan(int id)
        {
            if (_khachSanService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì Khách sạn không tồn tại");
        }
    }
}
