using System.ComponentModel.DataAnnotations;


namespace Blog.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
