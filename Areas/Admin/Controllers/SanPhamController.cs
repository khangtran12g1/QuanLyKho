using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKho.Areas.Admin.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: Admin/SanPham
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult QuanLySanPham()
        {
            return View();
        }
        public ActionResult ChiTietSanPham()
        {
            return View();
        }
        public ActionResult ThemSanPham()
        {
            return View();
        }
        public ActionResult CapNhatTTSanPham()
        {
            return View();
        }
        public ActionResult AnSanPham()
        {
            return View();
        }
    }
}