using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDependencyOwnerAuto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OwnerId",
                table: "Autos",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Autos_OwnerId",
                table: "Autos",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_Owners_OwnerId",
                table: "Autos",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autos_Owners_OwnerId",
                table: "Autos");

            migrationBuilder.DropIndex(
                name: "IX_Autos_OwnerId",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Autos");
        }
    }
}
