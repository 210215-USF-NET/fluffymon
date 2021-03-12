using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FMMVC.Models
{
    public class CreateUserViewModel
    {
        [DisplayName("Username")]
        [Required]
        public string UserName { get; set; }
    }
}
