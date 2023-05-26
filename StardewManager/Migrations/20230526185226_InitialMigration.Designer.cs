﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StardewManager.Data;

#nullable disable

namespace StardewManager.Migrations
{
    [DbContext(typeof(StardewManagerContext))]
    [Migration("20230526185226_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("StardewManager.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("StardewManager.Models.Farm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Farms");
                });

            modelBuilder.Entity("StardewManager.Models.Gift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("VillagerId")
                        .HasColumnType("int");

                    b.Property<int?>("VillagerId1")
                        .HasColumnType("int");

                    b.Property<int?>("VillagerId2")
                        .HasColumnType("int");

                    b.Property<int?>("VillagerId3")
                        .HasColumnType("int");

                    b.Property<int?>("VillagerId4")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("VillagerId");

                    b.HasIndex("VillagerId1");

                    b.HasIndex("VillagerId2");

                    b.HasIndex("VillagerId3");

                    b.HasIndex("VillagerId4");

                    b.ToTable("Gift");
                });

            modelBuilder.Entity("StardewManager.Models.ToDoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("FarmId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.ToTable("ToDoItem");
                });

            modelBuilder.Entity("StardewManager.Models.Villager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Birthday")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("FarmId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.ToTable("Villager");
                });

            modelBuilder.Entity("StardewManager.Models.Category", b =>
                {
                    b.HasOne("StardewManager.Models.Category", null)
                        .WithMany("Categories")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("StardewManager.Models.Gift", b =>
                {
                    b.HasOne("StardewManager.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StardewManager.Models.Villager", null)
                        .WithMany("Dislikes")
                        .HasForeignKey("VillagerId");

                    b.HasOne("StardewManager.Models.Villager", null)
                        .WithMany("Hates")
                        .HasForeignKey("VillagerId1");

                    b.HasOne("StardewManager.Models.Villager", null)
                        .WithMany("Likes")
                        .HasForeignKey("VillagerId2");

                    b.HasOne("StardewManager.Models.Villager", null)
                        .WithMany("Loves")
                        .HasForeignKey("VillagerId3");

                    b.HasOne("StardewManager.Models.Villager", null)
                        .WithMany("Neutral")
                        .HasForeignKey("VillagerId4");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("StardewManager.Models.ToDoItem", b =>
                {
                    b.HasOne("StardewManager.Models.Farm", null)
                        .WithMany("ToDos")
                        .HasForeignKey("FarmId");
                });

            modelBuilder.Entity("StardewManager.Models.Villager", b =>
                {
                    b.HasOne("StardewManager.Models.Farm", null)
                        .WithMany("Villagers")
                        .HasForeignKey("FarmId");
                });

            modelBuilder.Entity("StardewManager.Models.Category", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("StardewManager.Models.Farm", b =>
                {
                    b.Navigation("ToDos");

                    b.Navigation("Villagers");
                });

            modelBuilder.Entity("StardewManager.Models.Villager", b =>
                {
                    b.Navigation("Dislikes");

                    b.Navigation("Hates");

                    b.Navigation("Likes");

                    b.Navigation("Loves");

                    b.Navigation("Neutral");
                });
#pragma warning restore 612, 618
        }
    }
}