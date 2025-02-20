﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OS_GJ_Tutoring.Data;

#nullable disable

namespace OS_GJ_Tutoring.Migrations
{
    [DbContext(typeof(OS_GJ_TutoringContext))]
    [Migration("20250120160357_StayCreate")]
    partial class StayCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OS_GJ_Tutoring.Models.BookDB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TicketeightQty")
                        .HasColumnType("int");

                    b.Property<int?>("TicketfiveQty")
                        .HasColumnType("int");

                    b.Property<int?>("TicketfourQty")
                        .HasColumnType("int");

                    b.Property<int?>("TicketoneQty")
                        .HasColumnType("int");

                    b.Property<int?>("TicketsevenQty")
                        .HasColumnType("int");

                    b.Property<int?>("TicketsixQty")
                        .HasColumnType("int");

                    b.Property<int?>("TicketthreeQty")
                        .HasColumnType("int");

                    b.Property<int?>("TickettwoQty")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("YearPass")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookDB");
                });

            modelBuilder.Entity("OS_GJ_Tutoring.Models.CoursesDB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CoursesDB");
                });

            modelBuilder.Entity("OS_GJ_Tutoring.Models.SessionsDB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("TutorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TutorSubject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SessionsDB");
                });

            modelBuilder.Entity("OS_GJ_Tutoring.Models.StayDB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumNight")
                        .HasColumnType("int");

                    b.Property<int?>("NumVisitors")
                        .HasColumnType("int");

                    b.Property<string>("RoomName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StayDB");
                });
#pragma warning restore 612, 618
        }
    }
}
