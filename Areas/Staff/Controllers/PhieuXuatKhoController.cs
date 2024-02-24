using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKho.Areas.Staff.Controllers
{
    public class PhieuXuatKhoController : Controller
    {
        // GET: Staff/PhieuXuatKho
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChiTietPhieuXuatKho()
        {
            return View();
        }
        public ActionResult ThemPhieuXuatKho()
        {
            return View();
        }
        public ActionResult CapNhatPhieuXuatKho()
        {
            return View();
        }
        public ActionResult ThuHoiPhieuXuatKho()
        {
            return View();
        }
    }
}