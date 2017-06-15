using PasteBookBusinessLogic;
using PasteBookDataAccess;
using PasteBookEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PasteBook_v1.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<USER> myUser;
        private IRepository<POST> myPost;

        public HomeController(IRepository<USER> userRepo, IRepository<POST> postRepo)
        {
            myUser = userRepo;
            myPost = postRepo;
        }
        public HomeController() :this(new Repository<USER>(), new Repository<POST>())
        {

        }


        public ActionResult Index()
        {
            return View();
        }


        public ActionResult HomePage()
        {

        
            return View();

        }

        public JsonResult AddPost(string content)
        {
            var result = false;
            if (PostBL.CheckPost(content)) 
            result = myPost.AddEntry(new POST { POSTER_ID = 3 , CONTENT= content ,CREATED_DATE = DateTime.Today, PROFILE_OWNER_ID = 2 });

            return Json(new { result = result }, JsonRequestBehavior.AllowGet);
        }
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}
        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}