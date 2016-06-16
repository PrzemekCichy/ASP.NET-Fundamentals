using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cusine
        //[Authorize]
        [LogAttribute]
        public ActionResult Search(string name = "No value parameter entered :(")
        {
            throw new HttpException(404, "Something terrible has happened :(!");
            var message = Server.HtmlEncode(name);
            //return Json(new { Message = message, Name = "Scott" }, JsonRequestBehavior.AllowGet);
            //return File(Server.MapPath("~/Content/site.css"), "text/css");

            //return RedirectToRoute("Default", new { controller = "Home", action = "About" });
            //return RedirectToAction("Index", "Home", new { name = name });
            return Content(message);
        }
    }
}