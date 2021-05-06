using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TamagotchiAPI.Migrations
{
    public partial class AddLastInteractedWithDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastInteractedWithDate",
                table: "Pets",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastInteractedWithDate",
                table: "Pets");
        }
    }
}
