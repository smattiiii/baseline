using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OS_GJ_Tutoring.Migrations
{
    /// <inheritdoc />
    public partial class BookCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TicketoneQty = table.Column<int>(type: "int", nullable: true),
                    TickettwoQty = table.Column<int>(type: "int", nullable: true),
                    TicketthreeQty = table.Column<int>(type: "int", nullable: true),
                    TicketfourQty = table.Column<int>(type: "int", nullable: true),
                    TicketfiveQty = table.Column<int>(type: "int", nullable: true),
                    TicketsixQty = table.Column<int>(type: "int", nullable: true),
                    TicketsevenQty = table.Column<int>(type: "int", nullable: true),
                    TicketeightQty = table.Column<int>(type: "int", nullable: true),
                    YearPass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDB", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookDB");
        }
    }
}
