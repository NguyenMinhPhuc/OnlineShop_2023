using OnlineShop.Model.DAO;
using OnlineShop.Web.Areas.Admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineShop.Web.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(TaiKhoanModel taiKhoanModel)
        {
            if (Membership.ValidateUser(taiKhoanModel.TaiKhoan, taiKhoanModel.MatKhau) && ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(taiKhoanModel.TaiKhoan, true);
                return RedirectToAction("Index", "Home", new { Area = "Admin" });
            }
            else
            {
                ModelState.AddModelError("", "Khong trung user ");
            }
            return View(taiKhoanModel);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home", new { Area = "Admin" });
        }

    }
}