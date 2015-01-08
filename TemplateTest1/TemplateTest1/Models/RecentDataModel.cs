using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using TemplateTest1.Repository;

namespace TemplateTest1.Models
{
    public class RecentDateModel
    {
        public RecentDateModel()
        {
            Items = new Collection<RecentDataItemModel>();
            for (int i = 0; i < 3; i++)
            {
                using (var ctx = new EFContext())
                {
                    var post = ctx.Posts.FirstOrDefault();
                    //post = ctx.Posts.Where(p => p.PostID == i).FirstOrDefault;
                    var postModel = new RecentDataItemModel(post.Title, post.PostID, post.DateCreated);
                    Items.Add(postModel);
                }
            }          
        }

        public ICollection<RecentDataItemModel> Items { get; set; }
    }
}