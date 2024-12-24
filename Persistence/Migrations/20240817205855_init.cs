using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsCompleted", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 8, 17, 22, 58, 54, 784, DateTimeKind.Local).AddTicks(1845), "Finish the Blazor tutortial with Clean Architecture and then deploy the project to GitHub", false, "Finish the Blazor tutortial", null, new DateTime(2024, 8, 17, 22, 58, 54, 784, DateTimeKind.Local).AddTicks(1907) },
                    { 2, null, new DateTime(2024, 8, 17, 22, 58, 54, 784, DateTimeKind.Local).AddTicks(1911), "Get rid of unnecessary mails in private e-mail inbox", false, "Clean up e-mail inbox", null, new DateTime(2024, 8, 17, 22, 58, 54, 784, DateTimeKind.Local).AddTicks(1912) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");
        }
    }
}
