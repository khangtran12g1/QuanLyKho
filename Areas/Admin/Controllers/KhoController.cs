using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKho.Areas.Admin.Controllers
{
    public class KhoController : Controller
    {
        // GET: Admin/Kho
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult QuanLyKho()
        {
            return View();
        }
        public ActionResult ChiTietKho()
        {
            return View();
        }
        public ActionResult ThemKho()
        {
            return View();
        }
        public ActionResult CapNhatTTKho()
        {
            return View();
        }
        public ActionResult AnKho()
        {
            return View();
        }
    }
}