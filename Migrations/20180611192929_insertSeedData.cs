using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AngularASPNETCore2WebApiAuth.Migrations
{
    public partial class insertSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cities_CityId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_CountryId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Genres_GenreId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "DataUsers");

            migrationBuilder.RenameIndex(
                name: "IX_Users_GenreId",
                table: "DataUsers",
                newName: "IX_DataUsers_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_DepartmentId",
                table: "DataUsers",
                newName: "IX_DataUsers_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CountryId",
                table: "DataUsers",
                newName: "IX_DataUsers_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CityId",
                table: "DataUsers",
                newName: "IX_DataUsers_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataUsers",
                table: "DataUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataUsers_Cities_CityId",
                table: "DataUsers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_DataUsers_Countries_CountryId",
                table: "DataUsers",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_DataUsers_Departments_DepartmentId",
                table: "DataUsers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_DataUsers_Genres_GenreId",
                table: "DataUsers",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataUsers_Cities_CityId",
                table: "DataUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_DataUsers_Countries_CountryId",
                table: "DataUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_DataUsers_Departments_DepartmentId",
                table: "DataUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_DataUsers_Genres_GenreId",
                table: "DataUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DataUsers",
                table: "DataUsers");

            migrationBuilder.RenameTable(
                name: "DataUsers",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_DataUsers_GenreId",
                table: "Users",
                newName: "IX_Users_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_DataUsers_DepartmentId",
                table: "Users",
                newName: "IX_Users_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_DataUsers_CountryId",
                table: "Users",
                newName: "IX_Users_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_DataUsers_CityId",
                table: "Users",
                newName: "IX_Users_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cities_CityId",
                table: "Users",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_CountryId",
                table: "Users",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Genres_GenreId",
                table: "Users",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
