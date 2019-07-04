using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Worker.DataAccess.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UpdateUser",
                table: "Users",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreateUser",
                table: "Users",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "RelatedPerson",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateUser",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateUser",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "RelatedPerson",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
