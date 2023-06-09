﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCollectionSite.Models;

#nullable disable

namespace MyCollectionSite.Migrations
{
    [DbContext(typeof(CollectionContext))]
    [Migration("20220620144359_Seed Data")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("MyCollectionSite.Models.CollectionItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Acquired")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CollectionItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Acquired = new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Black hat with the classic Atari logo and Japanese text for Atari under the brim",
                            ImageURL = "https://hatcollection.blob.core.windows.net/hat-images/atari.jpg",
                            Name = "Atari"
                        },
                        new
                        {
                            Id = 2,
                            Acquired = new DateTime(2019, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "White hat with purple Blazor logo",
                            ImageURL = "https://hatcollection.blob.core.windows.net/hat-images/blazor.jpg",
                            Name = "Blazor"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
