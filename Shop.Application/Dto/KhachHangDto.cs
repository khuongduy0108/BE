using System.ComponentModel.DataAnnotations;

namespace Shop.Application.Dto
{
    public class KhachHangDto
    {
        public int MaKhachHang { get; set; }

        [Required(ErrorMessage = "Họ tên đệm không được trống")]
        [StringLength(50, ErrorMessage = "Họ tên đệm không được vượt quá 50 kí tự")]
        public string HoTenDem { get; set; }

        [Required(ErrorMessage = "Tên không được trống")]
        [StringLength(50, ErrorMessage = "Tên không được vượt quá 50 kí tự")]
        public string Ten { get; set; }

        [Required(ErrorMessage = "Email không được trống")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
        [StringLength(100, ErrorMessage = "Email không được vượt quá 100 kí tự")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được trống")]
        [StringLength(20, ErrorMessage = "Số điện thoại không được vượt quá 20 kí tự")]
        public string SoDienThoai { get; set; }
    }
}
