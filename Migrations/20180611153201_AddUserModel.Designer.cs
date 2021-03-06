﻿// <auto-generated />
using AngularASPNETCore2WebApiAuth.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AngularASPNETCore2WebApiAuth.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180611153201_AddUserModel")]
    partial class AddUserModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<long?>("FacebookId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PictureUrl");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("DepartmentId");

                    b.HasIndex("CountryId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(300);

                    b.Property<int>("CityId");

                    b.Property<int>("CountryId");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<int>("GenreId");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Password");

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.Property<string>("Photo");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("UserId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("GenreId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.City", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Department", "Department")
                        .WithMany("Cities")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Department", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Country", "Country")
                        .WithMany("Departments")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.User", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Country", "Country")
                        .WithMany("Users")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Department", "Department")
                        .WithMany("Users")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Genre", "Genre")
                        .WithMany("Users")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
