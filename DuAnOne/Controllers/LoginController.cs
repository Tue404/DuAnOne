using DuAnOne.Data;
using DuAnOne.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DuAnOne.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LoginController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _db.KHACHHANGs
                    .Where(u => u.TenTaiKhoan == model.TenTaiKhoan && u.MatKhau == model.MatKhau)
                    .Select(u => new
                    {
                        u.TenTaiKhoan,
                        u.MatKhau
                    })
                    .SingleOrDefault();

                if (user != null)
                {
                    //cookie chứa thông tin đăng nhập
                    CookieOptions options = new CookieOptions();
                    options.Expires = DateTime.Now.AddMinutes(30);

                    HttpContext.Response.Cookies.Append("TenTaiKhoan", user.TenTaiKhoan, options);
                    HttpContext.Response.Cookies.Append("MatKhau", user.MatKhau, options);

                    //thành công
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    //thất bại
                    ModelState.AddModelError("", "Tên tài khoản hoặc mật khẩu không đúng.");
                }
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete("TenTaiKhoan");
            HttpContext.Response.Cookies.Delete("MatKhau");
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(KhachHang model)
        {
            Random random = new Random();
            int randomValue = random.Next(1000);
            string maKH = "KH" + randomValue.ToString("D3");
            if (model.HoTen != null && model.SDT != null && model.Email != null && model.TenTaiKhoan != null && model.MatKhau != null)
            {
                var newUser = new KhachHang
                {
                    MaKH = maKH,
                    HoTen = model.HoTen,
                    NgaySinh = null,
                    NoiSinh = null,
                    DiaChi = null,
                    CCCD = null,
                    SDT = model.SDT,
                    Email = model.Email,
                    TenTaiKhoan = model.TenTaiKhoan,
                    MatKhau = model.MatKhau,
                    TinhTrang = "Mở"
                };

                _db.KHACHHANGs.Add(newUser);
                _db.SaveChanges();

                return RedirectToAction("Index", "Login");
            }

            return View(model);
        }
    }
}
