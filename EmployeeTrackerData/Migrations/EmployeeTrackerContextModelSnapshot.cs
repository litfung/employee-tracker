﻿// <auto-generated />
using System;
using EmployeeTrackerData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeTrackerData.Migrations
{
    [DbContext(typeof(EmployeeTrackerContext))]
    partial class EmployeeTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeTrackerData.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("employee_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnName("age");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasMaxLength(100);

                    b.Property<int>("OfficeId")
                        .HasColumnName("office_id");

                    b.Property<int>("PositionId")
                        .HasColumnName("position_id");

                    b.Property<decimal>("Salary")
                        .HasColumnName("salary")
                        .HasColumnType("money");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnName("sex")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<DateTime>("StartDate")
                        .HasColumnName("start_date")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("UpdatedUtc")
                        .HasColumnName("updated_utc");

                    b.HasKey("EmployeeId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("PositionId");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("EmployeeTrackerData.Models.Office", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("office_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasColumnName("office")
                        .HasMaxLength(100);

                    b.Property<DateTime>("UpdatedUtc")
                        .HasColumnName("updated_utc");

                    b.HasKey("OfficeId");

                    b.ToTable("office");
                });

            modelBuilder.Entity("EmployeeTrackerData.Models.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("position_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnName("position")
                        .HasMaxLength(100);

                    b.Property<DateTime>("UpdatedUtc")
                        .HasColumnName("updated_utc");

                    b.HasKey("PositionId");

                    b.ToTable("position");
                });

            modelBuilder.Entity("EmployeeTrackerData.Models.Employee", b =>
                {
                    b.HasOne("EmployeeTrackerData.Models.Office", "Office")
                        .WithMany("Employee")
                        .HasForeignKey("OfficeId")
                        .HasConstraintName("FK_employee_office_id");

                    b.HasOne("EmployeeTrackerData.Models.Position", "Position")
                        .WithMany("Employee")
                        .HasForeignKey("PositionId")
                        .HasConstraintName("FK_employee_position_id");
                });
#pragma warning restore 612, 618
        }
    }
}
