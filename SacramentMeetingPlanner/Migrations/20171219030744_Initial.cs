using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlannedMeeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClosingSong = table.Column<string>(maxLength: 30, nullable: false),
                    Conductor = table.Column<string>(maxLength: 30, nullable: false),
                    EndPrayer = table.Column<string>(maxLength: 30, nullable: false),
                    MeetingDate = table.Column<DateTime>(nullable: false),
                    OpenningSong = table.Column<string>(maxLength: 30, nullable: false),
                    OptionalSong = table.Column<string>(maxLength: 30, nullable: true),
                    SacramentSong = table.Column<string>(maxLength: 30, nullable: false),
                    SpeakerFive = table.Column<string>(maxLength: 30, nullable: true),
                    SpeakerFour = table.Column<string>(maxLength: 30, nullable: true),
                    SpeakerOne = table.Column<string>(maxLength: 30, nullable: true),
                    SpeakerThree = table.Column<string>(maxLength: 30, nullable: true),
                    SpeakerTwo = table.Column<string>(maxLength: 30, nullable: true),
                    StartPrayer = table.Column<string>(maxLength: 30, nullable: false),
                    TopicFive = table.Column<string>(maxLength: 30, nullable: true),
                    TopicFour = table.Column<string>(maxLength: 30, nullable: true),
                    TopicOne = table.Column<string>(maxLength: 30, nullable: true),
                    TopicThree = table.Column<string>(maxLength: 30, nullable: true),
                    TopicTwo = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedMeeting", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlannedMeeting");
        }
    }
}
