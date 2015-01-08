using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TemplateTest1.Models;
using TemplateTest1.Repository.Domain;
using TemplateTest1.Repository;
using System.Collections.ObjectModel;
using Database.Models;


namespace TemplateTest1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(string title)
        {

            if (title == null)
            {
                title = "This is my first title";
            }
            using (var ctx = new EFContext())
            {
                var post = ctx.Posts.Where(p => p.Title == title).FirstOrDefault();
                var postModel = new PostModel(post.Title, post.Body, post.DateCreated, post.Comments.Count());
                var commentModel = new Collection<string>();
                if (post.Comments != null && post.Comments.Any())
                {
                    foreach (var item in post.Comments)
                    {
                        commentModel.Add(item.Body);
                    }
                }

                return View(new ArticleModel(postModel, commentModel));
            }

        }

        [HttpPost]
      //  [ValidateInput(false)]
        public ActionResult Index(ArticleModel model)
        {
            var title = "This is my first title";

            if (model.NewComment != null && ModelState.IsValid)
            {
                using (var ctx = new EFContext())
                {
                    var post = ctx.Posts.Where(p => p.Title == title).FirstOrDefault();
                    if (post != null)
                    {
                        ctx.Comments.Add(new Comment() { Body = model.NewComment.Comment, PostID = post.PostID });
                        ctx.SaveChanges();
                    }
                }
                //var readers = new DataReaders();
                //readers.AddComment(title, model.NewComment.Comment);
                ModelState.Clear();
                return RedirectToAction("Index", new { title = title });
            }
            return View(model);
        }

        public ActionResult AllPosts()
        {
            var model = new PostsCollectionModel();
            return View(model);
        }

    }
}
