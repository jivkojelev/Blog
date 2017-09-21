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
        [Required]
        [StringLength(100)]
        [MinLength(5)]
        public string Title { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(1000)]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [Display(Name = "DateTime Created")]
        public DateTime DateCreated { get; set; }

        //public virtual Comment Comments { get; set; }
        //[DataType(DataType.MultilineText)]
        //public virtual ICollection<Comment> Comments { get; set; }


        // [Display(Name = "Author")]
        // public virtual string Author { get; set; }
        // public ICollection<Comment> Comments { get; set; }

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
