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
    public class Phong
    {
        [Key]
        public int MaPhong { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nvarchar")]
        public string SoPhong { get; set; }

        public string HinhAnhPhong { get; set; }

        [Required]
        public int MaKhachSan { get; set; }

        [Required]
        public int MaLoaiPhong { get; set; }

        // Mối quan hệ với bảng KhachSan
        [ForeignKey(nameof(MaKhachSan))]
        public virtual KhachSan KhachSan { get; set; }

        // Mối quan hệ với bảng LoaiPhong
        [ForeignKey(nameof(MaLoaiPhong))]
        public virtual LoaiPhong LoaiPhong { get; set; }

        // Mối quan hệ với bảng DatPhong
        public virtual ICollection<DatPhong> DatPhongs { get; set; }
    }
}