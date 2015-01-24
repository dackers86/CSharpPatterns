using MvcExample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMvcExample.Controllers
{
    public class HomeController : Controller
    {
        private IGetExamples _getService;

        public HomeController(IGetExamples getExamples)
        {
            _getService = getExamples;
        }

        public ActionResult Index()
        {
            var result = _getService.Get();
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
    }
}