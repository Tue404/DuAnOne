using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DuAnOne.Models
{
    public class SanPham
    {
        [Key]
        [StringLength(5)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(40)]
        public string TenSP { get; set; }

        [Required]
        public int SoLuongBan { get; set; }

        [Required]
        public double DonGiaBan { get; set; }

        [Required]
        public DateTime NgayNhap { get; set; }

        [Required]
        [StringLength(40)]
        public string DanhMucHang { get; set; }

        [Required]
        [StringLength(50)]
        public string HinhAnh { get; set; }

        [Required]
        public string MoTa { get; set; }

        [StringLength(5)]
        public string MaKhuyenMai { get; set; }

        [StringLength(5)]
        public string MaNV { get; set; }

        [ForeignKey("MaNV")]
        public virtual NhanVien NHANVIEN { get; set; }

        [ForeignKey("MaKhuyenMai")]
        public virtual KhuyenMai KHUYENMAI { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

    }
}
