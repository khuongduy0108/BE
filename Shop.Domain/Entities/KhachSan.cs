using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Entities
{
    public class KhachSan
    {
        [Key]
        public int MaKhachSan { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string TenKhachSan { get; set; }

        [Required]
        [MaxLength(255)]
        [Column(TypeName = "nvarchar")]
        public string DiaChi { get; set; }

        [Required]
        [MaxLength(20)]
        [Column(TypeName = "nvarchar")]
        public string SoDienThoai { get; set; }
        public string HinhAnhKhachSan { get; set; } // Đường dẫn đến hình ảnh khách sạn

        // Mối quan hệ với bảng Phong
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}