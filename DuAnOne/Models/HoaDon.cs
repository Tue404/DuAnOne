using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DuAnOne.Models
{
    public class HoaDon
    {
        [Key]
        [StringLength(5)]
        public string MaHoaDon { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaChiNhanHang { get; set; }

        [Required]
        public DateTime NgayTao { get; set; }

        [Required]
        [StringLength(25)]
        public string HTTT { get; set; }

        [StringLength(30)]
        public string TinhTrang { get; set; } = "Chuẩn bị hàng";

        [Required]
        [StringLength(5)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(5)]
        public string MaKH { get; set; }

        [ForeignKey("MaNV")]
        public virtual NhanVien NHANVIEN { get; set; }

        [ForeignKey("MaKH")]
        public virtual KhachHang KHACHHANG { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
