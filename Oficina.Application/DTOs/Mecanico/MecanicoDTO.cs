using Oficina.Domain.Enums;

namespace Oficina.Application.DTOs.Mecanico
{
    public class MecanicoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public EspecialidadeMecanico Especialidade { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}