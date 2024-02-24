using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKho.Areas.Admin.Controllers
{
    public class TrangChuController : Controller
    {
        // GET: Admin/TrangChu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult QuanLyTKAdmin()
        {
            return View();
        }
        public ActionResult ThemTKAdmin()
        {
            return View();
        }
        public ActionResult XoaTKAdmin()
        {
            return View();
        }
    }
}