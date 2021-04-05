﻿// <auto-generated />
using Combis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Combis.Migrations
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Combis.Models.Contact", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("firstname")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("lastname")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("mobilephone")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
