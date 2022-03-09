using System.ComponentModel.DataAnnotations;

namespace EngsVirkeri.Models
{
    public class RegisterViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Lösenord")]
        public string Password { get; set; }
        [Required, 
            DataType(DataType.Password), 
            Display(Name ="Återupprepa lösenord"), 
            Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
