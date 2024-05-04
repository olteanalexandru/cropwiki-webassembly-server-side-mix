using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CropWIKImvc.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CropName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CropType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CropVariety = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlantingPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HarvestingPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoilType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Climate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItShouldNotBeRepeatedForHowmanyYearsOnSameField = table.Column<int>(type: "int", nullable: false),
                    Fertilizers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pests = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diseases = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NitrogenSupply = table.Column<int>(type: "int", nullable: false),
                    NitrogenDemand = table.Column<int>(type: "int", nullable: false),
                    SoilResidualNitrogen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crops", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crops");
        }
    }
}
