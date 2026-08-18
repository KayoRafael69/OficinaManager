namespace Oficina.Application.DTOs.PecaEstoque
{
    public class CriarPecaEstoqueDTO
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}