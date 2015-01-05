using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace TemplateTest1.Models
{
    public class RecentDateModel
    {
        public RecentDateModel()
        {
            Items = new Collection<RecentDataItemModel>();
            Items.Add(new RecentDataItemModel());
            Items.Add(new RecentDataItemModel());
            Items.Add(new RecentDataItemModel());
        }

        public ICollection<RecentDataItemModel> Items { get; set; }
    }
}