namespace Oficina.Domain.Entities
{
    public class Veiculo : EntidadeBase
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public ICollection<OrdemServico> OrdensServico { get; set; } = new List<OrdemServico>();
    }
}