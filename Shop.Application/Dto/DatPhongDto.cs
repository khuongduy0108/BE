using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Application.Dto
{
    public class DatPhongDto
    {
        public int MaDatPhong { get; set; }

        [Required(ErrorMessage = "Mã khách hàng không được trống")]
        public int MaKhachHang { get; set; }

        [Required(ErrorMessage = "Mã phòng không được trống")]
        public int MaPhong { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Ngày nhận phòng không hợp lệ")]
        public DateTime NgayNhanPhong { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Ngày trả phòng không hợp lệ")]
        public DateTime NgayTraPhong { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "Tổng tiền không hợp lệ")]
        public decimal TongTien { get; set; }
    }
}
