﻿using System.ComponentModel.DataAnnotations;

namespace DuAnOne.Models
{
    public class KhachHang
    {
        [Key]
        [StringLength(5)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(40)]
        public string HoTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(200)]
        public string? NoiSinh { get; set; }

        [StringLength(200)]
        public string? DiaChi { get; set; }

        [Required]
        [StringLength(12)]
        public string? CCCD { get; set; }

        [Required]
        [StringLength(11)]
        public string SDT { get; set; }

        [Required]
        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(15)]
        public string TenTaiKhoan { get; set; }

        [Required]
        [StringLength(20)]
        public string MatKhau { get; set; }

        [StringLength(25)]
        public string? TinhTrang { get; set; } = "Mở";
    }
}
