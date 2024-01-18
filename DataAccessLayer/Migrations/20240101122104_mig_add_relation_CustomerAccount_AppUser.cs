using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_relation_CustomerAccount_AppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "CustomerAcccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAcccounts_AppUserID",
                table: "CustomerAcccounts",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAcccounts_AspNetUsers_AppUserID",
                table: "CustomerAcccounts",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAcccounts_AspNetUsers_AppUserID",
                table: "CustomerAcccounts");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAcccounts_AppUserID",
                table: "CustomerAcccounts");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "CustomerAcccounts");
        }
    }
}
