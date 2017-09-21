using Microsoft.AspNet.Identity;
using Blog.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Collections;

namespace Blog.Entities
{
    public class Comment
    {
        public string ID { get; set; }
        public string Content { get; set; }

        [Display(Name = "DateTime Created")]
        public DateTime DateCreated { get; set; }
        public virtual User Author { get; set; }

        public Comment()
        {

        }

        public Comment(string id, string title, string content, DateTime datecreated)
        {

        }

        public Comment(string title, string content)
        {
            this.ID = new CustomId().ToString();
            this.Content = content;
            this.DateCreated = DateTime.Now;
        }
    }
}
