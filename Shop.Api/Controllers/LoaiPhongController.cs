using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Dto;
using Shop.Application.Services;

namespace Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiPhongController : ControllerBase
    {
        private readonly ILoaiPhongService _loaiPhongService;

        public LoaiPhongController(ILoaiPhongService loaiPhongService)
        {
            _loaiPhongService = loaiPhongService;
        }

        [HttpGet]
        public IActionResult GetLoaiPhongs()
        {
            return Ok(_loaiPhongService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetLoaiPhong(int id)
        {
            var loaiPhong = _loaiPhongService.Get(id);
            if (loaiPhong == null)
            {
                return NotFound();
            }
            return Ok(loaiPhong);
        }

        [HttpPost]
        public IActionResult AddLoaiPhong(LoaiPhongDto loaiPhong)
        {
            if (_loaiPhongService.Add(loaiPhong))
            {
                return CreatedAtAction("GetLoaiPhong", new { id = loaiPhong.MaLoaiPhong });
            }
            return Ok("Loại phòng đã tồn tại");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateLoaiPhong(LoaiPhongDto loaiPhong)
        {
            if (_loaiPhongService.Update(loaiPhong))
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLoaiPhong(int id)
        {
            if (_loaiPhongService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì Loại phòng không tồn tại");
        }
    }
}
