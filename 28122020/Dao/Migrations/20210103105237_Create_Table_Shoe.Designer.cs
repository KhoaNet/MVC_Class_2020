﻿// <auto-generated />
using Dao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dao.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210103105237_Create_Table_Shoe")]
    partial class Create_Table_Shoe
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Dao.Model.EmployeeModel", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Dao.Model.ShoeModel", b =>
                {
                    b.Property<int>("ShoeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ShoeImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShoeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoeId");

                    b.ToTable("Shoes");
                });
#pragma warning restore 612, 618
        }
    }
}
