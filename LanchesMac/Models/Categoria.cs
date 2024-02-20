using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; } //chave primária

        [Required(ErrorMessage = "Informe o nome da categoria")]
        [Display(Name = "Nome")]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição")]
        [StringLength(200, MinimumLength = 100, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set;}
    }
}
