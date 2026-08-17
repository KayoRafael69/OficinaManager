using Oficina.Domain.Enums;

namespace Oficina.Domain.Entities
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public string NumeroOrdem { get; set; }
        public DateTime DataAbertura { get; set; } = DateTime.UtcNow;
        public DateTime? DataConclusao { get; set; }
        public StatusOrdemServico Status { get; set; }
        public string Descricao { get; set; }

        public decimal ValorMaoDeObra { get; set; }

        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }

        public int MecanicoId { get; set; }
        public Mecanico Mecanico { get; set; }

        public List<PecaOrdemServico> Pecas { get; set; } = new List<PecaOrdemServico>();

        public decimal ValorPecas => Pecas.Sum(p => p.ValorTotal);
        public decimal ValorTotal => ValorMaoDeObra + ValorPecas;
    }
}