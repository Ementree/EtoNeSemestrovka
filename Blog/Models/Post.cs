using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int Rating { get; set; }
        public DateTime TimeStamp { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public File File { get; set; }
    }
}
