using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FakeBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "TouristRoutes",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreateTime", "DepartureTime", "Description", "DiscountPresent", "Features", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("9a5f7c31-67fb-435a-8fba-c85617aa34e1"), new DateTime(2025, 5, 30, 21, 52, 57, 587, DateTimeKind.Utc).AddTicks(1193), null, "TestDescription", null, null, null, null, 0m, "TestTitle", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("9a5f7c31-67fb-435a-8fba-c85617aa34e1"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "TouristRoutes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "GETDATE()");
        }
    }
}
