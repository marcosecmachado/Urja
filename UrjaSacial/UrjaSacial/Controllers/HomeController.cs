using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrjaSacial.Models;

namespace UrjaSacial.Controllers
{
    public class HomeController : Controller
    {
        private UrjaSacialContext db = new UrjaSacialContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult GetDados()
        {
            List<Produto> produtos = new List<Produto>();
            produtos = db.Produtoes.ToList();
            return Json(produtos, JsonRequestBehavior.AllowGet);
        }

    }
}