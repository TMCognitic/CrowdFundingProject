using CrowdFundingProject.Bll.Entities;
using CrowdFundingProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingProject.Bll.Mappers
{
    public static partial class Mappers
    {
        public static Utilisateur_Dal ToDal(this Utilisateur_Bll entity)
        {
            return new Utilisateur_Dal() { Id = entity.Id, Nom = entity.Nom, Prenom = entity.Prenom, Email = entity.Email, Passwd = entity.Passwd };
        }
    }
}
