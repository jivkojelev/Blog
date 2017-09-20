using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Blog.Gateway.Models
{
    public class PostsViewModel
    {
        public class PostViewModelCreate
        {
            [Required]
            [StringLength(100)]
            public string Title { get; set; }

            [Required]
            [DataType(DataType.MultilineText)]
            public string Content { get; set; }

        }
    }
}