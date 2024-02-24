using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKho.Areas.Admin.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: Admin/KhachHang
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChiTietKhachHang()
        {
            return View();
        }
        public ActionResult QuanLyKhachHang()
        {
            return View();
        }
        public ActionResult ThemKhachHang()
        {
            return View();
        }
        public ActionResult CapNhatTTKhachHang()
        {
            return View();
        }
        public ActionResult AnKhachHang()
        {
            return View();
        }
    }
}