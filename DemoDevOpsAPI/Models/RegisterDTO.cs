using DemoDevOpsAPI.Validators;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipelines;

namespace DemoDevOpsAPI.Models
{
    public class RegisterDTO
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [MinLength(8)]
        [MaxLength(64)]
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$")]
        public string Password { get; set; }


        [Required]
        [Compare("Password", ErrorMessage = "S'agirait de te relire... Gros naze")]
        public string PasswordConfirmation { get; set; }

        [Required]
        [Age(13, ErrorMessage = "Custom message d'erreur")]
        public DateTime Birthdate { get; set; }

        [MinLength(2)]
        public string? Firstname { get; set; }

        [MinLength(2)]
        public string? Lastname { get; set; }

        [Range(999, 10000)]
        public int PostalCode { get; set; }

    }
}
