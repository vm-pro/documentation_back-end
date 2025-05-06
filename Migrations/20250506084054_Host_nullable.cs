using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Documentation_back_end.Migrations
{
    /// <inheritdoc />
    public partial class Host_nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hosts_Furnishers_FurnisherId",
                table: "Hosts");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Hosts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FurnisherId",
                table: "Hosts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Hosts_Furnishers_FurnisherId",
                table: "Hosts",
                column: "FurnisherId",
                principalTable: "Furnishers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hosts_Furnishers_FurnisherId",
                table: "Hosts");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Hosts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FurnisherId",
                table: "Hosts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Hosts_Furnishers_FurnisherId",
                table: "Hosts",
                column: "FurnisherId",
                principalTable: "Furnishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
