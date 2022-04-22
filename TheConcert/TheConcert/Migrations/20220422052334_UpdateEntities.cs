using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheConcert.Migrations
{
    public partial class UpdateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Entrances",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entrances_TicketId",
                table: "Entrances",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrances_Tickets_TicketId",
                table: "Entrances",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrances_Tickets_TicketId",
                table: "Entrances");

            migrationBuilder.DropIndex(
                name: "IX_Entrances_TicketId",
                table: "Entrances");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Entrances");
        }
    }
}
