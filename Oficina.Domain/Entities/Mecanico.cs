using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities
{
    public class Mecanico : EntidadeBase
    {
        public string Nome { get; set; }
        public EspecialidadeMecanico Especialidade { get; set; }
        public ICollection<OrdemServico> OrdensServico { get; set; } = new List<OrdemServico>();
    }
}