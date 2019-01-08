using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class intereststableadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InterestsTableAccess",
                columns: table => new
                {
                    OwnerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GetOutdoorsAndAdventure = table.Column<int>(nullable: false),
                    Sports = table.Column<int>(nullable: false),
                    Fitness = table.Column<int>(nullable: false),
                    FoodAndDrink = table.Column<int>(nullable: false),
                    Gaming = table.Column<int>(nullable: false),
                    Media = table.Column<int>(nullable: false),
                    Social = table.Column<int>(nullable: false),
                    Craft = table.Column<int>(nullable: false),
                    Services = table.Column<int>(nullable: false),
                    Culture = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestsTableAccess", x => x.OwnerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterestsTableAccess");
        }
    }
}
