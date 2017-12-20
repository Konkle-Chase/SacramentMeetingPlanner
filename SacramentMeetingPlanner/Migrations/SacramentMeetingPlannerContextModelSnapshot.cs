﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SacramentMeetingPlanner.Models;
using System;

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SacramentMeetingPlannerContext))]
    partial class SacramentMeetingPlannerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentMeetingPlanner.Models.PlannedMeeting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClosingSong")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Conductor")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("EndPrayer")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("MeetingDate");

                    b.Property<string>("OpenningSong")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("OptionalSong")
                        .HasMaxLength(30);

                    b.Property<string>("SacramentSong")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("SpeakerFive")
                        .HasMaxLength(30);

                    b.Property<string>("SpeakerFour")
                        .HasMaxLength(30);

                    b.Property<string>("SpeakerOne")
                        .HasMaxLength(30);

                    b.Property<string>("SpeakerThree")
                        .HasMaxLength(30);

                    b.Property<string>("SpeakerTwo")
                        .HasMaxLength(30);

                    b.Property<string>("StartPrayer")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("TopicFive")
                        .HasMaxLength(30);

                    b.Property<string>("TopicFour")
                        .HasMaxLength(30);

                    b.Property<string>("TopicOne")
                        .HasMaxLength(30);

                    b.Property<string>("TopicThree")
                        .HasMaxLength(30);

                    b.Property<string>("TopicTwo")
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.ToTable("PlannedMeeting");
                });
#pragma warning restore 612, 618
        }
    }
}