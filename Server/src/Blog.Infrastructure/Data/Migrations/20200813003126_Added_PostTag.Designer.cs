﻿// <auto-generated />
using System;
using Medium.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Medium.Infrastructure.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200813003126_Added_PostTag")]
    partial class Added_PostTag
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Medium.Core.Domain.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ConfirmedEmail")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deactivated")
                        .HasColumnType("bit");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4f29ee19-ea4b-421d-a796-c2ee446becd2"),
                            ConfirmedEmail = true,
                            CreatedAt = new DateTime(2020, 8, 12, 21, 31, 0, 0, DateTimeKind.Unspecified),
                            Deactivated = false,
                            Deleted = false,
                            Email = "admin.master@email.com",
                            FirstName = "Administrador",
                            LastName = "Master",
                            Password = "usBcD3CMDXbNK+TtsrQsOBMxUQP29R921X1KVJoFlbw=",
                            Salt = "2CpxP1GbTYc=",
                            UpdatedAt = new DateTime(2020, 8, 12, 21, 31, 0, 0, DateTimeKind.Unspecified),
                            Username = "admin.master"
                        });
                });

            modelBuilder.Entity("Medium.Core.Domain.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Attachments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("040b026e-df88-4753-b96a-1fbc18498c9d"),
                            Attachments = "",
                            AuthorId = new Guid("4f29ee19-ea4b-421d-a796-c2ee446becd2"),
                            Content = "Post added in migration",
                            CreatedAt = new DateTime(2020, 8, 12, 21, 31, 0, 0, DateTimeKind.Unspecified),
                            Title = "Post Example",
                            UpdatedAt = new DateTime(2020, 8, 12, 21, 31, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Medium.Core.Domain.PostTag", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTags");

                    b.HasData(
                        new
                        {
                            PostId = new Guid("040b026e-df88-4753-b96a-1fbc18498c9d"),
                            TagId = new Guid("02ce73a0-768d-4ef3-8347-1fcf9522ee55"),
                            Id = new Guid("496606b5-78b7-4a7a-9fa3-44458bbbd0f8")
                        });
                });

            modelBuilder.Entity("Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("02ce73a0-768d-4ef3-8347-1fcf9522ee55"),
                            CreatedAt = new DateTime(2020, 8, 12, 21, 31, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tag 1",
                            UpdatedAt = new DateTime(2020, 8, 12, 21, 31, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Medium.Core.Domain.Post", b =>
                {
                    b.HasOne("Medium.Core.Domain.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Medium.Core.Domain.PostTag", b =>
                {
                    b.HasOne("Medium.Core.Domain.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
