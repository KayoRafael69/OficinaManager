namespace Oficina.Application.DTOs.PecaEstoque
{
    public class PecaEstoqueDTO
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }
        public int QuantidadeEstoque { get; set; }
        public bool Ativo { get; set; }
    }
}