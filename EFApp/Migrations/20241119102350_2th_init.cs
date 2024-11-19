using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFApp.Migrations
{
    /// <inheritdoc />
    public partial class _2th_init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Price",
                table: "Autos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Autos");
        }
    }
}
