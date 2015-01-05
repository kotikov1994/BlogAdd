using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateTest1.Models
{
    public class CommentItemModel
    {
        public CommentItemModel()
        {
            Username = "Ilya";
            Body = "Comment";
            Date = DateTime.Now;
        }
        public string Username { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
    }
}