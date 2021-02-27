﻿// <auto-generated />
using System;
using AdminPage_JagdeepSingh.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdminPage_JagdeepSingh.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdminPage_JagdeepSingh.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("coutnry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("homePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notes")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reportTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titleOfCourtesy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("AdminPage_JagdeepSingh.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AdminPage_JagdeepSingh.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("companyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fax")
                        .HasColumnType("int");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("region")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AdminPage_JagdeepSingh.Models.OrderDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("discount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("productID")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("unitPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("productID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("AdminPage_JagdeepSingh.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("categoryID")
                        .HasColumnType("int");

                    b.Property<decimal>("dicounted")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("productName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantityPerLabel")
                        .HasColumnType("int");

                    b.Property<int>("reorderLevel")
                        .HasColumnType("int");

                    b.Property<int?>("supplierID")
                        .HasColumnType("int");

                    b.Property<decimal>("unitPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("unitsInStocks")
                        .HasColumnType("int");

                    b.Property<int>("unitsOnOrder")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("categoryID");

                    b.HasIndex("supplierID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AdminPage_JagdeepSingh.Models.Region", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("regionDescription")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.HasKey("ID");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("AdminPage_JagdeepSingh.Models.Shipper", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("companyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("AdminPage_JagdeepSingh.Models.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("companyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fax")
                        .HasColumnType("int");

                    b.Property<string>("homepage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("region")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("AdminPage_JagdeepSingh.Models.Territory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("regionID")
                        .HasColumnType("int");

                    b.Property<string>("territoryDescription")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.HasKey("ID");

                    b.HasIndex("regionID");

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("AdminPage_JagdeepSingh.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("customerID")
                        .HasColumnType("int");

                    b.Property<int?>("employeeID")
                        .HasColumnType("int");

                    b.Property<string>("shipAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shipCOuntry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shipCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shipName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shipPostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shipRegion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shipVia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("weight")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("customerID");

                    b.HasIndex("employeeID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EmployeeTerritory", b =>
                {
                    b.Property<int>("EmployeesID")
                        .HasColumnType("int");

                    b.Property<int>("TerritoriesID")
                        .HasColumnType("int");

                    b.HasKey("EmployeesID", "TerritoriesID");

                    b.HasIndex("TerritoriesID");

                    b.ToTable("EmployeeTerritory");
                });

            modelBuilder.Entity("AdminPage_JagdeepSingh.Models.OrderDetail", b =>
                {
                    b.HasOne("AdminPage_JagdeepSingh.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productID");

                    b.Navigation("product");
                });

            modelBuilder.Entity("AdminPage_JagdeepSingh.Models.Product", b =>
                {
                    b.HasOne("AdminPage_JagdeepSingh.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryID");

                    b.HasOne("AdminPage_JagdeepSingh.Models.Supplier", "supplier")
                        .WithMany()
                        .HasForeignKey("supplierID");

                    b.Navigation("category");

                    b.Navigation("supplier");
                });

            modelBuilder.Entity("AdminPage_JagdeepSingh.Models.Territory", b =>
                {
                    b.HasOne("AdminPage_JagdeepSingh.Models.Region", "region")
                        .WithMany()
                        .HasForeignKey("regionID");

                    b.Navigation("region");
                });

            modelBuilder.Entity("AdminPage_JagdeepSingh.Order", b =>
                {
                    b.HasOne("AdminPage_JagdeepSingh.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("customerID");

                    b.HasOne("AdminPage_JagdeepSingh.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("employeeID");

                    b.Navigation("customer");

                    b.Navigation("employee");
                });

            modelBuilder.Entity("EmployeeTerritory", b =>
                {
                    b.HasOne("AdminPage_JagdeepSingh.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdminPage_JagdeepSingh.Models.Territory", null)
                        .WithMany()
                        .HasForeignKey("TerritoriesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}