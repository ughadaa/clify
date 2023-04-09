using Microsoft.EntityFrameworkCore.Migrations;

#nullable enable

namespace clify.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "Commands",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sub",
                table: "Commands",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "category",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "sub",
                table: "Commands");
        }
    }
}
