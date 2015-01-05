using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateTest1.Models;

namespace TemplateTest1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new ArticleModel();
            return View( model);
        }
        public ActionResult Index1()
        {
            var model = new ArticleModel();
            return View(model);
        }
        public ActionResult Index2()
        {
            var model = new ArticleModel();
            return View(model);
        }
        public ActionResult Index3()
        {
            var model = new ArticleModel();
            return View(model);
        }
        public ActionResult Index4()
        {
            var model = new ArticleModel();
            return View(model);
        }
        public ActionResult Index5()
        {
            var model = new ArticleModel();
            return View(model);
        }
    }
}
