namespace Oficina.Application.DTOs.OrdemServico
{
    public class CriarOrdemServicoDTO
    {
        public int VeiculoId { get; set; }
        public int MecanicoId { get; set; }
        public string Descricao { get; set; }
        public decimal ValorMaoDeObra { get; set; }
    }
}