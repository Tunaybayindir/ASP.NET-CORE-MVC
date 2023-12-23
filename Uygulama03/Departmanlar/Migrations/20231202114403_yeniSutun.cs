using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Departmanlar.Migrations
{
    /// <inheritdoc />
    public partial class yeniSutun : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "detaylar",
                table: "departmanlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detaylar",
                table: "departmanlars");
        }
    }
}
