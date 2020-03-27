using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SolrTS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    JoinDate = table.Column<DateTime>(nullable: false),
                    Group = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Group", "JoinDate", "Name" },
                values: new object[,]
                {
                    { "PX1", "Blue", new DateTime(2020, 3, 26, 16, 57, 30, 712, DateTimeKind.Local).AddTicks(6384), "Kevin" },
                    { "PX2", "Blue", new DateTime(2020, 3, 25, 16, 57, 30, 716, DateTimeKind.Local).AddTicks(3474), "Chris" },
                    { "PX3", "Red", new DateTime(2020, 3, 24, 16, 57, 30, 716, DateTimeKind.Local).AddTicks(3509), "Claire" },
                    { "PX4", "Blue", new DateTime(2020, 3, 23, 16, 57, 30, 716, DateTimeKind.Local).AddTicks(3514), "Sophie" },
                    { "PX5", "Red", new DateTime(2020, 3, 22, 16, 57, 30, 716, DateTimeKind.Local).AddTicks(3517), "Katalin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
