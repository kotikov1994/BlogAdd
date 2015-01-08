using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplateTest1.Repository.Domain
{
    public class Comment 
    {
       public int CommentID { get; set; }

       public int PostID { get; set; }

       public Post Post { get; set; }

       public string Body { get; set; }
    }
}
