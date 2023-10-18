using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyReceipeApplication.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeIngredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeInstructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeMealType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeCusineType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}
