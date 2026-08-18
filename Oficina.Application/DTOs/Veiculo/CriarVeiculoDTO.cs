namespace Oficina.Application.DTOs.Veiculo
{
    public class CriarVeiculoDTO
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public int ClienteId { get; set; }
    }
}