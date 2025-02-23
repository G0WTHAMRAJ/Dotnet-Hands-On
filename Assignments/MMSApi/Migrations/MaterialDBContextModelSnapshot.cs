﻿// <auto-generated />
using MMSApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MMSApi.Migrations
{
    [DbContext(typeof(MaterialDBContext))]
    partial class MaterialDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MMSApi.Model.Material", b =>
                {
                    b.Property<int>("mId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("mId"));

                    b.Property<string>("mName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("mQuantity")
                        .HasColumnType("integer");

                    b.Property<string>("mRetailer")
                        .HasColumnType("text");

                    b.Property<string>("mType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("mId");

                    b.ToTable("Material");
                });
#pragma warning restore 612, 618
        }
    }
}
