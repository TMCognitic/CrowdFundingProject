using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrowdFunding.Tools.Database;
using CrowdFundingProject.Dal.Entities;

namespace CrowdFundingProject.Dal.Services
{
    public class AuthService_Dal
    {
        private readonly DbConnection _connection;

        public AuthService_Dal(DbConnection connection)
        {
            _connection = connection;
        }

        public void AjoutUtilisateur(Utilisateur_Dal entity)
        {
            _connection.ExecuteNonQuery("CSP_AjoutUtilisateur", true, new { entity.Nom, entity.Prenom, entity.Email, entity.Passwd });
        }

        //public void ConnexionUtilisateur(string email, string passwd)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
