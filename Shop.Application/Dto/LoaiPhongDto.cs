using System.ComponentModel.DataAnnotations;

namespace Shop.Application.Dto
{
    public class LoaiPhongDto
    {
        public int MaLoaiPhong { get; set; }

        [Required(ErrorMessage = "Tên loại phòng không được trống")]
        [StringLength(50, ErrorMessage = "Tên loại phòng không được vượt quá 50 kí tự")]
        public string TenLoai { get; set; }

        public string MoTa { get; set; }
    }
}
