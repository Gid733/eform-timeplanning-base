using Microsoft.EntityFrameworkCore.Migrations;

namespace Microting.TimePlanningBase.Migrations
{
    public partial class AddedNewMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, " " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
