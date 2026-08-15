namespace Oficina.Domain.Entities
{
    public class PecaOrdemServico
    {
        public int Id { get; set; }

        public int OrdemServicoId { get; set; }
        public OrdemServico OrdemServico { get; set; }

        public int PecaId { get; set; }
        public PecaEstoque Peca { get; set; }

        // Detalhes da utilizacao
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; } // Salva o valor do momento da venda

        public decimal ValorTotal => Quantidade * ValorUnitario;
    }
}