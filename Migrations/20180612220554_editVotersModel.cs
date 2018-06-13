using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AngularASPNETCore2WebApiAuth.Migrations
{
    public partial class editVotersModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boss_Cities_CityId",
                table: "Boss");

            migrationBuilder.DropForeignKey(
                name: "FK_Boss_Communes_CommuneId",
                table: "Boss");

            migrationBuilder.DropForeignKey(
                name: "FK_Boss_Countries_CountryId",
                table: "Boss");

            migrationBuilder.DropForeignKey(
                name: "FK_Boss_Departments_DepartmentId",
                table: "Boss");

            migrationBuilder.DropForeignKey(
                name: "FK_Boss_DataUsers_UserId",
                table: "Boss");

            migrationBuilder.DropForeignKey(
                name: "FK_Boss_VotingPlaces_VotingPlaceId",
                table: "Boss");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinator_Cities_CityId",
                table: "Coordinator");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinator_Communes_CommuneId",
                table: "Coordinator");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinator_Countries_CountryId",
                table: "Coordinator");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinator_Departments_DepartmentId",
                table: "Coordinator");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinator_DataUsers_UserId",
                table: "Coordinator");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinator_VotingPlaces_VotingPlaceId",
                table: "Coordinator");

            migrationBuilder.DropForeignKey(
                name: "FK_Leader_Cities_CityId",
                table: "Leader");

            migrationBuilder.DropForeignKey(
                name: "FK_Leader_Communes_CommuneId",
                table: "Leader");

            migrationBuilder.DropForeignKey(
                name: "FK_Leader_Countries_CountryId",
                table: "Leader");

            migrationBuilder.DropForeignKey(
                name: "FK_Leader_Departments_DepartmentId",
                table: "Leader");

            migrationBuilder.DropForeignKey(
                name: "FK_Leader_DataUsers_UserId",
                table: "Leader");

            migrationBuilder.DropForeignKey(
                name: "FK_Leader_VotingPlaces_VotingPlaceId",
                table: "Leader");

            migrationBuilder.DropForeignKey(
                name: "FK_Link_Cities_CityId",
                table: "Link");

            migrationBuilder.DropForeignKey(
                name: "FK_Link_Communes_CommuneId",
                table: "Link");

            migrationBuilder.DropForeignKey(
                name: "FK_Link_Countries_CountryId",
                table: "Link");

            migrationBuilder.DropForeignKey(
                name: "FK_Link_Departments_DepartmentId",
                table: "Link");

            migrationBuilder.DropForeignKey(
                name: "FK_Link_DataUsers_UserId",
                table: "Link");

            migrationBuilder.DropForeignKey(
                name: "FK_Link_VotingPlaces_VotingPlaceId",
                table: "Link");

            migrationBuilder.DropForeignKey(
                name: "FK_Voter_Cities_CityId",
                table: "Voter");

            migrationBuilder.DropForeignKey(
                name: "FK_Voter_Communes_CommuneId",
                table: "Voter");

            migrationBuilder.DropForeignKey(
                name: "FK_Voter_Countries_CountryId",
                table: "Voter");

            migrationBuilder.DropForeignKey(
                name: "FK_Voter_Departments_DepartmentId",
                table: "Voter");

            migrationBuilder.DropForeignKey(
                name: "FK_Voter_DataUsers_UserId",
                table: "Voter");

            migrationBuilder.DropForeignKey(
                name: "FK_Voter_VotingPlaces_VotingPlaceId",
                table: "Voter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voter",
                table: "Voter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Link",
                table: "Link");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leader",
                table: "Leader");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coordinator",
                table: "Coordinator");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Boss",
                table: "Boss");

            migrationBuilder.DropColumn(
                name: "LeaderId",
                table: "Voter");

            migrationBuilder.RenameTable(
                name: "Voter",
                newName: "Voters");

            migrationBuilder.RenameTable(
                name: "Link",
                newName: "Links");

            migrationBuilder.RenameTable(
                name: "Leader",
                newName: "Leaders");

            migrationBuilder.RenameTable(
                name: "Coordinator",
                newName: "Coordinators");

            migrationBuilder.RenameTable(
                name: "Boss",
                newName: "Bosses");

            migrationBuilder.RenameIndex(
                name: "IX_Voter_VotingPlaceId",
                table: "Voters",
                newName: "IX_Voters_VotingPlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Voter_UserId",
                table: "Voters",
                newName: "IX_Voters_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Voter_DepartmentId",
                table: "Voters",
                newName: "IX_Voters_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Voter_CountryId",
                table: "Voters",
                newName: "IX_Voters_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Voter_CommuneId",
                table: "Voters",
                newName: "IX_Voters_CommuneId");

            migrationBuilder.RenameIndex(
                name: "IX_Voter_CityId",
                table: "Voters",
                newName: "IX_Voters_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Link_VotingPlaceId",
                table: "Links",
                newName: "IX_Links_VotingPlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Link_UserId",
                table: "Links",
                newName: "IX_Links_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Link_DepartmentId",
                table: "Links",
                newName: "IX_Links_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Link_CountryId",
                table: "Links",
                newName: "IX_Links_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Link_CommuneId",
                table: "Links",
                newName: "IX_Links_CommuneId");

            migrationBuilder.RenameIndex(
                name: "IX_Link_CityId",
                table: "Links",
                newName: "IX_Links_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Leader_VotingPlaceId",
                table: "Leaders",
                newName: "IX_Leaders_VotingPlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Leader_UserId",
                table: "Leaders",
                newName: "IX_Leaders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Leader_DepartmentId",
                table: "Leaders",
                newName: "IX_Leaders_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Leader_CountryId",
                table: "Leaders",
                newName: "IX_Leaders_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Leader_CommuneId",
                table: "Leaders",
                newName: "IX_Leaders_CommuneId");

            migrationBuilder.RenameIndex(
                name: "IX_Leader_CityId",
                table: "Leaders",
                newName: "IX_Leaders_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Coordinator_VotingPlaceId",
                table: "Coordinators",
                newName: "IX_Coordinators_VotingPlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Coordinator_UserId",
                table: "Coordinators",
                newName: "IX_Coordinators_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Coordinator_DepartmentId",
                table: "Coordinators",
                newName: "IX_Coordinators_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Coordinator_CountryId",
                table: "Coordinators",
                newName: "IX_Coordinators_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Coordinator_CommuneId",
                table: "Coordinators",
                newName: "IX_Coordinators_CommuneId");

            migrationBuilder.RenameIndex(
                name: "IX_Coordinator_CityId",
                table: "Coordinators",
                newName: "IX_Coordinators_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Boss_VotingPlaceId",
                table: "Bosses",
                newName: "IX_Bosses_VotingPlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Boss_UserId",
                table: "Bosses",
                newName: "IX_Bosses_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Boss_DepartmentId",
                table: "Bosses",
                newName: "IX_Bosses_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Boss_CountryId",
                table: "Bosses",
                newName: "IX_Bosses_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Boss_CommuneId",
                table: "Bosses",
                newName: "IX_Bosses_CommuneId");

            migrationBuilder.RenameIndex(
                name: "IX_Boss_CityId",
                table: "Bosses",
                newName: "IX_Bosses_CityId");

            migrationBuilder.AddColumn<int>(
                name: "VoterId",
                table: "Voters",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voters",
                table: "Voters",
                column: "VoterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Links",
                table: "Links",
                column: "LinkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leaders",
                table: "Leaders",
                column: "LeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coordinators",
                table: "Coordinators",
                column: "CoordinatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bosses",
                table: "Bosses",
                column: "BossId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bosses_Cities_CityId",
                table: "Bosses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Bosses_Communes_CommuneId",
                table: "Bosses",
                column: "CommuneId",
                principalTable: "Communes",
                principalColumn: "CommuneId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Bosses_Countries_CountryId",
                table: "Bosses",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Bosses_Departments_DepartmentId",
                table: "Bosses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Bosses_DataUsers_UserId",
                table: "Bosses",
                column: "UserId",
                principalTable: "DataUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Bosses_VotingPlaces_VotingPlaceId",
                table: "Bosses",
                column: "VotingPlaceId",
                principalTable: "VotingPlaces",
                principalColumn: "VotingPlaceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinators_Cities_CityId",
                table: "Coordinators",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinators_Communes_CommuneId",
                table: "Coordinators",
                column: "CommuneId",
                principalTable: "Communes",
                principalColumn: "CommuneId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinators_Countries_CountryId",
                table: "Coordinators",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinators_Departments_DepartmentId",
                table: "Coordinators",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinators_DataUsers_UserId",
                table: "Coordinators",
                column: "UserId",
                principalTable: "DataUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinators_VotingPlaces_VotingPlaceId",
                table: "Coordinators",
                column: "VotingPlaceId",
                principalTable: "VotingPlaces",
                principalColumn: "VotingPlaceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leaders_Cities_CityId",
                table: "Leaders",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leaders_Communes_CommuneId",
                table: "Leaders",
                column: "CommuneId",
                principalTable: "Communes",
                principalColumn: "CommuneId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leaders_Countries_CountryId",
                table: "Leaders",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leaders_Departments_DepartmentId",
                table: "Leaders",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leaders_DataUsers_UserId",
                table: "Leaders",
                column: "UserId",
                principalTable: "DataUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leaders_VotingPlaces_VotingPlaceId",
                table: "Leaders",
                column: "VotingPlaceId",
                principalTable: "VotingPlaces",
                principalColumn: "VotingPlaceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Cities_CityId",
                table: "Links",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Communes_CommuneId",
                table: "Links",
                column: "CommuneId",
                principalTable: "Communes",
                principalColumn: "CommuneId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Countries_CountryId",
                table: "Links",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Departments_DepartmentId",
                table: "Links",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_DataUsers_UserId",
                table: "Links",
                column: "UserId",
                principalTable: "DataUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_VotingPlaces_VotingPlaceId",
                table: "Links",
                column: "VotingPlaceId",
                principalTable: "VotingPlaces",
                principalColumn: "VotingPlaceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Voters_Cities_CityId",
                table: "Voters",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Voters_Communes_CommuneId",
                table: "Voters",
                column: "CommuneId",
                principalTable: "Communes",
                principalColumn: "CommuneId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Voters_Countries_CountryId",
                table: "Voters",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Voters_Departments_DepartmentId",
                table: "Voters",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Voters_DataUsers_UserId",
                table: "Voters",
                column: "UserId",
                principalTable: "DataUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Voters_VotingPlaces_VotingPlaceId",
                table: "Voters",
                column: "VotingPlaceId",
                principalTable: "VotingPlaces",
                principalColumn: "VotingPlaceId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bosses_Cities_CityId",
                table: "Bosses");

            migrationBuilder.DropForeignKey(
                name: "FK_Bosses_Communes_CommuneId",
                table: "Bosses");

            migrationBuilder.DropForeignKey(
                name: "FK_Bosses_Countries_CountryId",
                table: "Bosses");

            migrationBuilder.DropForeignKey(
                name: "FK_Bosses_Departments_DepartmentId",
                table: "Bosses");

            migrationBuilder.DropForeignKey(
                name: "FK_Bosses_DataUsers_UserId",
                table: "Bosses");

            migrationBuilder.DropForeignKey(
                name: "FK_Bosses_VotingPlaces_VotingPlaceId",
                table: "Bosses");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinators_Cities_CityId",
                table: "Coordinators");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinators_Communes_CommuneId",
                table: "Coordinators");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinators_Countries_CountryId",
                table: "Coordinators");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinators_Departments_DepartmentId",
                table: "Coordinators");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinators_DataUsers_UserId",
                table: "Coordinators");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinators_VotingPlaces_VotingPlaceId",
                table: "Coordinators");

            migrationBuilder.DropForeignKey(
                name: "FK_Leaders_Cities_CityId",
                table: "Leaders");

            migrationBuilder.DropForeignKey(
                name: "FK_Leaders_Communes_CommuneId",
                table: "Leaders");

            migrationBuilder.DropForeignKey(
                name: "FK_Leaders_Countries_CountryId",
                table: "Leaders");

            migrationBuilder.DropForeignKey(
                name: "FK_Leaders_Departments_DepartmentId",
                table: "Leaders");

            migrationBuilder.DropForeignKey(
                name: "FK_Leaders_DataUsers_UserId",
                table: "Leaders");

            migrationBuilder.DropForeignKey(
                name: "FK_Leaders_VotingPlaces_VotingPlaceId",
                table: "Leaders");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Cities_CityId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Communes_CommuneId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Countries_CountryId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Departments_DepartmentId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_DataUsers_UserId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_VotingPlaces_VotingPlaceId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Voters_Cities_CityId",
                table: "Voters");

            migrationBuilder.DropForeignKey(
                name: "FK_Voters_Communes_CommuneId",
                table: "Voters");

            migrationBuilder.DropForeignKey(
                name: "FK_Voters_Countries_CountryId",
                table: "Voters");

            migrationBuilder.DropForeignKey(
                name: "FK_Voters_Departments_DepartmentId",
                table: "Voters");

            migrationBuilder.DropForeignKey(
                name: "FK_Voters_DataUsers_UserId",
                table: "Voters");

            migrationBuilder.DropForeignKey(
                name: "FK_Voters_VotingPlaces_VotingPlaceId",
                table: "Voters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voters",
                table: "Voters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Links",
                table: "Links");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leaders",
                table: "Leaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coordinators",
                table: "Coordinators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bosses",
                table: "Bosses");

            migrationBuilder.DropColumn(
                name: "VoterId",
                table: "Voters");

            migrationBuilder.RenameTable(
                name: "Voters",
                newName: "Voter");

            migrationBuilder.RenameTable(
                name: "Links",
                newName: "Link");

            migrationBuilder.RenameTable(
                name: "Leaders",
                newName: "Leader");

            migrationBuilder.RenameTable(
                name: "Coordinators",
                newName: "Coordinator");

            migrationBuilder.RenameTable(
                name: "Bosses",
                newName: "Boss");

            migrationBuilder.RenameIndex(
                name: "IX_Voters_VotingPlaceId",
                table: "Voter",
                newName: "IX_Voter_VotingPlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Voters_UserId",
                table: "Voter",
                newName: "IX_Voter_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Voters_DepartmentId",
                table: "Voter",
                newName: "IX_Voter_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Voters_CountryId",
                table: "Voter",
                newName: "IX_Voter_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Voters_CommuneId",
                table: "Voter",
                newName: "IX_Voter_CommuneId");

            migrationBuilder.RenameIndex(
                name: "IX_Voters_CityId",
                table: "Voter",
                newName: "IX_Voter_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Links_VotingPlaceId",
                table: "Link",
                newName: "IX_Link_VotingPlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Links_UserId",
                table: "Link",
                newName: "IX_Link_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Links_DepartmentId",
                table: "Link",
                newName: "IX_Link_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Links_CountryId",
                table: "Link",
                newName: "IX_Link_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Links_CommuneId",
                table: "Link",
                newName: "IX_Link_CommuneId");

            migrationBuilder.RenameIndex(
                name: "IX_Links_CityId",
                table: "Link",
                newName: "IX_Link_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Leaders_VotingPlaceId",
                table: "Leader",
                newName: "IX_Leader_VotingPlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Leaders_UserId",
                table: "Leader",
                newName: "IX_Leader_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Leaders_DepartmentId",
                table: "Leader",
                newName: "IX_Leader_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Leaders_CountryId",
                table: "Leader",
                newName: "IX_Leader_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Leaders_CommuneId",
                table: "Leader",
                newName: "IX_Leader_CommuneId");

            migrationBuilder.RenameIndex(
                name: "IX_Leaders_CityId",
                table: "Leader",
                newName: "IX_Leader_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Coordinators_VotingPlaceId",
                table: "Coordinator",
                newName: "IX_Coordinator_VotingPlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Coordinators_UserId",
                table: "Coordinator",
                newName: "IX_Coordinator_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Coordinators_DepartmentId",
                table: "Coordinator",
                newName: "IX_Coordinator_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Coordinators_CountryId",
                table: "Coordinator",
                newName: "IX_Coordinator_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Coordinators_CommuneId",
                table: "Coordinator",
                newName: "IX_Coordinator_CommuneId");

            migrationBuilder.RenameIndex(
                name: "IX_Coordinators_CityId",
                table: "Coordinator",
                newName: "IX_Coordinator_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Bosses_VotingPlaceId",
                table: "Boss",
                newName: "IX_Boss_VotingPlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Bosses_UserId",
                table: "Boss",
                newName: "IX_Boss_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Bosses_DepartmentId",
                table: "Boss",
                newName: "IX_Boss_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Bosses_CountryId",
                table: "Boss",
                newName: "IX_Boss_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Bosses_CommuneId",
                table: "Boss",
                newName: "IX_Boss_CommuneId");

            migrationBuilder.RenameIndex(
                name: "IX_Bosses_CityId",
                table: "Boss",
                newName: "IX_Boss_CityId");

            migrationBuilder.AddColumn<int>(
                name: "LeaderId",
                table: "Voter",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voter",
                table: "Voter",
                column: "LeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Link",
                table: "Link",
                column: "LinkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leader",
                table: "Leader",
                column: "LeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coordinator",
                table: "Coordinator",
                column: "CoordinatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Boss",
                table: "Boss",
                column: "BossId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boss_Cities_CityId",
                table: "Boss",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Boss_Communes_CommuneId",
                table: "Boss",
                column: "CommuneId",
                principalTable: "Communes",
                principalColumn: "CommuneId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Boss_Countries_CountryId",
                table: "Boss",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Boss_Departments_DepartmentId",
                table: "Boss",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Boss_DataUsers_UserId",
                table: "Boss",
                column: "UserId",
                principalTable: "DataUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Boss_VotingPlaces_VotingPlaceId",
                table: "Boss",
                column: "VotingPlaceId",
                principalTable: "VotingPlaces",
                principalColumn: "VotingPlaceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinator_Cities_CityId",
                table: "Coordinator",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinator_Communes_CommuneId",
                table: "Coordinator",
                column: "CommuneId",
                principalTable: "Communes",
                principalColumn: "CommuneId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinator_Countries_CountryId",
                table: "Coordinator",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinator_Departments_DepartmentId",
                table: "Coordinator",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinator_DataUsers_UserId",
                table: "Coordinator",
                column: "UserId",
                principalTable: "DataUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinator_VotingPlaces_VotingPlaceId",
                table: "Coordinator",
                column: "VotingPlaceId",
                principalTable: "VotingPlaces",
                principalColumn: "VotingPlaceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leader_Cities_CityId",
                table: "Leader",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leader_Communes_CommuneId",
                table: "Leader",
                column: "CommuneId",
                principalTable: "Communes",
                principalColumn: "CommuneId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leader_Countries_CountryId",
                table: "Leader",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leader_Departments_DepartmentId",
                table: "Leader",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leader_DataUsers_UserId",
                table: "Leader",
                column: "UserId",
                principalTable: "DataUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leader_VotingPlaces_VotingPlaceId",
                table: "Leader",
                column: "VotingPlaceId",
                principalTable: "VotingPlaces",
                principalColumn: "VotingPlaceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Link_Cities_CityId",
                table: "Link",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Link_Communes_CommuneId",
                table: "Link",
                column: "CommuneId",
                principalTable: "Communes",
                principalColumn: "CommuneId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Link_Countries_CountryId",
                table: "Link",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Link_Departments_DepartmentId",
                table: "Link",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Link_DataUsers_UserId",
                table: "Link",
                column: "UserId",
                principalTable: "DataUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Link_VotingPlaces_VotingPlaceId",
                table: "Link",
                column: "VotingPlaceId",
                principalTable: "VotingPlaces",
                principalColumn: "VotingPlaceId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Voter_Cities_CityId",
                table: "Voter",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Voter_Communes_CommuneId",
                table: "Voter",
                column: "CommuneId",
                principalTable: "Communes",
                principalColumn: "CommuneId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Voter_Countries_CountryId",
                table: "Voter",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Voter_Departments_DepartmentId",
                table: "Voter",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Voter_DataUsers_UserId",
                table: "Voter",
                column: "UserId",
                principalTable: "DataUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Voter_VotingPlaces_VotingPlaceId",
                table: "Voter",
                column: "VotingPlaceId",
                principalTable: "VotingPlaces",
                principalColumn: "VotingPlaceId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
