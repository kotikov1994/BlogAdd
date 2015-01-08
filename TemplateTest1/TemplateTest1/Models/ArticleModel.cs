using Database.Models;
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
        private readonly PostModel post;
        private readonly ICollection<string> comments;

        public ArticleModel()
        {

            post = new PostModel(
                "This is an article title",
                "<p>Реал Сосьедад обыгрывает Барселону и поднимается с 16 на 13 строчку в Примере. Каталонцы продолжают черную серию на «Аноэта» и упускает возможность возглавить таблицу. У Реала на 1 очко больше и матч в запасе.<p>",
                DateTime.Now, 0);
            Likes = new Collection<LikeModel>();
            comments = CommentsRepository.Comments;
        }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }

         public  ICollection<LikeModel> Likes { get; set; }
        // public  ICollection<CommentItemModel> Comments { get; set; }

         public ArticleModel(PostModel post, ICollection<string> comments)
         {
             this.post = post;
             this.comments = comments;
         }

         public PostModel Post
         {
             get
             {
                 return post;
             }
         }
        public ICollection<string> Comments
         {
             get
             {
                 return comments;
             }
         }

        public AddCommentModel NewComment { get; set; }
    }
}