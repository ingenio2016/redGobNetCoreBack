using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AngularASPNETCore2WebApiAuth.Migrations
{
    public partial class addGenreIdToAllModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Voters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Links",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Leaders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Coordinators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Bosses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Voters_GenreId",
                table: "Voters",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_GenreId",
                table: "Links",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaders_GenreId",
                table: "Leaders",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinators_GenreId",
                table: "Coordinators",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Bosses_GenreId",
                table: "Bosses",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bosses_Genres_GenreId",
                table: "Bosses",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinators_Genres_GenreId",
                table: "Coordinators",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leaders_Genres_GenreId",
                table: "Leaders",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Genres_GenreId",
                table: "Links",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Voters_Genres_GenreId",
                table: "Voters",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bosses_Genres_GenreId",
                table: "Bosses");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinators_Genres_GenreId",
                table: "Coordinators");

            migrationBuilder.DropForeignKey(
                name: "FK_Leaders_Genres_GenreId",
                table: "Leaders");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Genres_GenreId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Voters_Genres_GenreId",
                table: "Voters");

            migrationBuilder.DropIndex(
                name: "IX_Voters_GenreId",
                table: "Voters");

            migrationBuilder.DropIndex(
                name: "IX_Links_GenreId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Leaders_GenreId",
                table: "Leaders");

            migrationBuilder.DropIndex(
                name: "IX_Coordinators_GenreId",
                table: "Coordinators");

            migrationBuilder.DropIndex(
                name: "IX_Bosses_GenreId",
                table: "Bosses");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Voters");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Leaders");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Coordinators");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Bosses");
        }
    }
}
