using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels
{
  // Required for model binding to controller's action method from view 
  public class RegisterViewModel
  {
    [Required, Display(Name = "Email")]
    public string Email { get; set; }
    
    [Required, MaxLength(256)]
    public string Username { get; set; }
    
    [Required, DataType(DataType.Password)] 
    public string Password { get; set; }
    
    [Required, DataType(DataType.Password), Compare(nameof(Password))] 
    public string ConfirmPassword { get; set; } 
  }
}