using System.ComponentModel.DataAnnotations;

namespace Shop.Application.Dto
{
    public class KhachSanDto
    {
        public int MaKhachSan { get; set; }

        [Required(ErrorMessage = "Tên khách sạn không được trống")]
        [StringLength(100, ErrorMessage = "Tên khách sạn không được vượt quá 100 kí tự")]
        public string TenKhachSan { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được trống")]
        [StringLength(255, ErrorMessage = "Địa chỉ không được vượt quá 255 kí tự")]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được trống")]
        [StringLength(20, ErrorMessage = "Số điện thoại không được vượt quá 20 kí tự")]
        public string SoDienThoai { get; set; }
        public string HinhAnhKhachSan { get; set; } 

    }
}
