using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCash_proje_Edenyity.DataAccessLayer.Migrations
{
    public partial class reletion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "customerAccountProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "customerAccountProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_customerAccountProcesses_ReceiverId",
                table: "customerAccountProcesses",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_customerAccountProcesses_SenderId",
                table: "customerAccountProcesses",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_customerAccountProcesses_customerAccounts_ReceiverId",
                table: "customerAccountProcesses",
                column: "ReceiverId",
                principalTable: "customerAccounts",
                principalColumn: "CustomerAccountİd");

            migrationBuilder.AddForeignKey(
                name: "FK_customerAccountProcesses_customerAccounts_SenderId",
                table: "customerAccountProcesses",
                column: "SenderId",
                principalTable: "customerAccounts",
                principalColumn: "CustomerAccountİd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customerAccountProcesses_customerAccounts_ReceiverId",
                table: "customerAccountProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_customerAccountProcesses_customerAccounts_SenderId",
                table: "customerAccountProcesses");

            migrationBuilder.DropIndex(
                name: "IX_customerAccountProcesses_ReceiverId",
                table: "customerAccountProcesses");

            migrationBuilder.DropIndex(
                name: "IX_customerAccountProcesses_SenderId",
                table: "customerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "customerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "customerAccountProcesses");
        }
    }
}
