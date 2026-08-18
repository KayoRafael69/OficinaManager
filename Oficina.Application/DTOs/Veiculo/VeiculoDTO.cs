namespace Oficina.Application.DTOs.Veiculo
{
    public class VeiculoDTO
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public bool Ativo { get; set; }
        public int ClienteId { get; set; }
        public string ClienteNome { get; set; } // ← nome do dono sem carregar o objeto inteiro
    }
}