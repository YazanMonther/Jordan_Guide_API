﻿// <auto-generated />
using System;
using Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entites.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entites.FAQs", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.ToTable("FAQs", (string)null);
                });

            modelBuilder.Entity("Entites.Identity.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Entites.Identity.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entites.Images", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Image1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tourismPlaceId")
                        .HasColumnType("int");

                    b.Property<int?>("tredndingEventsId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("tourismPlaceId");

                    b.HasIndex("tredndingEventsId");

                    b.ToTable("Images", (string)null);
                });

            modelBuilder.Entity("Entites.TourismPlaces", b =>
                {
                    b.Property<int>("tourismPlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("tourismPlaceId"));

                    b.Property<string>("CitizenPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FridayTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MondayTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaturdayTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SundayTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThursdayTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TuesdayTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WednesdayTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("main_Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tourismCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tourismCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tourismDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tourismLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tourismLocationDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tourismName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tourismPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tourismRating")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tourismPlaceId");

                    b.ToTable("TourismPlaces", (string)null);
                });

            modelBuilder.Entity("Entites.TrendingEvents", b =>
                {
                    b.Property<int>("eventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("eventId"));

                    b.Property<string>("EventLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventLocationDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("eventDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("eventDateFinish")
                        .HasColumnType("datetime2");

                    b.Property<string>("eventDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventRating")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("eventId");

                    b.ToTable("TrendingEvents", (string)null);
                });

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

                    b.ToTable("RoleClaims");
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

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Entites.Images", b =>
                {
                    b.HasOne("Entites.TourismPlaces", "tourism")
                        .WithMany("images")
                        .HasForeignKey("tourismPlaceId");

                    b.HasOne("Entites.TrendingEvents", "trending")
                        .WithMany("Images")
                        .HasForeignKey("tredndingEventsId");

                    b.Navigation("tourism");

                    b.Navigation("trending");
                });

            modelBuilder.Entity("Entites.TourismPlaces", b =>
                {
                    b.Navigation("images");
                });

            modelBuilder.Entity("Entites.TrendingEvents", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
