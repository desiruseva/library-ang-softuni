﻿// <auto-generated />
using System;
using API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240409201749_InitialDB")]
    partial class InitialDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.NewFolder.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookCategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Ordered")
                        .HasColumnType("bit");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookCategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Euclid",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 3500f,
                            Title = "Euclid's Elements"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Robert Kanigel",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 3600f,
                            Title = "The Man Who Knew Infinity: A Life of the Genius Ramanujan"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Robert Kanigel",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 3600f,
                            Title = "The Man Who Knew Infinity: A Life of the Genius Ramanujan"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Stephen Hawking",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 3700f,
                            Title = "A Brief History of Time"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Albert Einstein",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 3800f,
                            Title = "Relativity: The Special and the General Theory"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Albert Einstein",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 3800f,
                            Title = "Relativity: The Special and the General Theory"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Albert Einstein",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 3800f,
                            Title = "Relativity: The Special and the General Theory"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Albert Einstein",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 3800f,
                            Title = "Relativity: The Special and the General Theory"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Albert Einstein",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 3800f,
                            Title = "Relativity: The Special and the General Theory"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Michael Serra",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 700f,
                            Title = "Discovering Geometry: An Investigative Approach"
                        },
                        new
                        {
                            Id = 11,
                            Author = "Michael Serra",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 700f,
                            Title = "Discovering Geometry: An Investigative Approach"
                        },
                        new
                        {
                            Id = 12,
                            Author = "Michael Serra",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 700f,
                            Title = "Discovering Geometry: An Investigative Approach"
                        },
                        new
                        {
                            Id = 13,
                            Author = "Laurie E. Bass",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 800f,
                            Title = "Holt Geometry: Student Edition"
                        },
                        new
                        {
                            Id = 14,
                            Author = "Frederick E. Hohn",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 900f,
                            Title = "Geometry: Student Edition"
                        },
                        new
                        {
                            Id = 15,
                            Author = "Frederick E. Hohn",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 900f,
                            Title = "Geometry: Student Edition"
                        },
                        new
                        {
                            Id = 16,
                            Author = "Laurie E. Bass",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1000f,
                            Title = "Holt McDougal Geometry: Student Edition"
                        },
                        new
                        {
                            Id = 17,
                            Author = "Jurgensen",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1100f,
                            Title = "Contemporary Geometry: A Comprehensive Course"
                        },
                        new
                        {
                            Id = 18,
                            Author = "Jurgensen",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1100f,
                            Title = "Contemporary Geometry: A Comprehensive Course"
                        },
                        new
                        {
                            Id = 19,
                            Author = "Jurgensen",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1100f,
                            Title = "Contemporary Geometry: A Comprehensive Course"
                        },
                        new
                        {
                            Id = 20,
                            Author = "Dan Kennedy",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1200f,
                            Title = "High School Geometry Unlocked: Your Key to Mastering Geometry"
                        },
                        new
                        {
                            Id = 21,
                            Author = "Frederick E. Hohn",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1300f,
                            Title = "Geometry: Student Edition"
                        },
                        new
                        {
                            Id = 22,
                            Author = "Frederick E. Hohn",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1300f,
                            Title = "Geometry: Student Edition"
                        },
                        new
                        {
                            Id = 23,
                            Author = "Franz Schwabl",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1400f,
                            Title = "Quantum Mechanics: An Introduction"
                        },
                        new
                        {
                            Id = 24,
                            Author = "Paul A.M. Dirac",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1500f,
                            Title = "Principles of Quantum Mechanics"
                        },
                        new
                        {
                            Id = 25,
                            Author = "Paul A.M. Dirac",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1500f,
                            Title = "Principles of Quantum Mechanics"
                        },
                        new
                        {
                            Id = 26,
                            Author = "Sakurai",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1600f,
                            Title = "Modern Quantum Mechanics"
                        },
                        new
                        {
                            Id = 27,
                            Author = "John S. Townsend",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1700f,
                            Title = "A Modern Approach to Quantum Mechanics"
                        },
                        new
                        {
                            Id = 28,
                            Author = "Steven Weinberg",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1800f,
                            Title = "Lectures on Quantum Mechanics"
                        },
                        new
                        {
                            Id = 29,
                            Author = "Steven Weinberg",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1800f,
                            Title = "Lectures on Quantum Mechanics"
                        },
                        new
                        {
                            Id = 30,
                            Author = "Steven Weinberg",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1800f,
                            Title = "Lectures on Quantum Mechanics"
                        },
                        new
                        {
                            Id = 31,
                            Author = "Peter Atkins",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 1900f,
                            Title = "Biophysics: A Student's Guide"
                        },
                        new
                        {
                            Id = 32,
                            Author = "William Bialek",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 2000f,
                            Title = "Biophysics: Searching for Principles"
                        },
                        new
                        {
                            Id = 33,
                            Author = "William Bialek",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 2000f,
                            Title = "Biophysics: Searching for Principles"
                        },
                        new
                        {
                            Id = 34,
                            Author = "Philip Nelson",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 2100f,
                            Title = "Biological Physics: Energy, Information, Life"
                        },
                        new
                        {
                            Id = 35,
                            Author = "Herman C. Berg",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 2200f,
                            Title = "Principles of Biophysics"
                        },
                        new
                        {
                            Id = 36,
                            Author = "Klaus Schulten",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 2300f,
                            Title = "Introduction to Computational Biophysics"
                        },
                        new
                        {
                            Id = 37,
                            Author = "Bernard Pullman",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 2400f,
                            Title = "Theoretical Aspects of Biophysics"
                        },
                        new
                        {
                            Id = 38,
                            Author = "Joseph T. DiPiro",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2500f,
                            Title = "Pharmacotherapy: A Pathophysiologic Approach"
                        },
                        new
                        {
                            Id = 39,
                            Author = "Joseph T. DiPiro",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2500f,
                            Title = "Pharmacotherapy: A Pathophysiologic Approach"
                        },
                        new
                        {
                            Id = 40,
                            Author = "Joseph T. DiPiro",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2500f,
                            Title = "Pharmacotherapy: A Pathophysiologic Approach"
                        },
                        new
                        {
                            Id = 41,
                            Author = "Karen Whalen",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2600f,
                            Title = "Community Pharmacy Practice Case Studies"
                        },
                        new
                        {
                            Id = 42,
                            Author = "Loyd V. Allen Jr.",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2700f,
                            Title = "Remington: The Science and Practice of Pharmacy"
                        },
                        new
                        {
                            Id = 43,
                            Author = "Barbara G. Wells",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2800f,
                            Title = "Pharmacotherapy Handbook"
                        },
                        new
                        {
                            Id = 44,
                            Author = "Barbara G. Wells",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2800f,
                            Title = "Pharmacotherapy Handbook"
                        },
                        new
                        {
                            Id = 45,
                            Author = "Debbie S. Robinson",
                            BookCategoryId = 6,
                            Ordered = false,
                            Price = 3000f,
                            Title = "Essentials of Dental Assisting"
                        },
                        new
                        {
                            Id = 46,
                            Author = "Doni L. Bird",
                            BookCategoryId = 6,
                            Ordered = false,
                            Price = 3100f,
                            Title = "Modern Dental Assisting"
                        },
                        new
                        {
                            Id = 47,
                            Author = "Alice E. Curran",
                            BookCategoryId = 6,
                            Ordered = false,
                            Price = 3100f,
                            Title = "General and Oral Pathology"
                        },
                        new
                        {
                            Id = 48,
                            Author = "Morris Mano",
                            BookCategoryId = 7,
                            Ordered = false,
                            Price = 3200f,
                            Title = "Computer System Architecture"
                        },
                        new
                        {
                            Id = 49,
                            Author = "Thomas C. Bartee",
                            BookCategoryId = 7,
                            Ordered = false,
                            Price = 3300f,
                            Title = "Computer Architecture and Logic Design"
                        },
                        new
                        {
                            Id = 50,
                            Author = "Thomas C. Bartee",
                            BookCategoryId = 7,
                            Ordered = false,
                            Price = 3300f,
                            Title = "Computer Architecture and Logic Design"
                        },
                        new
                        {
                            Id = 51,
                            Author = "William Stallings",
                            BookCategoryId = 7,
                            Ordered = false,
                            Price = 3400f,
                            Title = "Computer Organization and Architecture"
                        },
                        new
                        {
                            Id = 52,
                            Author = "Eric Freeman",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3500f,
                            Title = "Head First Design Patterns"
                        },
                        new
                        {
                            Id = 53,
                            Author = "Martin Fowler",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3600f,
                            Title = "Refactoring: Improving the Design of Existing Code"
                        },
                        new
                        {
                            Id = 54,
                            Author = "Martin Fowler",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3600f,
                            Title = "Refactoring: Improving the Design of Existing Code"
                        },
                        new
                        {
                            Id = 55,
                            Author = "Andrew Hunt",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3700f,
                            Title = "The Pragmatic Programmer: Your Journey to Mastery"
                        },
                        new
                        {
                            Id = 56,
                            Author = "Bjarne Stroustrup",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3800f,
                            Title = "The C++ Programming Language"
                        },
                        new
                        {
                            Id = 57,
                            Author = "Bjarne Stroustrup",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3800f,
                            Title = "The C++ Programming Language"
                        },
                        new
                        {
                            Id = 58,
                            Author = "Bjarne Stroustrup",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3800f,
                            Title = "The C++ Programming Language"
                        },
                        new
                        {
                            Id = 59,
                            Author = "Bjarne Stroustrup",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3800f,
                            Title = "The C++ Programming Language"
                        },
                        new
                        {
                            Id = 60,
                            Author = "Bjarne Stroustrup",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3800f,
                            Title = "The C++ Programming Language"
                        });
                });

            modelBuilder.Entity("API.NewFolder.BookCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "mathematics",
                            SubCategory = "algebra"
                        },
                        new
                        {
                            Id = 2,
                            Category = "mathematics",
                            SubCategory = "geometry"
                        },
                        new
                        {
                            Id = 3,
                            Category = "physics",
                            SubCategory = "quantum physics"
                        },
                        new
                        {
                            Id = 4,
                            Category = "physics",
                            SubCategory = "biophysics"
                        },
                        new
                        {
                            Id = 5,
                            Category = "medicine",
                            SubCategory = "pharmacy"
                        },
                        new
                        {
                            Id = 6,
                            Category = "medicine",
                            SubCategory = "dental"
                        },
                        new
                        {
                            Id = 7,
                            Category = "computer",
                            SubCategory = "hardware"
                        },
                        new
                        {
                            Id = 8,
                            Category = "computer",
                            SubCategory = "software"
                        });
                });

            modelBuilder.Entity("API.NewFolder.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("FinePaid")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Returned")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("API.NewFolder.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountStatus = "ACTIVE",
                            CreateOn = new DateTime(2024, 1, 1, 11, 12, 13, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            FName = "Admin",
                            LName = "",
                            MobNumber = "123567890",
                            Password = "admin1",
                            UserType = "ADMIN"
                        });
                });

            modelBuilder.Entity("API.NewFolder.Book", b =>
                {
                    b.HasOne("API.NewFolder.BookCategory", "BookCategory")
                        .WithMany()
                        .HasForeignKey("BookCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookCategory");
                });

            modelBuilder.Entity("API.NewFolder.Order", b =>
                {
                    b.HasOne("API.NewFolder.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.NewFolder.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
