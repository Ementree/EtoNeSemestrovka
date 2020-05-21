namespace Blog.ViewModels
{
  public class CommentViewModel
  {
    public string Body { get; set; }
    public int Rating { get; set; }
    public string UserId {get;set;}
    public int PostId { get; set; }
  }
}