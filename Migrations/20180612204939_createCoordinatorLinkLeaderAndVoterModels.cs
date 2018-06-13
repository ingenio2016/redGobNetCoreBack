using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AngularASPNETCore2WebApiAuth.Migrations
{
    public partial class createCoordinatorLinkLeaderAndVoterModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bosses");

            migrationBuilder.CreateTable(
                name: "Boss",
                columns: table => new
                {
                    BossId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Association = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhone = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CommuneId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Document = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    VotingPlaceId = table.Column<int>(type: "int", nullable: false),
                    WorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boss", x => x.BossId);
                    table.ForeignKey(
                        name: "FK_Boss_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Boss_Communes_CommuneId",
                        column: x => x.CommuneId,
                        principalTable: "Communes",
                        principalColumn: "CommuneId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Boss_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Boss_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Boss_DataUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "DataUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Boss_VotingPlaces_VotingPlaceId",
                        column: x => x.VotingPlaceId,
                        principalTable: "VotingPlaces",
                        principalColumn: "VotingPlaceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Coordinator",
                columns: table => new
                {
                    CoordinatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Association = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhone = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CommuneId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Document = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    VotingPlaceId = table.Column<int>(type: "int", nullable: false),
                    WorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinator", x => x.CoordinatorId);
                    table.ForeignKey(
                        name: "FK_Coordinator_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Coordinator_Communes_CommuneId",
                        column: x => x.CommuneId,
                        principalTable: "Communes",
                        principalColumn: "CommuneId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Coordinator_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Coordinator_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Coordinator_DataUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "DataUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Coordinator_VotingPlaces_VotingPlaceId",
                        column: x => x.VotingPlaceId,
                        principalTable: "VotingPlaces",
                        principalColumn: "VotingPlaceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Leader",
                columns: table => new
                {
                    LeaderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Association = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhone = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CommuneId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Document = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    VotingPlaceId = table.Column<int>(type: "int", nullable: false),
                    WorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leader", x => x.LeaderId);
                    table.ForeignKey(
                        name: "FK_Leader_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Leader_Communes_CommuneId",
                        column: x => x.CommuneId,
                        principalTable: "Communes",
                        principalColumn: "CommuneId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Leader_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Leader_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Leader_DataUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "DataUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Leader_VotingPlaces_VotingPlaceId",
                        column: x => x.VotingPlaceId,
                        principalTable: "VotingPlaces",
                        principalColumn: "VotingPlaceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Link",
                columns: table => new
                {
                    LinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Association = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhone = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CommuneId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Document = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    VotingPlaceId = table.Column<int>(type: "int", nullable: false),
                    WorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link", x => x.LinkId);
                    table.ForeignKey(
                        name: "FK_Link_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Link_Communes_CommuneId",
                        column: x => x.CommuneId,
                        principalTable: "Communes",
                        principalColumn: "CommuneId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Link_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Link_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Link_DataUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "DataUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Link_VotingPlaces_VotingPlaceId",
                        column: x => x.VotingPlaceId,
                        principalTable: "VotingPlaces",
                        principalColumn: "VotingPlaceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Voter",
                columns: table => new
                {
                    LeaderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Association = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhone = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CommuneId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Document = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    VotingPlaceId = table.Column<int>(type: "int", nullable: false),
                    WorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voter", x => x.LeaderId);
                    table.ForeignKey(
                        name: "FK_Voter_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Voter_Communes_CommuneId",
                        column: x => x.CommuneId,
                        principalTable: "Communes",
                        principalColumn: "CommuneId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Voter_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Voter_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Voter_DataUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "DataUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Voter_VotingPlaces_VotingPlaceId",
                        column: x => x.VotingPlaceId,
                        principalTable: "VotingPlaces",
                        principalColumn: "VotingPlaceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boss_CityId",
                table: "Boss",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Boss_CommuneId",
                table: "Boss",
                column: "CommuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Boss_CountryId",
                table: "Boss",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Boss_DepartmentId",
                table: "Boss",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Boss_UserId",
                table: "Boss",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Boss_VotingPlaceId",
                table: "Boss",
                column: "VotingPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinator_CityId",
                table: "Coordinator",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinator_CommuneId",
                table: "Coordinator",
                column: "CommuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinator_CountryId",
                table: "Coordinator",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinator_DepartmentId",
                table: "Coordinator",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinator_UserId",
                table: "Coordinator",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinator_VotingPlaceId",
                table: "Coordinator",
                column: "VotingPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Leader_CityId",
                table: "Leader",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Leader_CommuneId",
                table: "Leader",
                column: "CommuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Leader_CountryId",
                table: "Leader",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Leader_DepartmentId",
                table: "Leader",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Leader_UserId",
                table: "Leader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Leader_VotingPlaceId",
                table: "Leader",
                column: "VotingPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_CityId",
                table: "Link",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_CommuneId",
                table: "Link",
                column: "CommuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_CountryId",
                table: "Link",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_DepartmentId",
                table: "Link",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_UserId",
                table: "Link",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_VotingPlaceId",
                table: "Link",
                column: "VotingPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Voter_CityId",
                table: "Voter",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Voter_CommuneId",
                table: "Voter",
                column: "CommuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Voter_CountryId",
                table: "Voter",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Voter_DepartmentId",
                table: "Voter",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Voter_UserId",
                table: "Voter",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Voter_VotingPlaceId",
                table: "Voter",
                column: "VotingPlaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boss");

            migrationBuilder.DropTable(
                name: "Coordinator");

            migrationBuilder.DropTable(
                name: "Leader");

            migrationBuilder.DropTable(
                name: "Link");

            migrationBuilder.DropTable(
                name: "Voter");

            migrationBuilder.CreateTable(
                name: "Bosses",
                columns: table => new
                {
                    BossId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    Association = table.Column<string>(nullable: true),
                    CellPhone = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    CommuneId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    Document = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Latitude = table.Column<string>(nullable: false),
                    Longitude = table.Column<string>(nullable: false),
                    Observation = table.Column<string>(nullable: true),
                    Ocupation = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    VotingPlaceId = table.Column<int>(nullable: false),
                    WorkPlace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bosses", x => x.BossId);
                    table.ForeignKey(
                        name: "FK_Bosses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Bosses_Communes_CommuneId",
                        column: x => x.CommuneId,
                        principalTable: "Communes",
                        principalColumn: "CommuneId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Bosses_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Bosses_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Bosses_VotingPlaces_VotingPlaceId",
                        column: x => x.VotingPlaceId,
                        principalTable: "VotingPlaces",
                        principalColumn: "VotingPlaceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bosses_CityId",
                table: "Bosses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bosses_CommuneId",
                table: "Bosses",
                column: "CommuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Bosses_CountryId",
                table: "Bosses",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Bosses_DepartmentId",
                table: "Bosses",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bosses_VotingPlaceId",
                table: "Bosses",
                column: "VotingPlaceId");
        }
    }
}
