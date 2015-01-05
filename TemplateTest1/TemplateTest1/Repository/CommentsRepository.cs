using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplateTest1.Repository
{
    public static class CommentsRepository 
    {
        public static readonly ICollection<string> Comments = new Collection<string>();
    }
}
