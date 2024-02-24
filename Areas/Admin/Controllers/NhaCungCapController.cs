using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKho.Areas.Admin.Controllers
{
    public class NhaCungCapController : Controller
    {
        // GET: Admin/NhaCungCap
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult QuanLyNhaCungCap()
        {
            return View();
        }
        public ActionResult ChiTietNhaCungCap()
        {
            return View();
        }
        public ActionResult ThemNhaCungCap()
        {
            return View();
        }
        public ActionResult CapNhatTTNhaCungCap()
        {
            return View();
        }
        public ActionResult AnNhaCungCap()
        {
            return View();
        }
    }
}