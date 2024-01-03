﻿// <auto-generated />
using System;
using Core.Modules.Stock.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Core.Modules.Stock.Migrations
{
    [DbContext(typeof(StockContext))]
    partial class StockContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("Neighbourhood")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("Neighbourhood");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("State");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("Street");

                    b.Property<int>("ZipCode")
                        .HasColumnType("integer")
                        .HasColumnName("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Collaborator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean")
                        .HasColumnName("Deleted");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("LastName");

                    b.HasKey("Id");

                    b.ToTable("Collaborators");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.DemandMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean")
                        .HasColumnName("Deleted");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)")
                        .HasColumnName("Message");

                    b.Property<int>("Sector")
                        .HasColumnType("integer")
                        .HasColumnName("FromSector");

                    b.HasKey("Id");

                    b.ToTable("DemandMessage");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Demands.ProductRestockDemand", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<bool>("Canceled")
                        .HasColumnType("boolean")
                        .HasColumnName("Canceled");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean")
                        .HasColumnName("Deleted");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("Description");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("LastUpdate");

                    b.Property<bool>("Resolved")
                        .HasColumnType("boolean")
                        .HasColumnName("Resolved");

                    b.Property<int>("RestockQuantity")
                        .HasColumnType("integer")
                        .HasColumnName("RestockQuantity");

                    b.HasKey("Id");

                    b.ToTable("ProductRestockOrders");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.MeasureUnit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("Name");

                    b.Property<string>("ShortName")
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("ShortName");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)")
                        .HasColumnName("Symbol");

                    b.HasKey("Id");

                    b.ToTable("MeasureUnits");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Product.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)")
                        .HasColumnName("Description");

                    b.Property<string>("EAN")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)")
                        .HasColumnName("EAN_13");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("LastUpdate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("Name");

                    b.Property<decimal>("Price")
                        .HasPrecision(16, 2)
                        .HasColumnType("numeric(16,2)")
                        .HasColumnName("Price");

                    b.Property<string>("SKU")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("SKU");

                    b.Property<int>("StockUnitCount")
                        .HasColumnType("integer")
                        .HasColumnName("StockUnitCount");

                    b.Property<string>("UPC")
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)")
                        .HasColumnName("UPC_A");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Product.ProductDetails.MeasurementDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("MeasureUnitId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("ShowOrder")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MeasureUnitId");

                    b.HasIndex("ProductId");

                    b.ToTable("MeasurementDetail");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Product.ProductDetails.OtherDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("MeasureUnitId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("ShowOrder")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MeasureUnitId");

                    b.HasIndex("ProductId");

                    b.ToTable("OtherDetail");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Product.ProductDetails.TechnicalDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("MeasureUnitId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("ShowOrder")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MeasureUnitId");

                    b.HasIndex("ProductId");

                    b.ToTable("TechnicalDetail");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Product.ProductImage", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("Description");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(384)
                        .HasColumnType("character varying(384)")
                        .HasColumnName("Url");

                    b.HasKey("Id");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Product.ProductTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("TagName");

                    b.HasKey("Id");

                    b.ToTable("ProductTags");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("Phone");

                    b.Property<int>("SalesNumber")
                        .HasColumnType("integer")
                        .HasColumnName("SalesNumber");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("ProductProductTag", b =>
                {
                    b.Property<Guid>("TaggedProductsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TagsId")
                        .HasColumnType("uuid");

                    b.HasKey("TaggedProductsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("ProductProductTag");
                });

            modelBuilder.Entity("ProductSupplier", b =>
                {
                    b.Property<Guid>("ProductsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SuppliersId")
                        .HasColumnType("uuid");

                    b.HasKey("ProductsId", "SuppliersId");

                    b.HasIndex("SuppliersId");

                    b.ToTable("ProductSupplier");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.DemandMessage", b =>
                {
                    b.HasOne("Core.Modules.Stock.Domain.Entities.Collaborator", "Collaborator")
                        .WithMany("DemandMessages")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Modules.Stock.Domain.Entities.Demands.ProductRestockDemand", "ProductRestockDemand")
                        .WithMany("DemandMessages")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collaborator");

                    b.Navigation("ProductRestockDemand");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Demands.ProductRestockDemand", b =>
                {
                    b.HasOne("Core.Modules.Stock.Domain.Entities.Product.Product", "Product")
                        .WithMany("ProductRestockDemands")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Product.Product", b =>
                {
                    b.HasOne("Core.Modules.Stock.Domain.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Product.ProductDetails.MeasurementDetail", b =>
                {
                    b.HasOne("Core.Modules.Stock.Domain.Entities.MeasureUnit", "MeasureUnit")
                        .WithMany()
                        .HasForeignKey("MeasureUnitId");

                    b.HasOne("Core.Modules.Stock.Domain.Entities.Product.Product", "Product")
                        .WithMany("Measurements")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeasureUnit");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Product.ProductDetails.OtherDetail", b =>
                {
                    b.HasOne("Core.Modules.Stock.Domain.Entities.MeasureUnit", "MeasureUnit")
                        .WithMany()
                        .HasForeignKey("MeasureUnitId");

                    b.HasOne("Core.Modules.Stock.Domain.Entities.Product.Product", "Product")
                        .WithMany("OtherDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeasureUnit");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Product.ProductDetails.TechnicalDetail", b =>
                {
                    b.HasOne("Core.Modules.Stock.Domain.Entities.MeasureUnit", "MeasureUnit")
                        .WithMany()
                        .HasForeignKey("MeasureUnitId");

                    b.HasOne("Core.Modules.Stock.Domain.Entities.Product.Product", "Product")
                        .WithMany("TechnicalDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeasureUnit");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Product.ProductImage", b =>
                {
                    b.HasOne("Core.Modules.Stock.Domain.Entities.Product.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Supplier", b =>
                {
                    b.HasOne("Core.Modules.Stock.Domain.Entities.Address", "Address")
                        .WithMany("Suppliers")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("ProductProductTag", b =>
                {
                    b.HasOne("Core.Modules.Stock.Domain.Entities.Product.Product", null)
                        .WithMany()
                        .HasForeignKey("TaggedProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Modules.Stock.Domain.Entities.Product.ProductTag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductSupplier", b =>
                {
                    b.HasOne("Core.Modules.Stock.Domain.Entities.Product.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Modules.Stock.Domain.Entities.Supplier", null)
                        .WithMany()
                        .HasForeignKey("SuppliersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Address", b =>
                {
                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Collaborator", b =>
                {
                    b.Navigation("DemandMessages");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Demands.ProductRestockDemand", b =>
                {
                    b.Navigation("DemandMessages");
                });

            modelBuilder.Entity("Core.Modules.Stock.Domain.Entities.Product.Product", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Measurements");

                    b.Navigation("OtherDetails");

                    b.Navigation("ProductRestockDemands");

                    b.Navigation("TechnicalDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
