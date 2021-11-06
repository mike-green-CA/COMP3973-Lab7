using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP3973_lab4_A01045801_Michael_Green.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    ProvinceName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Population = table.Column<int>(type: "INTEGER", maxLength: 8, nullable: false),
                    ProvinceCode = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceCode",
                        column: x => x.ProvinceCode,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "BC", "British Columbia" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "AB", "Alberta" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "SK", "Saskatchewan" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 1, "Vancouver", 500000, "BC" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 2, "Victoria", 300000, "BC" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 3, "Port Coquitlam", 80000, "BC" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 4, "Calgary", 700000, "AB" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 5, "Edmonton", 800000, "AB" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 6, "Banff", 50000, "AB" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 7, "Moose Jaw", 50000, "SK" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 8, "Regina", 400000, "SK" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 9, "Saskatoon", 350000, "SK" });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceCode",
                table: "Cities",
                column: "ProvinceCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
