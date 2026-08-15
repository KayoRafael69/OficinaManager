namespace Oficina.Domain.Entities
{
    public class PecaEstoque : EntidadeBase
    {
        public string Codigo { get; set; } 
        public string Nome { get; set; } 
        public decimal ValorUnitario { get; set; }
        public int QuantidadeEstoque { get; set; }
        public ICollection<PecaOrdemServico> PecasOrdemServicos { get; set; } = new List<PecaOrdemServico>();
    }
}