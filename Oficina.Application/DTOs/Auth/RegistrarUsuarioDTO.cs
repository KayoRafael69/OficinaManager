using Oficina.Domain.Enums;

namespace Oficina.Application.DTOs.Auth
{
    public class RegistrarUsuarioDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public PerfilUsuario Perfil { get; set; }
    }
}