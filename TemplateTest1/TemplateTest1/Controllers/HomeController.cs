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

        //public ActionResult Index()
        //{
        //    var model = new ArticleModel();
        //    return View( model);
        //}

        public ActionResult Index1()
        {
            var model = new ArticleModel();
            return View(model);
        }

       
        //public ActionResult AddComment(AddCommentModel model)
        //{
        //    return RedirectToAction("index", "home");
        //}

        [HttpGet]
        public ActionResult Index()
        {
            string query = Request.QueryString["Foo"];
            var model = new ArticleModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(AddCommentModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.Comment))
            {
                TemplateTest1.Repository.CommentsRepository.Comments.Add(model.Comment);
            }            
            return View(new ArticleModel());
        }
       
    }
}
