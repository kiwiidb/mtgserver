﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MtgServer.Migrations
{
    [DbContext(typeof(Db))]
    [Migration("20240229064336_GameContents")]
    partial class GameContents
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Deck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Commander")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Deck");
                });

            modelBuilder.Entity("Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Deck2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Deck2Commander")
                        .HasColumnType("TEXT");

                    b.Property<string>("Deck3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Deck3Commander")
                        .HasColumnType("TEXT");

                    b.Property<string>("Deck4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Deck4Commander")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Player2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Player3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Player4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Winner")
                        .HasColumnType("TEXT");

                    b.Property<string>("WinningDeck")
                        .HasColumnType("TEXT");

                    b.Property<string>("WinningDeckCommander")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Deck", b =>
                {
                    b.HasOne("Player", null)
                        .WithMany("Decks")
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("Player", b =>
                {
                    b.Navigation("Decks");
                });
#pragma warning restore 612, 618
        }
    }
}
