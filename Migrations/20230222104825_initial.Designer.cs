﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using authtest.DirModels;

#nullable disable

namespace authtest.Migrations
{
    [DbContext(typeof(Team2dbContext))]
    [Migration("20230222104825_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("authtest.DirModels.Decodemanager", b =>
                {
                    b.Property<string>("IsManager")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("isManager");

                    b.Property<string>("Passwords")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ResourceId")
                        .HasColumnType("int")
                        .HasColumnName("Resource_ID");

                    b.Property<string>("ResourceName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Resource_Name");

                    b.ToTable("decodemanager", (string)null);
                });

            modelBuilder.Entity("authtest.DirModels.Timesheettable", b =>
                {
                    b.Property<string>("ApprovalStatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Approval_Status");

                    b.Property<string>("CustomerId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Customer_ID");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Customer_Name");

                    b.Property<string>("Horizontal")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("HoursDone")
                        .HasColumnType("float")
                        .HasColumnName("Hours_Done");

                    b.Property<TimeSpan>("HoursRequired")
                        .HasColumnType("time")
                        .HasColumnName("Hours_Required");

                    b.Property<double>("Id")
                        .HasColumnType("float")
                        .HasColumnName("ID");

                    b.Property<DateTime>("PeriodEnd")
                        .HasColumnType("date")
                        .HasColumnName("Period_End");

                    b.Property<DateTime>("PeriodStart")
                        .HasColumnType("date")
                        .HasColumnName("Period_Start");

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Project_ID");

                    b.Property<string>("ProjectManager")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Project_Manager");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Project_Name");

                    b.Property<double>("ResourceId")
                        .HasColumnType("float")
                        .HasColumnName("Resource_ID");

                    b.Property<string>("ResourceName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Resource_Name");

                    b.Property<string>("SubHorizontal")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Sub_Horizontal");

                    b.Property<string>("TimesheetNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Timesheet_Number");

                    b.Property<string>("Vertical")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.ToTable("timesheettable", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
