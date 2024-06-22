
namespace LanchesMac.Models
{
    public class Lanche
    {
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public double Preco { get; private set; }
        public bool Ativo { get; private set; }

        public Lanche(){}
        public Lanche(long id, string nome, string descricao, double preco, bool ativo)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            Preco = preco;
            Ativo = ativo;
        }
    }
}
