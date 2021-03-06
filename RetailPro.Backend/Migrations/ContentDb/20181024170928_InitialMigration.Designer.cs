﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RetailPro.Backend.Areas.UserSpace.DbContexts;

namespace RetailPro.Backend.Migrations.ContentDb
{
    [DbContext(typeof(ContentDbContext))]
    [Migration("20181024170928_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RetailPro.Backend.Areas.UserSpace.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Additional1");

                    b.Property<string>("Additional2");

                    b.Property<string>("Additional3");

                    b.Property<string>("Additional4");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("ReceiverFullName");

                    b.Property<string>("Street");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("RetailPro.Backend.Areas.UserSpace.Models.Contents.Content", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AuthorId");

                    b.Property<int>("ContentType");

                    b.Property<string>("Description");

                    b.Property<Guid?>("TileId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("TileId");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("RetailPro.Backend.Areas.UserSpace.Models.Contents.ContentModule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ContentId");

                    b.Property<int>("ModuleType");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.ToTable("ContentModules");
                });

            modelBuilder.Entity("RetailPro.Backend.Areas.UserSpace.Models.Contents.Tile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CommentCount");

                    b.Property<long>("LikeCount");

                    b.Property<long>("ShareCount");

                    b.Property<string>("SubTitle");

                    b.Property<string>("TileLargeUrl");

                    b.Property<string>("TileMediumUrl");

                    b.Property<string>("TileSmallUrl");

                    b.Property<string>("Title");

                    b.Property<long>("ViewCount");

                    b.HasKey("Id");

                    b.ToTable("Tile");
                });

            modelBuilder.Entity("RetailPro.Backend.Areas.UserSpace.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvatarUrl");

                    b.Property<Guid?>("BillingAddressId");

                    b.Property<string>("Biography");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("Handle");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("PublicEmailAddress");

                    b.Property<Guid?>("ShippingAddressId");

                    b.HasKey("Id");

                    b.HasIndex("BillingAddressId");

                    b.HasIndex("ShippingAddressId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RetailPro.Backend.Areas.UserSpace.Models.Contents.Content", b =>
                {
                    b.HasOne("RetailPro.Backend.Areas.UserSpace.Models.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("RetailPro.Backend.Areas.UserSpace.Models.Contents.Tile", "Tile")
                        .WithMany()
                        .HasForeignKey("TileId");
                });

            modelBuilder.Entity("RetailPro.Backend.Areas.UserSpace.Models.Contents.ContentModule", b =>
                {
                    b.HasOne("RetailPro.Backend.Areas.UserSpace.Models.Contents.Content")
                        .WithMany("ContentModules")
                        .HasForeignKey("ContentId");
                });

            modelBuilder.Entity("RetailPro.Backend.Areas.UserSpace.Models.User", b =>
                {
                    b.HasOne("RetailPro.Backend.Areas.UserSpace.Models.Address", "BillingAddress")
                        .WithMany()
                        .HasForeignKey("BillingAddressId");

                    b.HasOne("RetailPro.Backend.Areas.UserSpace.Models.Address", "ShippingAddress")
                        .WithMany()
                        .HasForeignKey("ShippingAddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
