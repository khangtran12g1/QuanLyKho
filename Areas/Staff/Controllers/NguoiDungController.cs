using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKho.Areas.Staff.Controllers
{
    public class NguoiDungController : Controller
    {
        // GET: Staff/NguoiDung
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            return RedirectToAction("TrangChu", "TrangChu", new { area = "Staff" });
        }
        public ActionResult DangXuat()
        {
            return RedirectToAction("Index", "Home", new { area = "" });
        }
        public ActionResult ThongTinCaNhan()
        {
            return View();
        }
        public ActionResult CapNhatThongTinCaNhan()
        {
            return View();
        }
        public ActionResult DoiMatKhau()
        {
            return View();
        }
        public ActionResult QuenMatKhau()
        {
            return View();
        }

    }
}