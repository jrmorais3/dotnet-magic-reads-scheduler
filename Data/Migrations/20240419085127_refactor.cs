using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SFData.Migrations
{
    /// <inheritdoc />
    public partial class refactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Voluntarios",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DtaNascimento",
                table: "Voluntarios",
                newName: "Birthday");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Voluntarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "Voluntarios",
                newName: "DtaNascimento");
        }
    }
}
