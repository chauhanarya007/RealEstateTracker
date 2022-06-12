using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstate_Tracker.Data.Migrations
{
    public partial class UpdateProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "NameofOwner",
                table: "Properties",
                newName: "Photo");

            migrationBuilder.AlterColumn<decimal>(
                name: "SalePrice",
                table: "Properties",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "OwnerDetails",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerDetails",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Properties",
                newName: "NameofOwner");

            migrationBuilder.AlterColumn<int>(
                name: "SalePrice",
                table: "Properties",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Locations",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true);
        }
    }
}
