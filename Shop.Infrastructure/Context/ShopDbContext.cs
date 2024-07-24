using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;
using Shop.Domain.Entities.Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Context
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext()
        {
        }

        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhachSan> KhachSans { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<DatPhong> DatPhongs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Thiết lập cho bảng Category
            modelBuilder.Entity<Category>(e =>
            {
                e.ToTable("Category");
                e.HasKey(e => e.CategoryId);

                e.Property(e => e.CategoryId)
                    .IsRequired();

                e.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar");
            });

            // Thiết lập cho bảng KhachHang
            modelBuilder.Entity<KhachHang>(e =>
            {
                e.ToTable("KhachHang");
                e.HasKey(e => e.MaKhachHang);

                e.Property(e => e.MaKhachHang)
                    .IsRequired();

                e.Property(e => e.HoTenDem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar");

                e.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar");

                e.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar");

                e.Property(e => e.SoDienThoai)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar");
            });

            // Thiết lập cho bảng KhachSan
            modelBuilder.Entity<KhachSan>(e =>
            {
                e.ToTable("KhachSan");
                e.HasKey(e => e.MaKhachSan);

                e.Property(e => e.MaKhachSan)
                    .IsRequired();

                e.Property(e => e.TenKhachSan)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar");

                e.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("nvarchar");

                e.Property(e => e.SoDienThoai)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar");
                e.Property(e => e.HinhAnhKhachSan)
                    .HasColumnType("nvarchar(MAX)")
                    .HasColumnName("HinhAnhPhong");
            });

            // Thiết lập cho bảng LoaiPhong
            modelBuilder.Entity<LoaiPhong>(e =>
            {
                e.ToTable("LoaiPhong");
                e.HasKey(e => e.MaLoaiPhong);

                e.Property(e => e.MaLoaiPhong)
                    .IsRequired();

                e.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar");

                e.Property(e => e.MoTa)
                    .HasColumnType("text");
            });

            // Thiết lập cho bảng Phong
            modelBuilder.Entity<Phong>(e =>
            {
                e.ToTable("Phong");
                e.HasKey(e => e.MaPhong);

                e.Property(e => e.MaPhong)
                    .IsRequired();

                e.Property(e => e.SoPhong)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnType("nvarchar");

                e.Property(e => e.MaKhachSan)
                    .IsRequired();

                e.Property(e => e.MaLoaiPhong)
                    .IsRequired();

                e.Property(e => e.HinhAnhPhong)
                    .HasColumnType("nvarchar(MAX)")
                    .HasColumnName("HinhAnhPhong");

                e.HasOne(d => d.KhachSan)
                    .WithMany(p => p.Phongs)
                    .HasForeignKey(d => d.MaKhachSan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Phong_KhachSan");

                e.HasOne(d => d.LoaiPhong)
                    .WithMany(p => p.Phongs)
                    .HasForeignKey(d => d.MaLoaiPhong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Phong_LoaiPhong");
            });


            // Thiết lập cho bảng DatPhong
            modelBuilder.Entity<DatPhong>(e =>
            {
                e.ToTable("DatPhong");
                e.HasKey(e => e.MaDatPhong);

                e.Property(e => e.MaDatPhong)
                    .IsRequired();

                e.Property(e => e.MaKhachHang)
                    .IsRequired();

                e.Property(e => e.MaPhong)
                    .IsRequired();

                e.Property(e => e.NgayNhanPhong)
                    .HasColumnType("date");

                e.Property(e => e.NgayTraPhong)
                    .HasColumnType("date");

                e.Property(e => e.TongTien)
                    .HasColumnType("decimal(10,2)");

                e.HasOne(d => d.KhachHang)
                    .WithMany(p => p.DatPhongs)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DatPhong_KhachHang");

                e.HasOne(d => d.Phong)
                    .WithMany(p => p.DatPhongs)
                    .HasForeignKey(d => d.MaPhong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DatPhong_Phong");
        
            });
        }
    }
}
