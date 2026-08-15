using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities
{
    public class Usuario : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public PerfilUsuario Perfil { get; set; }
    }
}