using Oficina.Domain.Enums;

namespace Oficina.Application.DTOs.OrdemServico
{
    public class OrdemServicoDTO
    {
        public int Id { get; set; }
        public string NumeroOrdem { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataConclusao { get; set; }
        public StatusOrdemServico Status { get; set; }
        public string Descricao { get; set; }
        public decimal ValorMaoDeObra { get; set; }

        // Dados do veiculo (sem carregar objeto inteiro)
        public int VeiculoId { get; set; }
        public string VeiculoPlaca { get; set; }
        public string VeiculoModelo { get; set; }

        // Dados do mecanico (sem carregar objeto inteiro)
        public int MecanicoId { get; set; }
        public string MecanicoNome { get; set; }

        // Itens da OS
        public List<PecaOrdemServicoDTO> Pecas { get; set; } = new();

        // Calculados
        public decimal ValorPecas { get; set; }
        public decimal ValorTotal { get; set; }
    }

    public class PecaOrdemServicoDTO
    {
        public int PecaId { get; set; }
        public string PecaNome { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
    }
}