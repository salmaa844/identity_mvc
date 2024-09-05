using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace identity.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [MaxLength(40)]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required]
        [MaxLength(40)]
        [DataType(DataType.Password)]
        
        public string Passsword { get; set; }
        public bool RememberMe { get; set; }
    }
}
