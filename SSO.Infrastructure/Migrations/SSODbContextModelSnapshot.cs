﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SSO.Infrastructure.DBContext;

#nullable disable

namespace SSO.Infrastructure.Migrations
{
    [DbContext(typeof(SSODbContext))]
    partial class SSODbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SSO.Core.Domain.AcademicYear.AcademicYear", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("AcademicYear");
                });

            modelBuilder.Entity("SSO.Core.Domain.Applications.App", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsEmailRequired")
                        .HasColumnType("bit");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("SSO.Core.Domain.Course.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CourseTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Vahed")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("SSO.Core.Domain.Teach.Teach", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.Property<int>("UnitID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TeacherID");

                    b.HasIndex("UnitID");

                    b.ToTable("Teach");
                });

            modelBuilder.Entity("SSO.Core.Domain.Teacher.Teacher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("SSO.Core.Domain.TimeSchedule.TimeSchedule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<string>("EndTime")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StartTime")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("TimeSchedule");
                });

            modelBuilder.Entity("SSO.Core.Domain.Unit.Unit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AcademicYearID")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("TimeScheduleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AcademicYearID");

                    b.HasIndex("CourseID");

                    b.HasIndex("TimeScheduleID");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("SSO.Core.Domain.Teach.Teach", b =>
                {
                    b.HasOne("SSO.Core.Domain.Teacher.Teacher", "Teacher")
                        .WithMany("Teachs")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SSO.Core.Domain.Unit.Unit", "Unit")
                        .WithMany("Teachs")
                        .HasForeignKey("UnitID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Teacher");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("SSO.Core.Domain.Unit.Unit", b =>
                {
                    b.HasOne("SSO.Core.Domain.AcademicYear.AcademicYear", "AcademicYear")
                        .WithMany("Units")
                        .HasForeignKey("AcademicYearID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SSO.Core.Domain.Course.Course", "Course")
                        .WithMany("Units")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SSO.Core.Domain.TimeSchedule.TimeSchedule", "TimeSchedule")
                        .WithMany("Units")
                        .HasForeignKey("TimeScheduleID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("AcademicYear");

                    b.Navigation("Course");

                    b.Navigation("TimeSchedule");
                });

            modelBuilder.Entity("SSO.Core.Domain.AcademicYear.AcademicYear", b =>
                {
                    b.Navigation("Units");
                });

            modelBuilder.Entity("SSO.Core.Domain.Course.Course", b =>
                {
                    b.Navigation("Units");
                });

            modelBuilder.Entity("SSO.Core.Domain.Teacher.Teacher", b =>
                {
                    b.Navigation("Teachs");
                });

            modelBuilder.Entity("SSO.Core.Domain.TimeSchedule.TimeSchedule", b =>
                {
                    b.Navigation("Units");
                });

            modelBuilder.Entity("SSO.Core.Domain.Unit.Unit", b =>
                {
                    b.Navigation("Teachs");
                });
#pragma warning restore 612, 618
        }
    }
}