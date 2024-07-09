using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DuAnOne.Models
{
    public class ChiTietHoaDon
    {
        
        [Key, Column(Order = 0)]
        [StringLength(5)]
        public string MaHoaDon { get; set; }

        [Key, Column(Order = 1)]
        [StringLength(5)]
        public string MaSP { get; set; }

        [Required]
        public int SoLuongMua { get; set; }

        [Required]
        public double DonGia { get; set; }

        [ForeignKey("MaHoaDon")]
        public virtual HoaDon HOADON { get; set; }

        [ForeignKey("MaSP")]
        public virtual SanPham SANPHAM { get; set; }
    }
}

