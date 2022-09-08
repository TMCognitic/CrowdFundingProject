using CrowdFunding.Tools.Database;
using CrowdFundingProject.Api.Models.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

namespace CrowdFundingProject.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly DbConnection _connection;

        public AuthController(ILogger<AuthController> logger, DbConnection connection)
        {
            _logger = logger;
            _connection = connection;
        }

        [HttpPost]
        public IActionResult AjoutUtilisateur([FromBody] AjoutUtilisateurForm form)
        {
            _logger.LogInformation("Nouvel Enregistrement demandé");

            try
            {
                _connection.ExecuteNonQuery("CSP_AjoutUtilisateur", true, new { Nom = form.Nom, Prenom = form.Prenom, Email = form.Email, Passwd = form.Passwd });
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
