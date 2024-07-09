using DuAnOne.Models;
using Microsoft.EntityFrameworkCore;

namespace DuAnOne.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base (options)
        { 

        }
        public DbSet<NhanVien> NHANVIENs { get; set; }
        public DbSet<KhachHang> KHACHHANGs { get; set; }
        public DbSet<NhaCungCap> NHACUNGCAPs { get; set; }
        public DbSet<KhuyenMai> KHUYENMAIs { get; set; }
        public DbSet<SanPham> SANPHAMs { get; set; }
        public DbSet<ChiTietNhap> CHITIETNHAPs { get; set; }
        public DbSet<HoaDon> HOADONs { get; set; }
        public DbSet<ChiTietHoaDon> CHITIETHOADONs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình khóa chính tổng hợp cho ChiTietHoaDon
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasKey(c => new { c.MaHoaDon, c.MaSP });

            // Sửa hành động xóa của khóa ngoại
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(c => c.HOADON)
                .WithMany(h => h.ChiTietHoaDons)
                .HasForeignKey(c => c.MaHoaDon)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(c => c.SANPHAM)
                .WithMany(s => s.ChiTietHoaDons)
                .HasForeignKey(c => c.MaSP)
                .OnDelete(DeleteBehavior.NoAction);
        }


    }
}
