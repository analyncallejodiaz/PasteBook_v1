using PasteBook_v1.Models;
using PasteBookEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PasteBook_v1.Controllers
{
    public class AccountController : Controller
    {
        AccountManager manager = new AccountManager();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Login()
        {
            return PartialView("Login");
        }

        //public ActionResult Login(string returnUrl, string token = "")
        //{
        //    ViewBag.ReturnUrl = returnUrl;
        //    return RedirectToAction("Index", "Home");
        //}

        public ActionResult Register()
        {
            List<SelectListItem> years = new List<SelectListItem>();

            years.Add(new SelectListItem { Text = "", Value = "0", Selected = true });
            for (var i = DateTime.Now.Year; i > DateTime.Now.Year - 101; i--)
            {
                years.Add(new SelectListItem { Text = Convert.ToString(i), Value = Convert.ToString(i) });
            }
            ViewBag.Year = years;

            List<SelectListItem> months = new List<SelectListItem>();

            months.Add(new SelectListItem { Text = "", Value = "0", Selected = true });
            months.Add(new SelectListItem { Text = "January", Value = "1" });
            months.Add(new SelectListItem { Text = "February", Value = "2" });
            months.Add(new SelectListItem { Text = "March", Value = "3" });
            months.Add(new SelectListItem { Text = "April", Value = "4" });
            months.Add(new SelectListItem { Text = "May", Value = "5" });
            months.Add(new SelectListItem { Text = "June", Value = "6" });
            months.Add(new SelectListItem { Text = "July", Value = "7" });
            months.Add(new SelectListItem { Text = "August", Value = "8" });
            months.Add(new SelectListItem { Text = "September", Value = "9" });
            months.Add(new SelectListItem { Text = "October", Value = "10" });
            months.Add(new SelectListItem { Text = "November", Value = "11" });
            months.Add(new SelectListItem { Text = "December", Value = "12" });
            ViewBag.Month = months;

            List<SelectListItem> days = new List<SelectListItem>();

            days.Add(new SelectListItem { Text = "", Value = "0", Selected = true });
            for (var i = 1; i < 32; i++)
            {
                days.Add(new SelectListItem { Text = Convert.ToString(i), Value = Convert.ToString(i) });
            }
            ViewBag.Day = days;
            return View();
        }

        [HttpPost]
        public ActionResult Register(USER newUserModel) {

            

            manager.AddUser(newUserModel);


            return RedirectToAction("Index","Home"); 
        }

        public JsonResult LoginAccount(LoginModel accountJson) {
       
              bool accountExists = manager.LoginUser(accountJson.UserName, accountJson.Password);
              if(accountExists)
                return Json(new { accountExists = true,M = "Successful login." });
              else
                return Json(new { accountExists = false, M = "Username/Password incorrect." });
        }

    }
}