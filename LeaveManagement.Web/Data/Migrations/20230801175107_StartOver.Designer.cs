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
    [Migration("20230801175107_StartOver")]
    partial class StartOver
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
                            ConcurrencyStamp = "97aeb8c9-379e-4300-afcc-c4030afa131c",
                            DateJoined = new DateTime(2023, 8, 1, 13, 51, 6, 894, DateTimeKind.Local).AddTicks(3303),
                            DateofBirth = new DateTime(2023, 8, 1, 13, 51, 6, 894, DateTimeKind.Local).AddTicks(3269),
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            Firstname = "System",
                            Lastname = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAbXmRpuQohkeuqgPOg6xGj+eHG8Afgc9Z6Hct3b6nylk18GRKLdsHY1TzUGxEyPSg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "54723b4e-466d-49ae-9e0b-36f041d1c75f",
                            TwoFactorEnabled = false,
                            UserName = "ADMIN@LOCALHOST.COM"
                        },
                        new
                        {
                            Id = "7ca79698-5c1b-43c9-937c-d91b68b79e93",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0fbf7a71-bed1-4050-9aca-8d8cc25f01ff",
                            DateJoined = new DateTime(2023, 8, 1, 13, 51, 6, 901, DateTimeKind.Local).AddTicks(9469),
                            DateofBirth = new DateTime(2023, 8, 1, 13, 51, 6, 901, DateTimeKind.Local).AddTicks(9443),
                            Email = "user@localhost.com",
                            EmailConfirmed = true,
                            Firstname = "System",
                            Lastname = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@LOCALHOST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGonZ8r6uPm6TBLLijXEleuFc68P7oI9yLUmOp3P6zMVP3JYQwlga9F2xpYxERDH+A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "729afb57-f7c9-499e-a37f-37a04d5887b2",
                            TwoFactorEnabled = false,
                            UserName = "ADMIN@LOCALHOST.COM"
                        },
                        new
                        {
                            Id = "6DA8BD90-197F-4B57-92A8-5DB1E912F01A",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ea2c47e8-74f4-4517-abde-eb4e17af0d53",
                            DateJoined = new DateTime(2023, 8, 1, 13, 51, 6, 908, DateTimeKind.Local).AddTicks(9334),
                            DateofBirth = new DateTime(2023, 8, 1, 13, 51, 6, 908, DateTimeKind.Local).AddTicks(9329),
                            Email = "supervisor@localhost.com",
                            EmailConfirmed = true,
                            Firstname = "System",
                            Lastname = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERVISOR@LOCALHOST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBp9lQfJy5CiTCstRgy7hF3BUryvpotNL9nz7Z1HFvondeJEgPU8SLyLOWuFs2l5ag==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dbedc144-4a92-446f-a6fc-08fe3624b2b0",
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

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LeaveType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("LeaveTypeId")
                        .HasColumnType("bigint");

                    b.Property<int>("NumberofDays")
                        .HasColumnType("int");

                    b.Property<int>("Period")
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
                            ConcurrencyStamp = "476b260a-7936-4933-88b5-bcb7a1d7ad02",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "F50E2E17-3B12-4EF1-90AB-EC5AB5C26B16",
                            ConcurrencyStamp = "57439b12-ca61-4b45-8e20-8376f4cdbdd9",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "5D1DBC83-6022-4867-BCA5-7D2E88217056",
                            ConcurrencyStamp = "9b8d75e5-ed0d-4a15-a1d3-b54ed5c6f420",
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
                            UserId = "6DA8BD90-197F-4B57-92A8-5DB1E912F01A",
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
