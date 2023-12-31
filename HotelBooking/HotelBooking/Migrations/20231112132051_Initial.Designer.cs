﻿// <auto-generated />
using HotelBooking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelBooking.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20231112132051_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("HotelBooking.Model.HotelBookingg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientName")
                        .HasColumnType("TEXT")
                        .HasColumnName("ClientName");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("INTEGER")
                        .HasColumnName("RoomNumber");

                    b.HasKey("Id");

                    b.ToTable("Bookings", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
