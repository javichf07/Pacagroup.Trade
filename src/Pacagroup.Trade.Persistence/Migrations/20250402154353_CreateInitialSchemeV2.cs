using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pacagroup.Trade.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitialSchemeV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransacTime",
                value: new DateTime(2025, 4, 2, 9, 50, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransacTime",
                value: new DateTime(2025, 4, 2, 9, 50, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransacTime",
                value: new DateTime(2025, 4, 2, 9, 50, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransacTime",
                value: new DateTime(2025, 4, 2, 9, 50, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransacTime",
                value: new DateTime(2025, 4, 2, 9, 50, 1, 330, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransacTime",
                value: new DateTime(2025, 4, 2, 9, 50, 1, 333, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransacTime",
                value: new DateTime(2025, 4, 2, 9, 50, 1, 333, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransacTime",
                value: new DateTime(2025, 4, 2, 9, 50, 1, 333, DateTimeKind.Local).AddTicks(4545));
        }
    }
}
