using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbOperationWithEFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class RenametestToShiv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tests",
                table: "tests");

            migrationBuilder.RenameTable(
                name: "tests",
                newName: "Shiv");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shiv",
                table: "Shiv",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Shiv",
                table: "Shiv");

            migrationBuilder.RenameTable(
                name: "Shiv",
                newName: "tests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tests",
                table: "tests",
                column: "Id");
        }
    }
}
