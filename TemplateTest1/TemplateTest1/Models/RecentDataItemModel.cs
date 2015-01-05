using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateTest1.Models
{
    public class RecentDataItemModel
    {
        public RecentDataItemModel()
        {
            text = "Some recent data text";
            URL = "http://eurosport.ru";
            Date = DateTime.Now.AddDays(-1);
        }

        public string text { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }
    }
}