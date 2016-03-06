using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
            var result = "no data";
            try
            {
                
                using (var context = new azure_db())
                {
                    // Perform data access using the context 
                    result = string.Join(",", context.Users.ToList().Select(user => user.UserId.ToString()));
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your about page.";

            return View();
        }
    }
}