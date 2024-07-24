using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Entities
{
    namespace Shop.Domain.Entities
    {
        public class DatPhong
        {
            [Key]
            public int MaDatPhong { get; set; }

            [Required]
            public int MaKhachHang { get; set; }

            [Required]
            public int MaPhong { get; set; }

            [Column(TypeName = "date")]
            public DateTime NgayNhanPhong { get; set; }

            [Column(TypeName = "date")]
            public DateTime NgayTraPhong { get; set; }

            [Column(TypeName = "decimal(10,2)")]
            public decimal TongTien { get; set; }

            // Mối quan hệ với bảng KhachHang
            [ForeignKey(nameof(MaKhachHang))]
            public virtual KhachHang KhachHang { get; set; }

            // Mối quan hệ với bảng Phong
            [ForeignKey(nameof(MaPhong))]
            public virtual Phong Phong { get; set; }
        }
    }
}