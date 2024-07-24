using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Dto;
using Shop.Application.Services;

namespace Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase
    {
        private readonly IKhachHangService _khachHangService;

        public KhachHangController(IKhachHangService khachHangService)
        {
            _khachHangService = khachHangService;
        }

        [HttpGet]
        public IActionResult GetKhachHangs()
        {
            return Ok(_khachHangService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetKhachHang(int id)
        {
            var khachHang = _khachHangService.Get(id);
            if (khachHang == null)
            {
                return NotFound();
            }
            return Ok(khachHang);
        }

        [HttpPost]
        public IActionResult AddKhachHang(KhachHangDto khachHang)
        {
            if (_khachHangService.Add(khachHang))
            {
                return CreatedAtAction("GetKhachHang", new { id = khachHang.MaKhachHang });
            }
            return Ok("Khách hàng đã tồn tại");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateKhachHang(KhachHangDto khachHang)
        {
            if (_khachHangService.Update(khachHang))
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteKhachHang(int id)
        {
            if (_khachHangService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì Khách hàng không tồn tại");
        }
    }
}
