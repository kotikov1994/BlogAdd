using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using TemplateTest1.Repository;

namespace TemplateTest1.Models
{
    public class ArticleModel
    {
        public ArticleModel()
        {
            Title = "this is an article title";
            Body = "<p>Реал Сосьедад обыгрывает Барселону и поднимается с 16 на 13 строчку в Примере. Каталонцы продолжают черную серию на «Аноэта» и упускает возможность возглавить таблицу. У Реала на 1 очко больше и матч в запасе.<p>";
            Date = DateTime.Now;
            Likes = new Collection<LikeModel>();
        }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }

         public  ICollection<LikeModel> Likes { get; set; }
        // public  ICollection<CommentItemModel> Comments { get; set; }
    
        public ICollection<string> Comments
         {
             get
             {
                 return CommentsRepository.Comments;
             }
         }

        public AddCommentModel NewComment { get; set; }
    }
}