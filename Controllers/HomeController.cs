using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKho.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TrangChu()
        {
            return View();
        }
        public ActionResult QuanLyPhieuXuatKho()
        {
            return View();
        }
        public ActionResult QuanLyPhieuNhapKho()
        {
            return View();
        }


    }
}