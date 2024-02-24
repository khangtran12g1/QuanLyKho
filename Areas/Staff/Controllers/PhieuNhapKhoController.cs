using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKho.Areas.Staff.Controllers
{
    public class PhieuNhapKhoController : Controller
    {
        // GET: Staff/PhieuNhapKho
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChiTietPhieuNhapKho()
        {
            return View();
        }
        public ActionResult ThemPhieuNhapKho()
        {
            return View();
        }
        public ActionResult CapNhatPhieuNhapKho()
        {
            return View();
        }
        public ActionResult ThuHoiPhieuNhapKho()
        {
            return View();
        }
    }
}