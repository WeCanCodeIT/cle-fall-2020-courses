using Microsoft.EntityFrameworkCore.Migrations;

namespace cle_fall_2020_courses.Migrations
{
    public partial class LastRevisionTimeStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastRevision",
                table: "Courses",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastRevision",
                value: "12/31/18");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastRevision",
                value: "12/31/18");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastRevision",
                value: "12/31/18");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastRevision",
                table: "Courses");
        }
    }
}
