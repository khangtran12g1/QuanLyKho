using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKho.Areas.Admin.Controllers
{
    public class PhieuXuatKhoController : Controller
    {
        // GET: Admin/PhieuXuat
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult QuanLyPhieuXuatKho()
        {
            return View();
        }
        public ActionResult ChiTietPhieuXuatKho()
        {
            return View();
        }
        public ActionResult XemLichSu()
        {
            return View();
        }
        public ActionResult DuyetPhieuXuatKho()
        {
            return View();
        }
        public ActionResult TuChoiPhieuXuatKho()
        {
            return View();
        }
    }
}