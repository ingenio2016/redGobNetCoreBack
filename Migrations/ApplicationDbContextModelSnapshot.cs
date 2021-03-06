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
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Boss", b =>
                {
                    b.Property<int>("BossId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Association");

                    b.Property<string>("CellPhone")
                        .IsRequired();

                    b.Property<int>("CityId");

                    b.Property<int>("CommuneId");

                    b.Property<int>("CountryId");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Document")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("GenreId");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Latitude")
                        .IsRequired();

                    b.Property<string>("Longitude")
                        .IsRequired();

                    b.Property<string>("Observation");

                    b.Property<string>("Ocupation")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.Property<int>("VotingPlaceId");

                    b.Property<string>("WorkPlace");

                    b.HasKey("BossId");

                    b.HasIndex("CityId");

                    b.HasIndex("CommuneId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("GenreId");

                    b.HasIndex("UserId");

                    b.HasIndex("VotingPlaceId");

                    b.ToTable("Bosses");
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

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Commune", b =>
                {
                    b.Property<int>("CommuneId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityId");

                    b.Property<int>("CountryId");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CommuneId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Communes");
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Coordinator", b =>
                {
                    b.Property<int>("CoordinatorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Association");

                    b.Property<string>("CellPhone")
                        .IsRequired();

                    b.Property<int>("CityId");

                    b.Property<int>("CommuneId");

                    b.Property<int>("CountryId");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Document")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("GenreId");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Latitude")
                        .IsRequired();

                    b.Property<string>("Longitude")
                        .IsRequired();

                    b.Property<string>("Observation");

                    b.Property<string>("Ocupation")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.Property<int>("VotingPlaceId");

                    b.Property<string>("WorkPlace");

                    b.HasKey("CoordinatorId");

                    b.HasIndex("CityId");

                    b.HasIndex("CommuneId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("GenreId");

                    b.HasIndex("UserId");

                    b.HasIndex("VotingPlaceId");

                    b.ToTable("Coordinators");
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

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Leader", b =>
                {
                    b.Property<int>("LeaderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Association");

                    b.Property<string>("CellPhone")
                        .IsRequired();

                    b.Property<int>("CityId");

                    b.Property<int>("CommuneId");

                    b.Property<int>("CountryId");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Document")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("GenreId");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Latitude")
                        .IsRequired();

                    b.Property<string>("Longitude")
                        .IsRequired();

                    b.Property<string>("Observation");

                    b.Property<string>("Ocupation")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.Property<int>("VotingPlaceId");

                    b.Property<string>("WorkPlace");

                    b.HasKey("LeaderId");

                    b.HasIndex("CityId");

                    b.HasIndex("CommuneId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("GenreId");

                    b.HasIndex("UserId");

                    b.HasIndex("VotingPlaceId");

                    b.ToTable("Leaders");
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Link", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Association");

                    b.Property<string>("CellPhone")
                        .IsRequired();

                    b.Property<int>("CityId");

                    b.Property<int>("CommuneId");

                    b.Property<int>("CountryId");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Document")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("GenreId");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Latitude")
                        .IsRequired();

                    b.Property<string>("Longitude")
                        .IsRequired();

                    b.Property<string>("Observation");

                    b.Property<string>("Ocupation")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.Property<int>("VotingPlaceId");

                    b.Property<string>("WorkPlace");

                    b.HasKey("LinkId");

                    b.HasIndex("CityId");

                    b.HasIndex("CommuneId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("GenreId");

                    b.HasIndex("UserId");

                    b.HasIndex("VotingPlaceId");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.RedUser", b =>
                {
                    b.Property<int>("RedUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("RedUserId");

                    b.ToTable("RedUsers");
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

                    b.Property<string>("RoleUser");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("UserId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("GenreId");

                    b.ToTable("DataUsers");
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Voter", b =>
                {
                    b.Property<int>("VoterId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Association");

                    b.Property<string>("CellPhone")
                        .IsRequired();

                    b.Property<int>("CityId");

                    b.Property<int>("CommuneId");

                    b.Property<int>("CountryId");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Document")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("GenreId");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Latitude")
                        .IsRequired();

                    b.Property<string>("Longitude")
                        .IsRequired();

                    b.Property<string>("Observation");

                    b.Property<string>("Ocupation")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.Property<int>("VotingPlaceId");

                    b.Property<string>("WorkPlace");

                    b.HasKey("VoterId");

                    b.HasIndex("CityId");

                    b.HasIndex("CommuneId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("GenreId");

                    b.HasIndex("UserId");

                    b.HasIndex("VotingPlaceId");

                    b.ToTable("Voters");
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.VotingPlace", b =>
                {
                    b.Property<int>("VotingPlaceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityId");

                    b.Property<string>("Code");

                    b.Property<int>("CountryId");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("VotingPlaceId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("VotingPlaces");
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

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Boss", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.City", "City")
                        .WithMany("Bosses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Commune", "Commune")
                        .WithMany("Bosses")
                        .HasForeignKey("CommuneId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Country", "Country")
                        .WithMany("Bosses")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Department", "Department")
                        .WithMany("Bosses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Genre", "Genre")
                        .WithMany("Bosses")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.User", "User")
                        .WithMany("Bosses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.VotingPlace", "VotingPlace")
                        .WithMany("Bosses")
                        .HasForeignKey("VotingPlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
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

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Commune", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.City", "City")
                        .WithMany("Communes")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Country", "Country")
                        .WithMany("Communes")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Department", "Department")
                        .WithMany("Communes")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Coordinator", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.City", "City")
                        .WithMany("Coordinators")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Commune", "Commune")
                        .WithMany("Coordinators")
                        .HasForeignKey("CommuneId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Country", "Country")
                        .WithMany("Coordinators")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Department", "Department")
                        .WithMany("Coordinators")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Genre", "Genre")
                        .WithMany("Coordinators")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.User", "User")
                        .WithMany("Coordinators")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.VotingPlace", "VotingPlace")
                        .WithMany("Coordinators")
                        .HasForeignKey("VotingPlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Department", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Country", "Country")
                        .WithMany("Departments")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Leader", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.City", "City")
                        .WithMany("Leaders")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Commune", "Commune")
                        .WithMany("Leaders")
                        .HasForeignKey("CommuneId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Country", "Country")
                        .WithMany("Leaders")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Department", "Department")
                        .WithMany("Leaders")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Genre", "Genre")
                        .WithMany("Leaders")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.User", "User")
                        .WithMany("Leaders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.VotingPlace", "VotingPlace")
                        .WithMany("Leaders")
                        .HasForeignKey("VotingPlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Link", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.City", "City")
                        .WithMany("Links")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Commune", "Commune")
                        .WithMany("Links")
                        .HasForeignKey("CommuneId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Country", "Country")
                        .WithMany("Links")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Department", "Department")
                        .WithMany("Links")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Genre", "Genre")
                        .WithMany("Links")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.User", "User")
                        .WithMany("Links")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.VotingPlace", "VotingPlace")
                        .WithMany("Links")
                        .HasForeignKey("VotingPlaceId")
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

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.Voter", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.City", "City")
                        .WithMany("Voters")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Commune", "Commune")
                        .WithMany("Voters")
                        .HasForeignKey("CommuneId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Country", "Country")
                        .WithMany("Voters")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Department", "Department")
                        .WithMany("Voters")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Genre", "Genre")
                        .WithMany("Voters")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.User", "User")
                        .WithMany("Voters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.VotingPlace", "VotingPlace")
                        .WithMany("Voters")
                        .HasForeignKey("VotingPlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AngularASPNETCore2WebApiAuth.Models.Entities.VotingPlace", b =>
                {
                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.City", "City")
                        .WithMany("VotingPlaces")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Country", "Country")
                        .WithMany("VotingPlaces")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngularASPNETCore2WebApiAuth.Models.Entities.Department", "Department")
                        .WithMany("VotingPlaces")
                        .HasForeignKey("DepartmentId")
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
