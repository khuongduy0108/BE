using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Entities
{
    public class LoaiPhong
    {
        [Key]
        public int MaLoaiPhong { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string TenLoai { get; set; }

        [Column(TypeName = "text")]
        public string MoTa { get; set; }

        // Mối quan hệ với bảng Phong
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}