using Microsoft.AspNet.Identity;
using Blog.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Blog.Entities
{
    public class Post
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [Display(Name="DateTime Created")]
        public DateTime DateCreated { get; set; }
//        public virtual User Author { get; set; }

        public Post()
        {

        }

        public Post(string id, string title, string content, DateTime datecreated)
        {

        }

        public Post(string title, string content)
        {
            this.ID = new CustomId().ToString();
            this.Title = title;
            this.Content = content;
            this.DateCreated = DateTime.Now;
        }
    }
}
