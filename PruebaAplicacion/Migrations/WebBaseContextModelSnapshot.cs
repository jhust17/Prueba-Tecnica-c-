﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaAplicacion.Models;

#nullable disable

namespace PruebaAplicacion.Migrations
{
    [DbContext(typeof(WebBaseContext))]
    partial class WebBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PruebaAplicacion.Models.Cliente", b =>
                {
                    b.Property<long>("IdCliente")
                        .HasColumnType("bigint");

                    b.Property<string>("Correo")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Identificacion")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdCliente")
                        .HasName("PK__Cliente__D5946642C8356799");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("PruebaAplicacion.Models.DetalleFactura", b =>
                {
                    b.Property<long>("IdDetalle")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("Cantidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("IdFactura")
                        .HasColumnType("bigint");

                    b.Property<long?>("IdProducto")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("Iva")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("IVA");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UnidadMedida")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdDetalle")
                        .HasName("PK__DetalleF__E43646A5AA2638EE");

                    b.HasIndex("IdFactura");

                    b.HasIndex("IdProducto");

                    b.ToTable("DetalleFactura", (string)null);
                });

            modelBuilder.Entity("PruebaAplicacion.Models.Factura", b =>
                {
                    b.Property<long>("IdFactura")
                        .HasColumnType("bigint");

                    b.Property<string>("Establecimiento")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("date");

                    b.Property<long?>("IdCliente")
                        .HasColumnType("bigint");

                    b.Property<string>("NumeroFactura")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PuntoEmision")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<decimal?>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TotalIva")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("TotalIVA");

                    b.HasKey("IdFactura")
                        .HasName("PK__Factura__50E7BAF13D3452BA");

                    b.HasIndex("IdCliente");

                    b.ToTable("Factura", (string)null);
                });

            modelBuilder.Entity("PruebaAplicacion.Models.Producto", b =>
                {
                    b.Property<long>("IdProducto")
                        .HasColumnType("bigint");

                    b.Property<string>("Categoria")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Codigo")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdProducto")
                        .HasName("PK__Producto__098892106485B25D");

                    b.ToTable("Producto", (string)null);
                });

            modelBuilder.Entity("PruebaAplicacion.Models.DetalleFactura", b =>
                {
                    b.HasOne("PruebaAplicacion.Models.Factura", "IdFacturaNavigation")
                        .WithMany("DetalleFacturas")
                        .HasForeignKey("IdFactura")
                        .HasConstraintName("FK__DetalleFa__IdFac__2B3F6F97");

                    b.HasOne("PruebaAplicacion.Models.Producto", "IdProductoNavigation")
                        .WithMany("DetalleFacturas")
                        .HasForeignKey("IdProducto")
                        .HasConstraintName("FK__DetalleFa__IdPro__2C3393D0");

                    b.Navigation("IdFacturaNavigation");

                    b.Navigation("IdProductoNavigation");
                });

            modelBuilder.Entity("PruebaAplicacion.Models.Factura", b =>
                {
                    b.HasOne("PruebaAplicacion.Models.Cliente", "IdClienteNavigation")
                        .WithMany("Facturas")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FK__Factura__IdClien__286302EC");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("PruebaAplicacion.Models.Cliente", b =>
                {
                    b.Navigation("Facturas");
                });

            modelBuilder.Entity("PruebaAplicacion.Models.Factura", b =>
                {
                    b.Navigation("DetalleFacturas");
                });

            modelBuilder.Entity("PruebaAplicacion.Models.Producto", b =>
                {
                    b.Navigation("DetalleFacturas");
                });
#pragma warning restore 612, 618
        }
    }
}
