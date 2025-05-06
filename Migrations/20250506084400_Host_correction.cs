using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Documentation_back_end.Migrations
{
    /// <inheritdoc />
    public partial class Host_correction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hosts_Localisations_LocalisationId",
                table: "Hosts");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Hosts");

            migrationBuilder.AlterColumn<int>(
                name: "LocalisationId",
                table: "Hosts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Hosts_Localisations_LocalisationId",
                table: "Hosts",
                column: "LocalisationId",
                principalTable: "Localisations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hosts_Localisations_LocalisationId",
                table: "Hosts");

            migrationBuilder.AlterColumn<int>(
                name: "LocalisationId",
                table: "Hosts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Hosts",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Hosts_Localisations_LocalisationId",
                table: "Hosts",
                column: "LocalisationId",
                principalTable: "Localisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
