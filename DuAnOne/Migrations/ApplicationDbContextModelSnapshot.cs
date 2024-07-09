﻿// <auto-generated />
using System;
using DuAnOne.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DuAnOne.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DuAnOne.Models.ChiTietHoaDon", b =>
                {
                    b.Property<string>("MaHoaDon")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)")
                        .HasColumnOrder(0);

                    b.Property<string>("MaSP")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)")
                        .HasColumnOrder(1);

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<int>("SoLuongMua")
                        .HasColumnType("int");

                    b.HasKey("MaHoaDon", "MaSP");

                    b.HasIndex("MaSP");

                    b.ToTable("CHITIETHOADONs");
                });

            modelBuilder.Entity("DuAnOne.Models.ChiTietNhap", b =>
                {
                    b.Property<string>("MaChiTietNhap")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<double>("DonGiaNhap")
                        .HasColumnType("float");

                    b.Property<string>("MaNhaCC")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("MaSP")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("SoLuongNhap")
                        .HasColumnType("int");

                    b.HasKey("MaChiTietNhap");

                    b.HasIndex("MaNhaCC");

                    b.HasIndex("MaSP");

                    b.ToTable("CHITIETNHAPs");
                });

            modelBuilder.Entity("DuAnOne.Models.HoaDon", b =>
                {
                    b.Property<string>("MaHoaDon")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("DiaChiNhanHang")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("HTTT")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("TinhTrang")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("MaHoaDon");

                    b.HasIndex("MaKH");

                    b.HasIndex("MaNV");

                    b.ToTable("HOADONs");
                });

            modelBuilder.Entity("DuAnOne.Models.KhachHang", b =>
                {
                    b.Property<string>("MaKH")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiSinh")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("TenTaiKhoan")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("TinhTrang")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("MaKH");

                    b.ToTable("KHACHHANGs");
                });

            modelBuilder.Entity("DuAnOne.Models.KhuyenMai", b =>
                {
                    b.Property<string>("MaKhuyenMai")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("PhanTramKhuyenMai")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGianEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianStart")
                        .HasColumnType("datetime2");

                    b.HasKey("MaKhuyenMai");

                    b.ToTable("KHUYENMAIs");
                });

            modelBuilder.Entity("DuAnOne.Models.NhaCungCap", b =>
                {
                    b.Property<string>("MaNhaCC")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("NgayThanhLap")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiDaiDien")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("TenNhaCC")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("ThoiGianCungCap")
                        .HasColumnType("datetime2");

                    b.Property<string>("TinhTrang")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("MaNhaCC");

                    b.ToTable("NHACUNGCAPs");
                });

            modelBuilder.Entity("DuAnOne.Models.NhanVien", b =>
                {
                    b.Property<string>("MaNV")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Luong")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayVaoLam")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiSinh")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("TenTaiKhoan")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("TinhTrang")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("VaiTro")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("MaNV");

                    b.ToTable("NHANVIENs");
                });

            modelBuilder.Entity("DuAnOne.Models.SanPham", b =>
                {
                    b.Property<string>("MaSP")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("DanhMucHang")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<double>("DonGiaBan")
                        .HasColumnType("float");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MaKhuyenMai")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuongBan")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("MaSP");

                    b.HasIndex("MaKhuyenMai");

                    b.HasIndex("MaNV");

                    b.ToTable("SANPHAMs");
                });

            modelBuilder.Entity("DuAnOne.Models.ChiTietHoaDon", b =>
                {
                    b.HasOne("DuAnOne.Models.HoaDon", "HOADON")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("MaHoaDon")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DuAnOne.Models.SanPham", "SANPHAM")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("HOADON");

                    b.Navigation("SANPHAM");
                });

            modelBuilder.Entity("DuAnOne.Models.ChiTietNhap", b =>
                {
                    b.HasOne("DuAnOne.Models.NhaCungCap", "NHACUNGCAP")
                        .WithMany()
                        .HasForeignKey("MaNhaCC")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DuAnOne.Models.SanPham", "SANPHAM")
                        .WithMany()
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NHACUNGCAP");

                    b.Navigation("SANPHAM");
                });

            modelBuilder.Entity("DuAnOne.Models.HoaDon", b =>
                {
                    b.HasOne("DuAnOne.Models.KhachHang", "KHACHHANG")
                        .WithMany()
                        .HasForeignKey("MaKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DuAnOne.Models.NhanVien", "NHANVIEN")
                        .WithMany()
                        .HasForeignKey("MaNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KHACHHANG");

                    b.Navigation("NHANVIEN");
                });

            modelBuilder.Entity("DuAnOne.Models.SanPham", b =>
                {
                    b.HasOne("DuAnOne.Models.KhuyenMai", "KHUYENMAI")
                        .WithMany()
                        .HasForeignKey("MaKhuyenMai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DuAnOne.Models.NhanVien", "NHANVIEN")
                        .WithMany()
                        .HasForeignKey("MaNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KHUYENMAI");

                    b.Navigation("NHANVIEN");
                });

            modelBuilder.Entity("DuAnOne.Models.HoaDon", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });

            modelBuilder.Entity("DuAnOne.Models.SanPham", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
