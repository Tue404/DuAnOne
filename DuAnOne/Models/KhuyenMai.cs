﻿using System.ComponentModel.DataAnnotations;

namespace DuAnOne.Models
{
    public class KhuyenMai
    {
        [Key]
        [StringLength(5)]
        public string MaKhuyenMai { get; set; }

        [Required]
        public int PhanTramKhuyenMai { get; set; }

        [Required]
        public DateTime ThoiGianStart { get; set; }

        [Required]
        public DateTime ThoiGianEnd { get; set; }
    }
}
