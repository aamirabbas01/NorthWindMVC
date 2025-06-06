﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NorthWindMVC.Data;

#nullable disable

namespace NorthWindMVC.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerCustomerDemo", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .HasColumnName("CustomerID")
                        .IsFixedLength();

                    b.Property<string>("CustomerTypeId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("CustomerTypeID")
                        .IsFixedLength();

                    b.HasKey("CustomerId", "CustomerTypeId");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("CustomerId", "CustomerTypeId"), false);

                    b.HasIndex("CustomerTypeId");

                    b.ToTable("CustomerCustomerDemo", (string)null);
                });

            modelBuilder.Entity("EmployeeTerritory", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("EmployeeID");

                    b.Property<string>("TerritoryId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("TerritoryID");

                    b.HasKey("EmployeeId", "TerritoryId");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("EmployeeId", "TerritoryId"), false);

                    b.HasIndex("TerritoryId");

                    b.ToTable("EmployeeTerritories", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("NorthWindMVC.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<byte[]>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("NorthWindMVC.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("image");

                    b.HasKey("CategoryId");

                    b.HasIndex(new[] { "CategoryName" }, "CategoryName");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .HasColumnName("CustomerID")
                        .IsFixedLength();

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ContactName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Fax")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CustomerId");

                    b.HasIndex(new[] { "City" }, "City");

                    b.HasIndex(new[] { "CompanyName" }, "CompanyName");

                    b.HasIndex(new[] { "PostalCode" }, "PostalCode");

                    b.HasIndex(new[] { "Region" }, "Region");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("NorthWindMVC.Models.CustomerDemographic", b =>
                {
                    b.Property<string>("CustomerTypeId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("CustomerTypeID")
                        .IsFixedLength();

                    b.Property<string>("CustomerDesc")
                        .HasColumnType("ntext");

                    b.HasKey("CustomerTypeId");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("CustomerTypeId"), false);

                    b.ToTable("CustomerDemographics");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Extension")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("datetime");

                    b.Property<string>("HomePhone")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Notes")
                        .HasColumnType("ntext");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("image");

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("ReportsTo")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TitleOfCourtesy")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("ReportsTo");

                    b.HasIndex(new[] { "LastName" }, "LastName");

                    b.HasIndex(new[] { "PostalCode" }, "PostalCode");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<string>("CustomerId")
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .HasColumnName("CustomerID")
                        .IsFixedLength();

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("EmployeeID");

                    b.Property<decimal?>("Freight")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValue(0m);

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("RequiredDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ShipAddress")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("ShipCity")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ShipCountry")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ShipName")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ShipPostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ShipRegion")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("ShipVia")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("datetime");

                    b.HasKey("OrderId");

                    b.HasIndex(new[] { "CustomerId" }, "CustomerID");

                    b.HasIndex(new[] { "CustomerId" }, "CustomersOrders");

                    b.HasIndex(new[] { "EmployeeId" }, "EmployeeID");

                    b.HasIndex(new[] { "EmployeeId" }, "EmployeesOrders");

                    b.HasIndex(new[] { "OrderDate" }, "OrderDate");

                    b.HasIndex(new[] { "ShipPostalCode" }, "ShipPostalCode");

                    b.HasIndex(new[] { "ShippedDate" }, "ShippedDate");

                    b.HasIndex(new[] { "ShipVia" }, "ShippersOrders");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("NorthWindMVC.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<short>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.HasKey("OrderId", "ProductId")
                        .HasName("PK_Order_Details");

                    b.HasIndex(new[] { "OrderId" }, "OrderID");

                    b.HasIndex(new[] { "OrderId" }, "OrdersOrder_Details");

                    b.HasIndex(new[] { "ProductId" }, "ProductID");

                    b.HasIndex(new[] { "ProductId" }, "ProductsOrder_Details");

                    b.ToTable("Order Details", (string)null);
                });

            modelBuilder.Entity("NorthWindMVC.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<bool>("Discontinued")
                        .HasColumnType("bit");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("QuantityPerUnit")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<short?>("ReorderLevel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)0);

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int")
                        .HasColumnName("SupplierID");

                    b.Property<decimal?>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValue(0m);

                    b.Property<short?>("UnitsInStock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)0);

                    b.Property<short?>("UnitsOnOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)0);

                    b.HasKey("ProductId");

                    b.HasIndex(new[] { "CategoryId" }, "CategoriesProducts");

                    b.HasIndex(new[] { "CategoryId" }, "CategoryID");

                    b.HasIndex(new[] { "ProductName" }, "ProductName");

                    b.HasIndex(new[] { "SupplierId" }, "SupplierID");

                    b.HasIndex(new[] { "SupplierId" }, "SuppliersProducts");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .HasColumnType("int")
                        .HasColumnName("RegionID");

                    b.Property<string>("RegionDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.HasKey("RegionId");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("RegionId"), false);

                    b.ToTable("Region", (string)null);
                });

            modelBuilder.Entity("NorthWindMVC.Models.Shipper", b =>
                {
                    b.Property<int>("ShipperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ShipperID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShipperId"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("ShipperId");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SupplierID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"));

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ContactName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Fax")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("HomePage")
                        .HasColumnType("ntext");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("SupplierId");

                    b.HasIndex(new[] { "CompanyName" }, "CompanyName");

                    b.HasIndex(new[] { "PostalCode" }, "PostalCode");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Territory", b =>
                {
                    b.Property<string>("TerritoryId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("TerritoryID");

                    b.Property<int>("RegionId")
                        .HasColumnType("int")
                        .HasColumnName("RegionID");

                    b.Property<string>("TerritoryDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.HasKey("TerritoryId");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("TerritoryId"), false);

                    b.HasIndex("RegionId");

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("CustomerCustomerDemo", b =>
                {
                    b.HasOne("NorthWindMVC.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK_CustomerCustomerDemo_Customers");

                    b.HasOne("NorthWindMVC.Models.CustomerDemographic", null)
                        .WithMany()
                        .HasForeignKey("CustomerTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_CustomerCustomerDemo");
                });

            modelBuilder.Entity("EmployeeTerritory", b =>
                {
                    b.HasOne("NorthWindMVC.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK_EmployeeTerritories_Employees");

                    b.HasOne("NorthWindMVC.Models.Territory", null)
                        .WithMany()
                        .HasForeignKey("TerritoryId")
                        .IsRequired()
                        .HasConstraintName("FK_EmployeeTerritories_Territories");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("NorthWindMVC.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("NorthWindMVC.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NorthWindMVC.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("NorthWindMVC.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NorthWindMVC.Models.Employee", b =>
                {
                    b.HasOne("NorthWindMVC.Models.Employee", "ReportsToNavigation")
                        .WithMany("InverseReportsToNavigation")
                        .HasForeignKey("ReportsTo")
                        .HasConstraintName("FK_Employees_Employees");

                    b.Navigation("ReportsToNavigation");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Order", b =>
                {
                    b.HasOne("NorthWindMVC.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Orders_Customers");

                    b.HasOne("NorthWindMVC.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_Orders_Employees");

                    b.HasOne("NorthWindMVC.Models.Shipper", "ShipViaNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("ShipVia")
                        .HasConstraintName("FK_Orders_Shippers");

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("ShipViaNavigation");
                });

            modelBuilder.Entity("NorthWindMVC.Models.OrderDetail", b =>
                {
                    b.HasOne("NorthWindMVC.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_Details_Orders");

                    b.HasOne("NorthWindMVC.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_Details_Products");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Product", b =>
                {
                    b.HasOne("NorthWindMVC.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Products_Categories");

                    b.HasOne("NorthWindMVC.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("FK_Products_Suppliers");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Territory", b =>
                {
                    b.HasOne("NorthWindMVC.Models.Region", "Region")
                        .WithMany("Territories")
                        .HasForeignKey("RegionId")
                        .IsRequired()
                        .HasConstraintName("FK_Territories_Region");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Employee", b =>
                {
                    b.Navigation("InverseReportsToNavigation");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Region", b =>
                {
                    b.Navigation("Territories");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Shipper", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("NorthWindMVC.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
