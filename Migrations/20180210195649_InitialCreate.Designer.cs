﻿// <auto-generated />
using gpsWeb.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace gpsWeb.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180210195649_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("gpsWeb.API.Models.Coordinate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Lat");

                    b.Property<float>("Lng");

                    b.Property<DateTime>("Time");

                    b.Property<double>("Vehicle_Nr");

                    b.HasKey("Id");

                    b.ToTable("Coordinates");
                });
#pragma warning restore 612, 618
        }
    }
}