using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitDemo2.Controllers
{
    public class NhapHangController : Controller
    {
        // GET: NhapHang
        public ActionResult Index()
        {
            return View();
        }

        //GET: Hien thi hang chua thanh toan
        public ActionResult HangChuaThanhToan()
        {
            ViewBag.Message = "Hàng Chưa Thanh Toán";
            return View();
        }
    }
}