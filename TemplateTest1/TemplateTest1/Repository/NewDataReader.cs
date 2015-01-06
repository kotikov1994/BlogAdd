using Database.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TemplateTest1.Models;


namespace TemplateTest1.Repository
{
    public class NewDataReader
    {
        public ArticleModel GetArticleModel(string title)
        {
            PostModel postModel = null;
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["mssql"].ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(String.Format("SELECT * FROM Post WHERE Title = '{0}'", title)))
                {
                    command.Connection = connection;
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            postModel = new PostModel(reader["Title"].ToString(), reader["Body"].ToString(), DateTime.Parse(reader["DateCreated"].ToString()));
                        }

                    }
                }
            }
            return new ArticleModel(postModel, null);
        }
    }
}