namespace Oficina.Domain.Entities
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
    }
}