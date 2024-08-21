using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevOpsChallenge.SalesApi.Database.Migrations
{
    public partial class InitialSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            // Add an index on the TransactionId column
            migrationBuilder.CreateIndex(
                name: "IX_Sale_TransactionId",
                table: "Sale",
                column: "TransactionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the index if it exists
            migrationBuilder.DropIndex(
                name: "IX_Sale_TransactionId",
                table: "Sale");
                
            migrationBuilder.DropTable(
                name: "Sale");
        }
    }
}
