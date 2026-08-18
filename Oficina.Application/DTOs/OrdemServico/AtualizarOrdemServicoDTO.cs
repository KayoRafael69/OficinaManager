namespace Oficina.Application.DTOs.OrdemServico
{
    public class AtualizarOrdemServicoDTO
    {
        public string Descricao { get; set; }
        public decimal ValorMaoDeObra { get; set; }
        public int MecanicoId { get; set; }
        // VeiculoId não entra — OS não muda de veículo depois de aberta
    }
}