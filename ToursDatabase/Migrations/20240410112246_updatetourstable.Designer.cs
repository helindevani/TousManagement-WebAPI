﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToursDatabase.DatabaseContext;

#nullable disable

namespace ToursDatabase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240410112246_updatetourstable")]
    partial class updatetourstable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.Image", b =>
                {
                    b.Property<Guid>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSizeInBytes")
                        .HasColumnType("bigint");

                    b.Property<Guid>("TourId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ImageId");

                    b.HasIndex("TourId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ImageId = new Guid("9f0f0fca-6f2d-467e-9461-f2ddd1691fed"),
                            CreateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9880),
                            FileDescription = "An example image",
                            FileExtension = ".jpg",
                            FileName = "example.jpg",
                            FilePath = "/Images/example.jpg",
                            FileSizeInBytes = 1024L,
                            TourId = new Guid("9c0cf771-2a31-44c9-adfd-b08c30397392"),
                            UpdateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9880)
                        });
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.Location", b =>
                {
                    b.Property<Guid>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TourId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LocationId");

                    b.HasIndex("TourId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = new Guid("7209f8df-5d18-4279-a03d-707624fb86bb"),
                            Address = "123 Street, City, Country",
                            CreateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9762),
                            Description = "that is second street of place",
                            Latitude = 40.748817000000003,
                            Longitude = -73.985427999999999,
                            Name = "New York State Building Observatory",
                            TourId = new Guid("9c0cf771-2a31-44c9-adfd-b08c30397392"),
                            UpdateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9763)
                        },
                        new
                        {
                            LocationId = new Guid("96774d84-57b3-45f1-8029-7205f2167731"),
                            Address = "456 Road, City, Country",
                            CreateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9769),
                            Description = "that is first street of place",
                            Latitude = 40.712800000000001,
                            Longitude = -74.006,
                            Name = "NYC Cruise by Circle Line",
                            TourId = new Guid("9c0cf771-2a31-44c9-adfd-b08c30397392"),
                            UpdateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9769)
                        });
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.Review", b =>
                {
                    b.Property<Guid>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("ReviewDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TourId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ReviewId");

                    b.HasIndex("TourId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = new Guid("c183f14e-977f-4472-87c1-508ce5edeccd"),
                            CreateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9550),
                            Rating = 4.5,
                            ReviewDetail = "Great tour!",
                            TourId = new Guid("9c0cf771-2a31-44c9-adfd-b08c30397392"),
                            UpdateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9562)
                        },
                        new
                        {
                            ReviewId = new Guid("93d32dfa-009f-49cb-8401-df4997568192"),
                            CreateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9567),
                            Rating = 5.0,
                            ReviewDetail = "Amazing experience!",
                            TourId = new Guid("9c0cf771-2a31-44c9-adfd-b08c30397392"),
                            UpdateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9568)
                        });
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.Stop", b =>
                {
                    b.Property<Guid>("StopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<Guid?>("TourId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StopId");

                    b.HasIndex("LocationId");

                    b.HasIndex("TourId");

                    b.ToTable("Stops");

                    b.HasData(
                        new
                        {
                            StopId = new Guid("a4adc6ea-62a6-41ed-9427-61627a496afb"),
                            ArrivalTime = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9898),
                            DepartureTime = new DateTime(2024, 4, 11, 2, 52, 46, 480, DateTimeKind.Local).AddTicks(9899),
                            LocationId = new Guid("7209f8df-5d18-4279-a03d-707624fb86bb"),
                            Order = 2
                        });
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.Tour", b =>
                {
                    b.Property<Guid>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("FirstLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxGroupSize")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double?>("RatingsAverage")
                        .HasColumnType("float");

                    b.Property<int?>("RatingsQuantity")
                        .HasColumnType("int");

                    b.Property<bool>("SecretTour")
                        .HasColumnType("bit");

                    b.Property<string>("StartTourLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TourDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TourId");

                    b.HasIndex("UserId");

                    b.ToTable("Tours");

                    b.HasData(
                        new
                        {
                            TourId = new Guid("9c0cf771-2a31-44c9-adfd-b08c30397392"),
                            CreateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9818),
                            Description = "This Is Compelete Trip About Newyork",
                            Difficulty = 1,
                            Duration = 7,
                            Id = new Guid("bfa80c03-5e0b-4d76-a802-d8ce6d2c7587"),
                            MaxGroupSize = 20,
                            Name = "NewYork Tour",
                            Price = 100.0,
                            RatingsAverage = 4.5,
                            RatingsQuantity = 50,
                            SecretTour = false,
                            StartTourLocation = "Ahmedabad",
                            TourDate = new DateTime(2024, 4, 10, 11, 22, 46, 480, DateTimeKind.Utc).AddTicks(9806),
                            UpdateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9819)
                        });
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.TourBooking", b =>
                {
                    b.Property<Guid>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TourDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TourId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingID");

                    b.HasIndex("TourId");

                    b.ToTable("TourBookings");

                    b.HasData(
                        new
                        {
                            BookingID = new Guid("ce12bfbd-465e-43a5-8576-65d5f1fe1e16"),
                            BookingDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9850),
                            CreateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9853),
                            CustomerEmail = "john@example.com",
                            CustomerName = "John Doe",
                            Status = 1,
                            TourDate = new DateTime(2024, 4, 17, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9850),
                            TourId = new Guid("9c0cf771-2a31-44c9-adfd-b08c30397392"),
                            UpdateDate = new DateTime(2024, 4, 10, 16, 52, 46, 480, DateTimeKind.Local).AddTicks(9854)
                        });
                });

            modelBuilder.Entity("ToursDatabase.Domain.Identity.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("7dbd5480-1224-4288-aee8-1249f8a94e1a"),
                            ConcurrencyStamp = "7DBD5480-1224-4288-AEE8-1249F8A94E1A",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("3ac53885-3553-4b1c-93d2-4deca3b4cb54"),
                            ConcurrencyStamp = "3AC53885-3553-4B1C-93D2-4DECA3B4CB54",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("ToursDatabase.Domain.Identity.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("ToursDatabase.Domain.Identity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ToursDatabase.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ToursDatabase.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("ToursDatabase.Domain.Identity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToursDatabase.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ToursDatabase.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.Image", b =>
                {
                    b.HasOne("ToursDatabase.Domain.Entities.Tour", "Tour")
                        .WithMany("Images")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.Location", b =>
                {
                    b.HasOne("ToursDatabase.Domain.Entities.Tour", "Tour")
                        .WithMany("Locations")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.Review", b =>
                {
                    b.HasOne("ToursDatabase.Domain.Entities.Tour", "Tour")
                        .WithMany("Reviews")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.Stop", b =>
                {
                    b.HasOne("ToursDatabase.Domain.Entities.Location", "Location")
                        .WithMany("Stops")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToursDatabase.Domain.Entities.Tour", null)
                        .WithMany("Stops")
                        .HasForeignKey("TourId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.Tour", b =>
                {
                    b.HasOne("ToursDatabase.Domain.Identity.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.TourBooking", b =>
                {
                    b.HasOne("ToursDatabase.Domain.Entities.Tour", "Tour")
                        .WithMany()
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.Location", b =>
                {
                    b.Navigation("Stops");
                });

            modelBuilder.Entity("ToursDatabase.Domain.Entities.Tour", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Locations");

                    b.Navigation("Reviews");

                    b.Navigation("Stops");
                });
#pragma warning restore 612, 618
        }
    }
}
