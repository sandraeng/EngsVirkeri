using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EngsVirkeri.Models
{
    public class RegisterViewModel
    {
        [Required, EmailAddress, Remote(action:"IsEmailInUse", controller:"Account")]
        public string Email { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Lösenord")]
        public string Password { get; set; }
        [Required, 
            DataType(DataType.Password), 
            Display(Name ="Upprepa lösenord"), 
            Compare("Password", ErrorMessage = "Lösenorden matchar inte")]
        public string ConfirmPassword { get; set; }
        [Required, Display(Name = "Förnamn")]
        public string FirstName{ get; set; }
        [Required, Display(Name = "Efternamn")]
        public string LastName { get; set; }
        [Required, Display(Name = "Stad")]
        public string City { get; set; }
    }
}
