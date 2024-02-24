using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKho.Areas.Admin.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: Admin/NhanVien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult QuanLyNhanVien()
        {
            return View();
        }
        public ActionResult ChiTietNhanVien()
        {
            return View();
        }
        public ActionResult ThemNhanVien()
        {
            return View();
        }
        public ActionResult CapNhatTTNhanVien()
        {
            return View();
        }
        public ActionResult XoaNhanVien()
        {
            return View();
        }
    }
}