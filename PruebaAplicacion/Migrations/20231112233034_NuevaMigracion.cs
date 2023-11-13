using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaAplicacion.Migrations
{
    public partial class NuevaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<long>(type: "bigint", nullable: false),
                    Identificacion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Nombre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Correo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cliente__D5946642C8356799", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    IdProducto = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Categoria = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Producto__098892106485B25D", x => x.IdProducto);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    IdFactura = table.Column<long>(type: "bigint", nullable: false),
                    Establecimiento = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PuntoEmision = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NumeroFactura = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Fecha = table.Column<DateTime>(type: "date", nullable: true),
                    IdCliente = table.Column<long>(type: "bigint", nullable: true),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalIVA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Factura__50E7BAF13D3452BA", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FK__Factura__IdClien__286302EC",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente");
                });

            migrationBuilder.CreateTable(
                name: "DetalleFactura",
                columns: table => new
                {
                    IdDetalle = table.Column<long>(type: "bigint", nullable: false),
                    IdFactura = table.Column<long>(type: "bigint", nullable: true),
                    IdProducto = table.Column<long>(type: "bigint", nullable: true),
                    Cantidad = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UnidadMedida = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IVA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DetalleF__E43646A5AA2638EE", x => x.IdDetalle);
                    table.ForeignKey(
                        name: "FK__DetalleFa__IdFac__2B3F6F97",
                        column: x => x.IdFactura,
                        principalTable: "Factura",
                        principalColumn: "IdFactura");
                    table.ForeignKey(
                        name: "FK__DetalleFa__IdPro__2C3393D0",
                        column: x => x.IdProducto,
                        principalTable: "Producto",
                        principalColumn: "IdProducto");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFactura_IdFactura",
                table: "DetalleFactura",
                column: "IdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFactura_IdProducto",
                table: "DetalleFactura",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_IdCliente",
                table: "Factura",
                column: "IdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleFactura");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
