﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiteManagement.Models.Db;

namespace SiteManagement.Migrations
{
    [DbContext(typeof(SiteManagementDbContext))]
    partial class SiteManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlockId")
                        .HasColumnType("int");

                    b.Property<int>("HomeOwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BlockId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.ApartmentDept", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeptDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("ElectricityDebt")
                        .HasColumnType("real");

                    b.Property<float>("GasDebt")
                        .HasColumnType("real");

                    b.Property<float>("WaterDept")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("ApartmentDepts");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Block", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlockName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Human", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<string>("NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("Humans");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DistrcitIdId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerHumanId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistrcitIdId");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordConfirmation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Apartment", b =>
                {
                    b.HasOne("SiteManagement.Models.Db.Entities.Block", null)
                        .WithMany("Apartments")
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.ApartmentDept", b =>
                {
                    b.HasOne("SiteManagement.Models.Db.Entities.Apartment", null)
                        .WithMany("ApartmentDepts")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Block", b =>
                {
                    b.HasOne("SiteManagement.Models.Db.Entities.Site", null)
                        .WithMany("Blocks")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.District", b =>
                {
                    b.HasOne("SiteManagement.Models.Db.Entities.Province", "Province")
                        .WithMany("Districts")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Human", b =>
                {
                    b.HasOne("SiteManagement.Models.Db.Entities.Apartment", null)
                        .WithMany("Humans")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Site", b =>
                {
                    b.HasOne("SiteManagement.Models.Db.Entities.District", "DistrcitId")
                        .WithMany()
                        .HasForeignKey("DistrcitIdId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("DistrcitId");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Worker", b =>
                {
                    b.HasOne("SiteManagement.Models.Db.Entities.Site", null)
                        .WithMany("Workers")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Apartment", b =>
                {
                    b.Navigation("ApartmentDepts");

                    b.Navigation("Humans");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Block", b =>
                {
                    b.Navigation("Apartments");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Province", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("SiteManagement.Models.Db.Entities.Site", b =>
                {
                    b.Navigation("Blocks");

                    b.Navigation("Workers");
                });
#pragma warning restore 612, 618
        }
    }
}
