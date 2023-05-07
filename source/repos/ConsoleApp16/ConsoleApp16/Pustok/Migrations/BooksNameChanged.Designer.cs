﻿using ConsoleApp16.Pustok.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P328Pustok.DAL;
using System.Reflection.Emit;

#nullable disable

namespace ConsoleApp16.Pustok.Migrations
{
    [DbContext(typeof(PustokContext))]
    [Migration("20230504155813_BooksNameChanged")]
    partial class BooksNameChanged
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("P328Pustok.Models.Author", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);
                b.Property<string>("FullName")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar(20)");
                b.HasKey("Id");
                b.ToTable("Authors");
            });

            modelBuilder.Entity("P328Pustok.Models.Book", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);
                b.Property<int>("AuthorId")
                    .HasColumnType("int");
                b.Property<decimal>("CostPrice")
                    .HasColumnType("money");
                b.Property<string>("Desc")
                    .HasMaxLength(500)
                    .HasColumnType("nvarchar(500)");
                b.Property<decimal>("DiscountPercent")
                    .HasColumnType("money");
                b.Property<int>("GenreId")
                    .HasColumnType("int");
                b.Property<bool>("IsFeatured")
                    .HasColumnType("bit");
                b.Property<bool>("IsNew")
                    .HasColumnType("bit");
                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");
                b.Property<decimal>("SalePrice")
                    .HasColumnType("money");
                b.Property<bool>("StockStatus")
                    .HasColumnType("bit");
                b.HasKey("Id");
                b.HasIndex("AuthorId");
                b.HasIndex("GenreId");
                b.ToTable("Books");
            });

            modelBuilder.Entity("P328Pustok.Models.BookImage", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);
                b.Property<int>("BookId")
                    .HasColumnType("int");
                b.Property<string>("ImageName")
                    .HasColumnType("nvarchar(max)");
                b.Property<bool>("PosterStatus")
                    .HasColumnType("bit");
                b.HasKey("Id");
                b.HasIndex("BookId");
                b.ToTable("BookImages");
            });

            modelBuilder.Entity("P328Pustok.Models.Genre", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);
                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar(20)");
                b.HasKey("Id");
                b.ToTable("Genres");
            });

            modelBuilder.Entity("P328Pustok.Models.Tag", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);
                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar(20)");
                b.HasKey("Id");
                b.ToTable("Tags");
            });

            modelBuilder.Entity("P328Pustok.Models.Book", b =>
            {
                b.HasOne("P328Pustok.Models.Author", "Author")
                    .WithMany()
                    .HasForeignKey("AuthorId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
                b.HasOne("P328Pustok.Models.Genre", "Genre")
                    .WithMany()
                    .HasForeignKey("GenreId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
                b.Navigation("Author");
                b.Navigation("Genre");
            });

            modelBuilder.Entity("P328Pustok.Models.BookImage", b =>
            {
                b.HasOne("P328Pustok.Models.Book", "Book")
                    .WithMany()
                    .HasForeignKey("BookId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
                b.Navigation("Book");
            });
#pragma warning restore 612, 618
        }
    }
}