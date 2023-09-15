using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2DataAccessLayer.Migrations
{
    public partial class Updating_Student_Registration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentRegistration",
                table: "StudentRegistration");

            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "StudentRegistration");

            migrationBuilder.RenameTable(
                name: "StudentRegistration",
                newName: "StudentRegistrations");

            migrationBuilder.AddColumn<int>(
                name: "StudentRegistrationId",
                table: "StudentRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentRegistrations",
                table: "StudentRegistrations",
                column: "StudentRegistrationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentRegistrations",
                table: "StudentRegistrations");

            migrationBuilder.DropColumn(
                name: "StudentRegistrationId",
                table: "StudentRegistrations");

            migrationBuilder.RenameTable(
                name: "StudentRegistrations",
                newName: "StudentRegistration");

            migrationBuilder.AddColumn<long>(
                name: "RegistrationId",
                table: "StudentRegistration",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentRegistration",
                table: "StudentRegistration",
                column: "RegistrationId");
        }
    }
}
