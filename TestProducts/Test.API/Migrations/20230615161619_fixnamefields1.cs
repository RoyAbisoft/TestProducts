using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.API.Migrations
{
    /// <inheritdoc />
    public partial class fixnamefields1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product_High",
                table: "Products",
                newName: "Product_Height");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product_Height",
                table: "Products",
                newName: "Product_High");
        }
    }
}
