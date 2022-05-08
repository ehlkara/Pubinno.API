using Microsoft.EntityFrameworkCore.Migrations;

namespace Pubinno.Core.Migrations
{
    public partial class added_TimeZoneConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeZoneName",
                table: "TimeZoneName");

            migrationBuilder.RenameTable(
                name: "TimeZoneName",
                newName: "TimeZone");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "TimeZone",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeZone",
                table: "TimeZone",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeZone",
                table: "TimeZone");

            migrationBuilder.RenameTable(
                name: "TimeZone",
                newName: "TimeZoneName");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "TimeZoneName",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeZoneName",
                table: "TimeZoneName",
                column: "Id");
        }
    }
}
