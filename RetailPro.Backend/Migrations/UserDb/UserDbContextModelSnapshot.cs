﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RetailPro.Backend.Areas.UserSpace.DbContexts;

namespace RetailPro.Backend.Migrations.UserDb
{
    [DbContext(typeof(UserDbContext))]
    partial class UserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Users");
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
