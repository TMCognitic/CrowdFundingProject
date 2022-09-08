using CrowdFundingProject.Bll.Entities;
using CrowdFundingProject.Bll.Mappers;
using CrowdFundingProject.Dal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingProject.Bll.Services
{
    public class AuthService_Bll
    {
        private readonly AuthService_Dal _authService;

        public AuthService_Bll(AuthService_Dal authService)
        {
            _authService = authService;
        }

        public void AjoutUtilisateur(Utilisateur_Bll entity)
        {
            _authService.AjoutUtilisateur(entity.ToDal());
        }
    }
}
