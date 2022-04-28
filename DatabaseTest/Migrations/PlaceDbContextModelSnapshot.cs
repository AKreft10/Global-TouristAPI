﻿// <auto-generated />
using System;
using DatabaseTest.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabaseTest.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class PlaceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DatabaseTest.Entity.Accommodation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("HasPool")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Stars")
                        .HasColumnType("int");

                    b.Property<string>("ThumbnailPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Accommodations");
                });

            modelBuilder.Entity("DatabaseTest.Entity.AccommodationPhoto", b =>
                {
                    b.Property<int>("PhotoId")
                        .HasColumnType("int");

                    b.Property<int>("AccommodationId")
                        .HasColumnType("int");

                    b.HasKey("PhotoId", "AccommodationId");

                    b.HasIndex("AccommodationId");

                    b.ToTable("AcommodationPhotos");
                });

            modelBuilder.Entity("DatabaseTest.Entity.AccommodationReview", b =>
                {
                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.Property<int>("AccommodationId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId", "AccommodationId");

                    b.HasIndex("AccommodationId");

                    b.ToTable("AccommodationReviews");
                });

            modelBuilder.Entity("DatabaseTest.Entity.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DatabaseTest.Entity.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GalleryMember")
                        .HasColumnType("bit");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("DatabaseTest.Entity.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ThumbnailPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Places");
                });

            modelBuilder.Entity("DatabaseTest.Entity.PlacePhoto", b =>
                {
                    b.Property<int>("PhotoId")
                        .HasColumnType("int");

                    b.Property<int>("PlaceId")
                        .HasColumnType("int");

                    b.HasKey("PhotoId", "PlaceId");

                    b.HasIndex("PlaceId");

                    b.ToTable("PlacePhotos");
                });

            modelBuilder.Entity("DatabaseTest.Entity.PlaceReview", b =>
                {
                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.Property<int>("PlaceId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId", "PlaceId");

                    b.HasIndex("PlaceId");

                    b.ToTable("PlaceReviews");
                });

            modelBuilder.Entity("DatabaseTest.Entity.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("DatabaseTest.Entity.Accommodation", b =>
                {
                    b.HasOne("DatabaseTest.Entity.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DatabaseTest.Entity.AccommodationPhoto", b =>
                {
                    b.HasOne("DatabaseTest.Entity.Accommodation", "Accommodation")
                        .WithMany("Photos")
                        .HasForeignKey("AccommodationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTest.Entity.Photo", "Photo")
                        .WithMany("AccomodationPhotos")
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accommodation");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("DatabaseTest.Entity.AccommodationReview", b =>
                {
                    b.HasOne("DatabaseTest.Entity.Accommodation", "Accomodation")
                        .WithMany("Reviews")
                        .HasForeignKey("AccommodationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTest.Entity.Review", "Review")
                        .WithMany("AccommodationReviews")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accomodation");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("DatabaseTest.Entity.Place", b =>
                {
                    b.HasOne("DatabaseTest.Entity.Address", "Address")
                        .WithOne("Place")
                        .HasForeignKey("DatabaseTest.Entity.Place", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DatabaseTest.Entity.PlacePhoto", b =>
                {
                    b.HasOne("DatabaseTest.Entity.Photo", "Photo")
                        .WithMany("PlacePhotos")
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTest.Entity.Place", "Place")
                        .WithMany("Photos")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Photo");

                    b.Navigation("Place");
                });

            modelBuilder.Entity("DatabaseTest.Entity.PlaceReview", b =>
                {
                    b.HasOne("DatabaseTest.Entity.Place", "Place")
                        .WithMany("Reviews")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTest.Entity.Review", "Review")
                        .WithMany("PlaceReviews")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("DatabaseTest.Entity.Accommodation", b =>
                {
                    b.Navigation("Photos");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("DatabaseTest.Entity.Address", b =>
                {
                    b.Navigation("Place");
                });

            modelBuilder.Entity("DatabaseTest.Entity.Photo", b =>
                {
                    b.Navigation("AccomodationPhotos");

                    b.Navigation("PlacePhotos");
                });

            modelBuilder.Entity("DatabaseTest.Entity.Place", b =>
                {
                    b.Navigation("Photos");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("DatabaseTest.Entity.Review", b =>
                {
                    b.Navigation("AccommodationReviews");

                    b.Navigation("PlaceReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
