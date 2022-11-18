using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalAssesmentLaBestia.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "id",
                keyValue: 1,
                column: "Vehicle_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "id",
                keyValue: 2,
                column: "Vehicle_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "id",
                keyValue: 3,
                column: "Vehicle_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "id",
                keyValue: 1,
                column: "Owner_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "id",
                keyValue: 2,
                column: "Owner_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "id",
                keyValue: 3,
                column: "Owner_id",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "id",
                keyValue: 1,
                column: "Vehicle_id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "id",
                keyValue: 2,
                column: "Vehicle_id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "id",
                keyValue: 3,
                column: "Vehicle_id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "id",
                keyValue: 1,
                column: "Owner_id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "id",
                keyValue: 2,
                column: "Owner_id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "id",
                keyValue: 3,
                column: "Owner_id",
                value: 0);
        }
    }
}
