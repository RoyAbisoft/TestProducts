using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNameField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Products",
                newName: "Width_Product");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Products",
                newName: "Length_Product");

            migrationBuilder.RenameColumn(
                name: "Altitude",
                table: "Products",
                newName: "High_Product");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Width_Product",
                table: "Products",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "Length_Product",
                table: "Products",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "High_Product",
                table: "Products",
                newName: "Altitude");
        }
    }
}
