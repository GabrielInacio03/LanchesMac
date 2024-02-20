using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "Informe o nome do lanche")]
        [Display(Name = "Nome")]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição curta do lanche")]
        [Display(Name = "Descrição Curta")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Informe a descrição detalhada do lanche")]
        [Display(Name = "Descrição Detalhada")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 99.99, ErrorMessage = "O preço deve estar entre 1 e 99.99")]
        public decimal Preco { get; set; }

        [Display(Name = "Imagem URL")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido ?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId {  get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
