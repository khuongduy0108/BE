using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Dto;
using Shop.Application.Services;

namespace Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatPhongController : ControllerBase
    {
        private readonly IDatPhongService _datPhongService;

        public DatPhongController(IDatPhongService datPhongService)
        {
            _datPhongService = datPhongService;
        }

        [HttpGet]
        public IActionResult GetDatPhongs()
        {
            return Ok(_datPhongService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetDatPhong(int id)
        {
            var datPhong = _datPhongService.Get(id);
            if (datPhong == null)
            {
                return NotFound();
            }
            return Ok(datPhong);
        }

        [HttpPost]
        public IActionResult AddDatPhong(DatPhongDto datPhong)
        {
            if (_datPhongService.Add(datPhong))
            {
                return CreatedAtAction("GetDatPhong", new { id = datPhong.MaDatPhong });
            }
            return Ok("Đặt phòng đã tồn tại");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDatPhong(DatPhongDto datPhong)
        {
            if (_datPhongService.Update(datPhong))
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDatPhong(int id)
        {
            if (_datPhongService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì Đặt phòng không tồn tại");
        }
    }
}
