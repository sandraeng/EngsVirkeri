using System.ComponentModel.DataAnnotations;

namespace EngsVirkeri.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
