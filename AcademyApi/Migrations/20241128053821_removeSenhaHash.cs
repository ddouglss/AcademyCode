using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademyApi.Migrations
{
    /// <inheritdoc />
    public partial class removeSenhaHash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SenhaHash",
                table: "Usuarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SenhaHash",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
