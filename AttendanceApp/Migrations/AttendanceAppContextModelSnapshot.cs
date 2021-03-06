﻿// <auto-generated />
using System;
using AttendanceApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AttendanceApp.Migrations
{
    [DbContext(typeof(AttendanceAppContext))]
    partial class AttendanceAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AttendanceApp.Models.Mark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StudentMark");

                    b.Property<string>("StudentRollNumber");

                    b.Property<int>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("StudentRollNumber");

                    b.HasIndex("SubjectId");

                    b.ToTable("Mark");
                });

            modelBuilder.Entity("AttendanceApp.Models.Student", b =>
                {
                    b.Property<string>("RollNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("RollNumber");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("AttendanceApp.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("AttendanceApp.Models.Mark", b =>
                {
                    b.HasOne("AttendanceApp.Models.Student", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentRollNumber");

                    b.HasOne("AttendanceApp.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
