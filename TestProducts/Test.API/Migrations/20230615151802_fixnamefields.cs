using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.API.Migrations
{
    /// <inheritdoc />
    public partial class fixnamefields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Width_Product",
                table: "Products",
                newName: "Product_Width");

            migrationBuilder.RenameColumn(
                name: "Length_Product",
                table: "Products",
                newName: "Product_Length");

            migrationBuilder.RenameColumn(
                name: "High_Product",
                table: "Products",
                newName: "Product_High");

            migrationBuilder.RenameColumn(
                name: "DateArrival",
                table: "Products",
                newName: "ArrivalDate");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product_Width",
                table: "Products",
                newName: "Width_Product");

            migrationBuilder.RenameColumn(
                name: "Product_Length",
                table: "Products",
                newName: "Length_Product");

            migrationBuilder.RenameColumn(
                name: "Product_High",
                table: "Products",
                newName: "High_Product");

            migrationBuilder.RenameColumn(
                name: "ArrivalDate",
                table: "Products",
                newName: "DateArrival");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }
    }
}
