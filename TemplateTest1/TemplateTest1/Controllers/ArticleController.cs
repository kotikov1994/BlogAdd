using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplateTest1.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/

        public ActionResult Recent()
        {
            var model = new TemplateTest1.Models.RecentDateModel();
            return View(model);
        }
        }

   }

