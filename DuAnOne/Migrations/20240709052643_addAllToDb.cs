using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuAnOne.Migrations
{
    public partial class addAllToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KHACHHANGs",
                columns: table => new
                {
                    MaKH = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NoiSinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CCCD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHACHHANGs", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "KHUYENMAIs",
                columns: table => new
                {
                    MaKhuyenMai = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PhanTramKhuyenMai = table.Column<int>(type: "int", nullable: false),
                    ThoiGianStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHUYENMAIs", x => x.MaKhuyenMai);
                });

            migrationBuilder.CreateTable(
                name: "NHACUNGCAPs",
                columns: table => new
                {
                    MaNhaCC = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TenNhaCC = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    NgayThanhLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiDaiDien = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ThoiGianCungCap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHACUNGCAPs", x => x.MaNhaCC);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIENs",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NoiSinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Luong = table.Column<int>(type: "int", nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHANVIENs", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "HOADONs",
                columns: table => new
                {
                    MaHoaDon = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    DiaChiNhanHang = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HTTT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOADONs", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HOADONs_KHACHHANGs_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KHACHHANGs",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HOADONs_NHANVIENs_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NHANVIENs",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SANPHAMs",
                columns: table => new
                {
                    MaSP = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    SoLuongBan = table.Column<int>(type: "int", nullable: false),
                    DonGiaBan = table.Column<double>(type: "float", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DanhMucHang = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaKhuyenMai = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SANPHAMs", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_SANPHAMs_KHUYENMAIs_MaKhuyenMai",
                        column: x => x.MaKhuyenMai,
                        principalTable: "KHUYENMAIs",
                        principalColumn: "MaKhuyenMai",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SANPHAMs_NHANVIENs_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NHANVIENs",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETHOADONs",
                columns: table => new
                {
                    MaHoaDon = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    SoLuongMua = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETHOADONs", x => new { x.MaHoaDon, x.MaSP });
                    table.ForeignKey(
                        name: "FK_CHITIETHOADONs_HOADONs_MaHoaDon",
                        column: x => x.MaHoaDon,
                        principalTable: "HOADONs",
                        principalColumn: "MaHoaDon");
                    table.ForeignKey(
                        name: "FK_CHITIETHOADONs_SANPHAMs_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SANPHAMs",
                        principalColumn: "MaSP");
                });

            migrationBuilder.CreateTable(
                name: "CHITIETNHAPs",
                columns: table => new
                {
                    MaChiTietNhap = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    MaNhaCC = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    SoLuongNhap = table.Column<int>(type: "int", nullable: false),
                    DonGiaNhap = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETNHAPs", x => x.MaChiTietNhap);
                    table.ForeignKey(
                        name: "FK_CHITIETNHAPs_NHACUNGCAPs_MaNhaCC",
                        column: x => x.MaNhaCC,
                        principalTable: "NHACUNGCAPs",
                        principalColumn: "MaNhaCC",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CHITIETNHAPs_SANPHAMs_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SANPHAMs",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETHOADONs_MaSP",
                table: "CHITIETHOADONs",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETNHAPs_MaNhaCC",
                table: "CHITIETNHAPs",
                column: "MaNhaCC");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETNHAPs_MaSP",
                table: "CHITIETNHAPs",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONs_MaKH",
                table: "HOADONs",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONs_MaNV",
                table: "HOADONs",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMs_MaKhuyenMai",
                table: "SANPHAMs",
                column: "MaKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMs_MaNV",
                table: "SANPHAMs",
                column: "MaNV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHITIETHOADONs");

            migrationBuilder.DropTable(
                name: "CHITIETNHAPs");

            migrationBuilder.DropTable(
                name: "HOADONs");

            migrationBuilder.DropTable(
                name: "NHACUNGCAPs");

            migrationBuilder.DropTable(
                name: "SANPHAMs");

            migrationBuilder.DropTable(
                name: "KHACHHANGs");

            migrationBuilder.DropTable(
                name: "KHUYENMAIs");

            migrationBuilder.DropTable(
                name: "NHANVIENs");
        }
    }
}
