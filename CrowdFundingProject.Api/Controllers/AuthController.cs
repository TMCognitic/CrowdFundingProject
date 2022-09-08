using CrowdFunding.Tools.Database;
using CrowdFundingProject.Api.Models.Forms;
using CrowdFundingProject.Bll.Services;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

namespace CrowdFundingProject.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly AuthService_Bll _authService;

        public AuthController(ILogger<AuthController> logger, AuthService_Bll authService)
        {
            _logger = logger;
            _authService = authService;
        }

        [HttpPost]
        public IActionResult AjoutUtilisateur([FromBody] AjoutUtilisateurForm form)
        {
            _logger.LogInformation("Nouvel Enregistrement demandé");

            try
            {
                _authService.AjoutUtilisateur(new Bll.Entities.Utilisateur_Bll(form.Nom, form.Prenom, form.Email, form.Passwd));
                return NoContent();
            }
            catch (Exception ex)
            {
#if DEBUG
                return BadRequest(new { Message = ex.Message });
#else
                return BadRequest(new { Message = "Quelque chose n'a pas fonctionné lors de l'enregistrement... Contactez l'administrateur du site" });
#endif

            }
        }

    }
}
