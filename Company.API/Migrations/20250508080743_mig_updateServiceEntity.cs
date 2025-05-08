using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.API.Migrations
{
    /// <inheritdoc />
    public partial class mig_updateServiceEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DescriptionFirst",
                table: "Services",
                newName: "Icon");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "Services",
                newName: "DescriptionFirst");
        }
    }
}
