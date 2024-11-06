using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITshop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Devices");
        }
    }
}
