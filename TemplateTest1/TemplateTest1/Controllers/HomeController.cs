using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateTest1.Models;
using TemplateTest1.Repository;


namespace TemplateTest1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new ArticleModel();
            return View(model);
        }

        [HttpPost]
      //  [ValidateInput(false)]
        public ActionResult Index(ArticleModel model)
        {
            if (model.NewComment != null && ModelState.IsValid)
            {
                CommentsRepository.Comments.Add(model.NewComment.Comment);
                return View(new ArticleModel());
            }
            return View(model);
        }
       
    }
}
