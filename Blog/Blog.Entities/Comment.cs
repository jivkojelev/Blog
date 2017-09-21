using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public class Comment
    {
        public string Id { get; set; }
        public string Contents { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual Post PostId { get; set; }
        public virtual Comment Comments { get; set; }
    }
}
