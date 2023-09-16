using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2DataAccessLayer.Migrations
{
    public partial class Adding_Staff_Registration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaffRegistrations",
                columns: table => new
                {
                    StaffRegistrationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StafRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffRegistrations", x => x.StaffRegistrationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffRegistrations");
        }
    }
}
