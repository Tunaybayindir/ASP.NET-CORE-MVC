using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Departmanlar.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmanlarID",
                table: "personels",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_personels_departmanlarID",
                table: "personels",
                column: "departmanlarID");

            migrationBuilder.AddForeignKey(
                name: "FK_personels_departmanlars_departmanlarID",
                table: "personels",
                column: "departmanlarID",
                principalTable: "departmanlars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personels_departmanlars_departmanlarID",
                table: "personels");

            migrationBuilder.DropIndex(
                name: "IX_personels_departmanlarID",
                table: "personels");

            migrationBuilder.DropColumn(
                name: "departmanlarID",
                table: "personels");
        }
    }
}
