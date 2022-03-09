﻿using System.ComponentModel.DataAnnotations;

namespace EngsVirkeri.Models
{
    public class LoginViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Lösenord")]
        public string Password { get; set; }
        [Display(Name = "Kom ihåg mig")]
        public bool RememberMe { get; set; }
    }
}
