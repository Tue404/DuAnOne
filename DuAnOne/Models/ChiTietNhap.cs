using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DuAnOne.Models
{
    public class ChiTietNhap
    {
        [Key]
        [StringLength(5)]
        public string MaChiTietNhap { get; set; }

        [Required]
        [StringLength(5)]
        public string MaNhaCC { get; set; }

        [Required]
        [StringLength(5)]
        public string MaSP { get; set; }

        [Required]
        public int SoLuongNhap { get; set; }

        [Required]
        public double DonGiaNhap { get; set; }

        [ForeignKey("MaNhaCC")]
        public virtual NhaCungCap NHACUNGCAP { get; set; }

        [ForeignKey("MaSP")]
        public virtual SanPham SANPHAM { get; set; }
    }
}
