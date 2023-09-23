using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Servicios.api.Seguridad.Core.JwtLogic
{
    public class UsuarioSesion : IUsuarioSesion
    {
        private IHttpContextAccessor _httpContextAccessor;

        public UsuarioSesion(IHttpContextAccessor httpContextAccessor) {
            _httpContextAccessor = httpContextAccessor;
        }


        public string GetUsuarioSesion()
        {
            var userName = _httpContextAccessor.HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == "username")?.Value;
            return userName;
        }
    }
}
