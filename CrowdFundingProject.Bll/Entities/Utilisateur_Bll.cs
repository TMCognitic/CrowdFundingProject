namespace CrowdFundingProject.Bll.Entities
{
    public class Utilisateur_Bll
    {
        public int Id { get; init; }
        public string Nom { get; init; }
        public string Prenom { get; init; }
        public string Email { get; init; }
        public string? Passwd { get; set; }

        //internal Utilisateur_Bll(int id, string nom, string prenom, string email)
        //    : this (nom, prenom, email, null)
        //{
        //    Id = id;
        //}

        public Utilisateur_Bll(string nom, string prenom, string email, string? passwd)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Passwd = passwd;
        }
    }
}