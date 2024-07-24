using System.ComponentModel.DataAnnotations;

namespace Shop.Application.Dto
{
    public class PhongDto
    {
        public int MaPhong { get; set; }

        [Required(ErrorMessage = "Số phòng không được trống")]
        [StringLength(10, ErrorMessage = "Số phòng không được vượt quá 10 kí tự")]
        public string SoPhong { get; set; }

        public string HinhAnhPhong { get; set; }

        [Required(ErrorMessage = "Mã khách sạn không được trống")]
        public int MaKhachSan { get; set; }

        [Required(ErrorMessage = "Mã loại phòng không được trống")]
        public int MaLoaiPhong { get; set; }
    }
}
