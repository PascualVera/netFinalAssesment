using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalAssesmentLaBestia.Migrations
{
    /// <inheritdoc />
    public partial class BienvenidoAntonio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Claim_Vehicles_vehicle_id",
                table: "Claim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Claim",
                table: "Claim");

            migrationBuilder.RenameTable(
                name: "Claim",
                newName: "Claims");

            migrationBuilder.RenameIndex(
                name: "IX_Claim_vehicle_id",
                table: "Claims",
                newName: "IX_Claims_vehicle_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Claims",
                table: "Claims",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Claims_Vehicles_vehicle_id",
                table: "Claims",
                column: "vehicle_id",
                principalTable: "Vehicles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Claims_Vehicles_vehicle_id",
                table: "Claims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Claims",
                table: "Claims");

            migrationBuilder.RenameTable(
                name: "Claims",
                newName: "Claim");

            migrationBuilder.RenameIndex(
                name: "IX_Claims_vehicle_id",
                table: "Claim",
                newName: "IX_Claim_vehicle_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Claim",
                table: "Claim",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Claim_Vehicles_vehicle_id",
                table: "Claim",
                column: "vehicle_id",
                principalTable: "Vehicles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
