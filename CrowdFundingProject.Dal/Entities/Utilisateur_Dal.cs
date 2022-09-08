namespace CrowdFundingProject.Dal.Entities
{
#nullable disable
    public class Utilisateur_Dal
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }
    }
}