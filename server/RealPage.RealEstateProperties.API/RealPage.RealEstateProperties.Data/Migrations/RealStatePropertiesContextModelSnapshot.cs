﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealPage.RealEstateProperties.Data.Context;

namespace RealPage.RealEstateProperties.Data.Migrations
{
    [DbContext(typeof(RealStatePropertiesContext))]
    partial class RealStatePropertiesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("RealPage.RealEstateProperties.Entity.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOnMarket")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Owner")
                        .HasColumnType("TEXT");

                    b.Property<int>("PropertyTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoomCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("PropertyId");

                    b.HasIndex("PropertyTypeId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("RealPage.RealEstateProperties.Entity.PropertyType", b =>
                {
                    b.Property<int>("PropertyTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("PropertyTypeId");

                    b.ToTable("PropertyTypes");

                    b.HasData(
                        new
                        {
                            PropertyTypeId = 1,
                            Description = "Apartment"
                        },
                        new
                        {
                            PropertyTypeId = 2,
                            Description = "House"
                        });
                });

            modelBuilder.Entity("RealPage.RealEstateProperties.Entity.Property", b =>
                {
                    b.HasOne("RealPage.RealEstateProperties.Entity.PropertyType", "PropertyType")
                        .WithMany()
                        .HasForeignKey("PropertyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PropertyType");
                });
#pragma warning restore 612, 618
        }
    }
}
