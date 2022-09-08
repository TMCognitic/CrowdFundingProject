using System.ComponentModel.DataAnnotations;

namespace CrowdFundingProject.Api.Models.Forms
{
#nullable disable
    public class AjoutUtilisateurForm
    {
        [Required]
        [MinLength(1)]
        [MaxLength(75)]
        public string Nom { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(75)]
        public string Prenom { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(384)]
        public string Email { get; set; }
        [Required]
        //[RegularExpression("Expression pour le mot de passe")]
        [MaxLength(20)]
        public string Passwd { get; set; }
    }
}
