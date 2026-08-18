namespace Oficina.Application.DTOs.PecaEstoque
{
    public class AtualizarPecaEstoqueDTO
    {
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}