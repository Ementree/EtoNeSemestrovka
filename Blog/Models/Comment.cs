using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Body { get; set; }
        public int Rating { get; set; }
        public DateTime TimeStamp { get; set; }
        public string UserId {get;set;}
        public ApplicationUser ApplicationUser { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
