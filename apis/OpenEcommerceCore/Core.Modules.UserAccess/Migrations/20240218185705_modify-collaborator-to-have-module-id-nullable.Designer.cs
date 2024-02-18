﻿// <auto-generated />
using System;
using Core.Modules.UserAccess.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Core.Modules.UserAccess.Migrations
{
    [DbContext(typeof(UserAccessContext))]
    [Migration("20240218185705_modify-collaborator-to-have-module-id-nullable")]
    partial class modifycollaboratortohavemoduleidnullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Modules.UserAccess.Domain.Entities.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid>("ClientModuleId")
                        .HasColumnType("uuid")
                        .HasColumnName("ClientModuleId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean")
                        .HasColumnName("Deleted");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("Email");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("LastLogin");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("bytea")
                        .HasColumnName("Password");

                    b.Property<byte[]>("SecurityKey")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("bytea")
                        .HasColumnName("SecurityKey");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Core.Modules.UserAccess.Domain.Entities.Collaborator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid?>("CollaboratorModuleId")
                        .HasColumnType("uuid")
                        .HasColumnName("CollaboratorModuleId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean")
                        .HasColumnName("Deleted");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("Email");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean")
                        .HasColumnName("IsAdmin");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("LastLogin");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("Password");

                    b.Property<int[]>("Sectors")
                        .IsRequired()
                        .HasColumnType("integer[]")
                        .HasColumnName("Sector");

                    b.Property<byte[]>("SecurityKey")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("SecurityKey");

                    b.HasKey("Id");

                    b.ToTable("Collaborators");
                });
#pragma warning restore 612, 618
        }
    }
}
