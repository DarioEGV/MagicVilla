using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "moderna cuidad", new DateTime(2023, 12, 17, 13, 39, 12, 416, DateTimeKind.Local).AddTicks(8958), new DateTime(2023, 12, 17, 13, 39, 12, 416, DateTimeKind.Local).AddTicks(8944), "", 50, "Tokio", 5, 200.0 },
                    { 2, "", "cuidad 2", new DateTime(2023, 12, 17, 13, 39, 12, 416, DateTimeKind.Local).AddTicks(8961), new DateTime(2023, 12, 17, 13, 39, 12, 416, DateTimeKind.Local).AddTicks(8961), "", 40, "Kioto", 5, 150.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
