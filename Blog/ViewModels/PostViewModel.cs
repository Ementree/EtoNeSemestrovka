using System.Collections.Generic;
using Blog.Models;

namespace Blog.ViewModels
{
  public class PostViewModel
  {
    public string Title { get; set; }
    public string Body { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public string UserId { get; set; }
  }
}