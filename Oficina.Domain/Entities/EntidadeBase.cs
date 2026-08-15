namespace Oficina.Domain.Entities
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public DateTime? DataAtualizacao { get; set; }
    }
}