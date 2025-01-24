using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebAPI.Controllers.Shared
{
    [ApiController]
    public abstract class CustomControllerBase : ControllerBase
    {
        /// <summary>
        /// Obtém o ID do usuário autenticado a partir das claims.
        /// </summary>
        /// <returns>O ID do usuário como uma string, ou null se não encontrado.</returns>
        protected string? GetUserId()
        {
            return User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }

        /// <summary>
        /// Obtém o nome do usuário autenticado a partir das claims.
        /// </summary>
        /// <returns>O nome do usuário como uma string, ou null se não encontrado.</returns>
        protected string? GetUserName()
        {
            return User?.FindFirst(ClaimTypes.Name)?.Value;
        }

        /// <summary>
        /// Obtém o e-mail do usuário autenticado a partir das claims.  
        /// </summary>
        /// <returns></returns>
        protected string? GetEmail()
        {
            return User?.FindFirst(ClaimTypes.Email)?.Value;
        }

        /// <summary>
        /// Obtém um valor customizado de uma claim específica.
        /// </summary>
        /// <param name="claimType">O tipo da claim.</param>
        /// <returns>O valor da claim como uma string, ou null se não encontrado.</returns>
        protected string? GetUserClaim(string claimType)
        {
            return User?.FindFirst(claimType)?.Value;
        }
    }
}
