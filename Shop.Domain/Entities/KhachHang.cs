using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Domain.Entities.Shop.Domain.Entities;

namespace Shop.Domain.Entities
{
    public class KhachHang
    {
        [Key]
        public int MaKhachHang { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string HoTenDem { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string Ten { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        [Column(TypeName = "nvarchar")]
        public string SoDienThoai { get; set; }

        // Mối quan hệ với bảng DatPhong
        public virtual ICollection<DatPhong> DatPhongs { get; set; }
    }
}