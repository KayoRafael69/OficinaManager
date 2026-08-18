using Oficina.Domain.Enums;

namespace Oficina.Application.DTOs.Mecanico
{
    public class AtualizarMecanicoDTO
    {
        public string Nome { get; set; }
        public EspecialidadeMecanico Especialidade { get; set; }
    }
}