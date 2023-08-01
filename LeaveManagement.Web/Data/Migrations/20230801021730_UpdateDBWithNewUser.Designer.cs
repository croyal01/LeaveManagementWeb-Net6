﻿// <auto-generated />
using System;
using LeaveManagement.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230801021730_UpdateDBWithNewUser")]
    partial class UpdateDBWithNewUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LeaveManagement.Web.Data.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateJoined")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateofBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxId")
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

                    b.HasData(
                        new
                        {
                            Id = "32274BF3-6899-4D73-818A-6B736D71E1B0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2f722e38-c53c-4985-a70f-d07c6b5e6bca",
                            DateJoined = new DateTime(2023, 7, 31, 22, 17, 30, 343, DateTimeKind.Local).AddTicks(176),
                            DateofBirth = new DateTime(2023, 7, 31, 22, 17, 30, 343, DateTimeKind.Local).AddTicks(127),
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            Firstname = "System",
                            Lastname = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGHUr/KalC04M67TCsdTRPwF5vL27qhgSJL74R0AsYUkTu7f2J0oS0ZgVrWHwo7p4A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "22eacff3-857e-4ea9-a7a4-a8d8329f5f93",
                            TwoFactorEnabled = false,
                            UserName = "ADMIN@LOCALHOST.COM"
                        },
                        new
                        {
                            Id = "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "27b40426-bb4e-468e-acea-88e9c2a2dc4c",
                            DateJoined = new DateTime(2023, 7, 31, 22, 17, 30, 351, DateTimeKind.Local).AddTicks(8127),
                            DateofBirth = new DateTime(2023, 7, 31, 22, 17, 30, 351, DateTimeKind.Local).AddTicks(8098),
                            Email = "user@localhost.com",
                            EmailConfirmed = true,
                            Firstname = "System",
                            Lastname = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@LOCALHOST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMM5Y7asv1iiQiqXZ/rfPyNkv/da5qoumDyIFhCxp4p9asMWBPnBT1WFqHWSddoz2g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0494f98e-5ad6-4db9-84c6-ad52d53e6e7b",
                            TwoFactorEnabled = false,
                            UserName = "ADMIN@LOCALHOST.COM"
                        },
                        new
                        {
                            Id = "5D2DBC83-6023-4867-BDA5-7D2E68217056",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4e2b5ba6-5114-4aad-be92-872d29a94e94",
                            DateJoined = new DateTime(2023, 7, 31, 22, 17, 30, 361, DateTimeKind.Local).AddTicks(8062),
                            DateofBirth = new DateTime(2023, 7, 31, 22, 17, 30, 361, DateTimeKind.Local).AddTicks(8016),
                            Email = "supervisor@localhost.com",
                            EmailConfirmed = true,
                            Firstname = "System",
                            Lastname = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERVISOR@LOCALHOST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGaph5er+bF7mxkCB8TTzz8HvZjBakrwv/DgcozqzftiCHTpKGUh2o0Z7kKJ7i+FDA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3eb93b21-3613-4798-b639-fe96c781f657",
                            TwoFactorEnabled = false,
                            UserName = "SUPERVISOR@LOCALHOST.COM"
                        });
                });

            modelBuilder.Entity("LeaveManagement.Web.Data.LeaveAllocation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeaveType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("LeaveTypeId")
                        .HasColumnType("bigint");

                    b.Property<int>("NumberofDays")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LeaveAllocations");
                });

            modelBuilder.Entity("LeaveManagement.Web.Data.LeaveType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("DefaultDays")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeaveTypes");
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

                    b.HasData(
                        new
                        {
                            Id = "9C3910EA-483A-4057-A30F-07C3B736ACB0",
                            ConcurrencyStamp = "985c2870-59be-451e-b67e-b69ad62f0a39",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
                            ConcurrencyStamp = "8872385b-963d-4b75-a8b6-d7b96d7ed484",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "5D1DBC83-6022-4867-BCA5-7D2E88217056",
                            ConcurrencyStamp = "ce4e298d-b566-4f07-8388-1d56b0d6b571",
                            Name = "Supervisor",
                            NormalizedName = "SUPERVISOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.HasData(
                        new
                        {
                            UserId = "32274BF3-6899-4D73-818A-6B736D71E1B0",
                            RoleId = "9C3910EA-483A-4057-A30F-07C3B736ACB0"
                        },
                        new
                        {
                            UserId = "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                            RoleId = "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16"
                        },
                        new
                        {
                            UserId = "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                            RoleId = "5D1DBC83-6022-4867-BCA5-7D2E88217056"
                        });
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
                    b.HasOne("LeaveManagement.Web.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LeaveManagement.Web.Data.Employee", null)
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

                    b.HasOne("LeaveManagement.Web.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LeaveManagement.Web.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}