namespace LanchesMac.Models
{
    public class Categoria
    {
        public long CategoriaId { get; set; } //chave primária
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set;}
    }
}
