﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiteAPI.Models;

#nullable disable

namespace SiteAPI.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20250604114642_3red")]
    partial class _3red
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SiteAPI.Models.Element", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ElementType")
                        .HasColumnType("int");

                    b.Property<int?>("Position")
                        .HasColumnType("int");

                    b.Property<int?>("SiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("Elements");
                });

            modelBuilder.Entity("SiteAPI.Models.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("SiteAPI.Models.Element", b =>
                {
                    b.HasOne("SiteAPI.Models.Site", null)
                        .WithMany("Elements")
                        .HasForeignKey("SiteId");
                });

            modelBuilder.Entity("SiteAPI.Models.Site", b =>
                {
                    b.Navigation("Elements");
                });
#pragma warning restore 612, 618
        }
    }
}
