using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(Nome,DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl," +
                "IsLanchePreferido,EmEstoque, CategoriaId) VALUES" +
                "('Brutão', 'Especial da nossa lanchonete', 'pão, alface, tomate,hamburger, queijo grelhado e ovo.', 19.99, NULL, NULL," +
                "1, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Lanches(Nome,DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl," +
                "IsLanchePreferido,EmEstoque, CategoriaId) VALUES" +
                "('Hot Dog', 'Hot Dog básico', 'pão e salsicha.', 9.99, NULL, NULL," +
                "0, 1, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
