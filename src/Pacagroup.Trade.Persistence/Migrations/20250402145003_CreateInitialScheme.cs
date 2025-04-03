﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pacagroup.Trade.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitialScheme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", precision: 9, scale: 0, nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Side = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    TransacTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quanty = table.Column<int>(type: "int", precision: 9, scale: 0, nullable: false),
                    Type = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(9,4)", precision: 9, scale: 4, nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Create", "CreatedBy", "LastModified", "LastModifiedBy", "Price", "Quanty", "Side", "Symbol", "TransacTime", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 522.99m, 1000, 0, "META", new DateTime(2025, 4, 2, 9, 50, 1, 330, DateTimeKind.Local).AddTicks(3709), 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 424.30m, 300, 0, "MSFT", new DateTime(2025, 4, 2, 9, 50, 1, 333, DateTimeKind.Local).AddTicks(4532), 0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 0m, 400, 1, "AMZN", new DateTime(2025, 4, 2, 9, 50, 1, 333, DateTimeKind.Local).AddTicks(4543), 1 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 0m, 800, 1, "TSLA", new DateTime(2025, 4, 2, 9, 50, 1, 333, DateTimeKind.Local).AddTicks(4545), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
