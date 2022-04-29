using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EngsVirkeri.ViewModels
{
    public class EditRoleViewModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Rollnamn får inte vara tom")]
        public string RoleName { get; set; }
        public List<string> Users { get; set; }

        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
    }
}
