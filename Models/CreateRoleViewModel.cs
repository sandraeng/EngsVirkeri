using System.ComponentModel.DataAnnotations;

namespace EngsVirkeri.Models
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
