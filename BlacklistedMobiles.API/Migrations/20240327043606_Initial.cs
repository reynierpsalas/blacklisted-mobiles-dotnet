using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlacklistedMobiles.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trademarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trademarks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ProvinceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipalities_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1064bae6-4902-4bf6-9431-1a7e1726e19d"), "07", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5521), null, "Villa Clara" },
                    { new Guid("290ce103-1278-4fc4-b724-7d6c0ff12254"), "06", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5518), null, "Cienfuegos" },
                    { new Guid("3455b71f-6e0b-4416-841d-56c1745529dc"), "15", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5550), null, "Guantánamo" },
                    { new Guid("4d3ec422-6b51-4b6f-9adc-7153f768c080"), "05", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5511), null, "Matanzas" },
                    { new Guid("5f39e8e2-6ee0-468d-b0a2-48c57b36b4c3"), "01", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5492), null, "Pinar del Río" },
                    { new Guid("70d2370c-e3af-4158-b3d7-2e47fd621565"), "02", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5501), null, "La Habana" },
                    { new Guid("75362065-425e-40f9-b5ba-c180ffa989c9"), "10", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5533), null, "Camagüey" },
                    { new Guid("7fa460f3-1aae-40ad-9fb5-b53251a83040"), "08", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5525), null, "Sancti Spíritus" },
                    { new Guid("9e9779e6-680e-4588-ae57-b21778f4ca09"), "11", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5536), null, "Las Tunas" },
                    { new Guid("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c"), "12", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5539), null, "Holguín" },
                    { new Guid("b0950c26-c31f-4d91-84d7-36ad77701d4e"), "03", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5504), null, "Artemisa" },
                    { new Guid("d65aedf0-454f-477e-922c-60531a2035d3"), "04", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5508), null, "Mayabeque" },
                    { new Guid("e183277f-03e4-4248-be3f-318e89eb77fa"), "14", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5546), null, "Santiago de Cuba" },
                    { new Guid("f5c7be86-963a-4a02-a79f-49b925be6c00"), "09", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5528), null, "Ciego de Ávila" },
                    { new Guid("fc7926b0-fc85-4e52-96b8-87590d1efba9"), "13", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5543), null, "Granma" }
                });

            migrationBuilder.InsertData(
                table: "Trademarks",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("42d0384a-cc80-4b54-9ecc-dc2a6244f9da"), new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5256), null, "Samsung" },
                    { new Guid("45eac17f-f06d-4235-a1fa-74164a015a67"), new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5345), null, "Xiaomi" },
                    { new Guid("649cfe5e-2c2c-4976-ae8b-7f938acc2207"), new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5336), null, "Huawei" },
                    { new Guid("9a8db676-d198-43ad-b963-6e50dea2dfdd"), new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5342), null, "LG" }
                });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedAt", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { new Guid("15747a09-bfed-4449-8f90-44dc56d63fa6"), "1201", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5597), null, "Calixto García", new Guid("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c") },
                    { new Guid("22f3dd42-0337-46fe-b40e-39481ed6b9e9"), "1205", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5619), null, "Moa", new Guid("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c") },
                    { new Guid("5b174629-51d9-4ce0-9627-810bf332ba7a"), "1202", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5605), null, "Gibara", new Guid("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c") },
                    { new Guid("98c4aa76-66a0-4a47-882c-3f08ba50ecb2"), "1204", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5615), null, "Rafael Freyre", new Guid("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c") },
                    { new Guid("a62128fb-bbe1-477f-b3d7-c2dd91579ca4"), "1206", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5624), null, "Holguín", new Guid("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c") },
                    { new Guid("b7f763f8-d085-4f2f-a785-b212e5fd8896"), "1203", new DateTime(2024, 3, 27, 0, 36, 5, 486, DateTimeKind.Local).AddTicks(5610), null, "Banes", new Guid("a5fcb845-c248-4a3f-a796-5d7d1a6b9d2c") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Municipalities_ProvinceId",
                table: "Municipalities",
                column: "ProvinceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "Trademarks");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
