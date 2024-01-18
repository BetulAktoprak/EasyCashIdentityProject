using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_customer_relation_process : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceiverID",
                table: "CustomerAcccountProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderID",
                table: "CustomerAcccountProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ConfirmCode",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAcccountProcesses_ReceiverID",
                table: "CustomerAcccountProcesses",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAcccountProcesses_SenderID",
                table: "CustomerAcccountProcesses",
                column: "SenderID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAcccountProcesses_CustomerAcccounts_ReceiverID",
                table: "CustomerAcccountProcesses",
                column: "ReceiverID",
                principalTable: "CustomerAcccounts",
                principalColumn: "CustomerAcccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAcccountProcesses_CustomerAcccounts_SenderID",
                table: "CustomerAcccountProcesses",
                column: "SenderID",
                principalTable: "CustomerAcccounts",
                principalColumn: "CustomerAcccountID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAcccountProcesses_CustomerAcccounts_ReceiverID",
                table: "CustomerAcccountProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAcccountProcesses_CustomerAcccounts_SenderID",
                table: "CustomerAcccountProcesses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAcccountProcesses_ReceiverID",
                table: "CustomerAcccountProcesses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAcccountProcesses_SenderID",
                table: "CustomerAcccountProcesses");

            migrationBuilder.DropColumn(
                name: "ReceiverID",
                table: "CustomerAcccountProcesses");

            migrationBuilder.DropColumn(
                name: "SenderID",
                table: "CustomerAcccountProcesses");

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConfirmCode",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
