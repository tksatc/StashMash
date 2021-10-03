﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StashMash.Models;

namespace StashMash.Migrations
{
    [DbContext(typeof(StashMashContext))]
    [Migration("20211003142642_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StashMash.Models.Fiber", b =>
                {
                    b.Property<int>("FiberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FiberId");

                    b.ToTable("Fibers");

                    b.HasData(
                        new
                        {
                            FiberId = 1,
                            Name = "Wool"
                        },
                        new
                        {
                            FiberId = 2,
                            Name = "Cashmere"
                        },
                        new
                        {
                            FiberId = 3,
                            Name = "Alpaca"
                        },
                        new
                        {
                            FiberId = 4,
                            Name = "Merino Wool"
                        },
                        new
                        {
                            FiberId = 5,
                            Name = "Organic Wool"
                        },
                        new
                        {
                            FiberId = 6,
                            Name = "Cotton"
                        },
                        new
                        {
                            FiberId = 7,
                            Name = "Mercerized Cotton"
                        },
                        new
                        {
                            FiberId = 8,
                            Name = "Silk"
                        },
                        new
                        {
                            FiberId = 9,
                            Name = "Hemp"
                        },
                        new
                        {
                            FiberId = 10,
                            Name = "Bamboo"
                        },
                        new
                        {
                            FiberId = 11,
                            Name = "Acrylic"
                        },
                        new
                        {
                            FiberId = 12,
                            Name = "Angora"
                        },
                        new
                        {
                            FiberId = 13,
                            Name = "Boucle"
                        },
                        new
                        {
                            FiberId = 14,
                            Name = "Chenille"
                        },
                        new
                        {
                            FiberId = 15,
                            Name = "Faux Fur"
                        },
                        new
                        {
                            FiberId = 16,
                            Name = "Railroad Ribbon"
                        },
                        new
                        {
                            FiberId = 17,
                            Name = "Polyester"
                        },
                        new
                        {
                            FiberId = 18,
                            Name = "Mohair"
                        },
                        new
                        {
                            FiberId = 19,
                            Name = "Kid Mohair"
                        },
                        new
                        {
                            FiberId = 20,
                            Name = "Eyelash"
                        });
                });

            modelBuilder.Entity("StashMash.Models.FiberWeight", b =>
                {
                    b.Property<int>("FiberWeightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Symbol")
                        .HasColumnType("int");

                    b.HasKey("FiberWeightId");

                    b.ToTable("FiberWeights");

                    b.HasData(
                        new
                        {
                            FiberWeightId = 1,
                            Name = "Lace",
                            Symbol = 0
                        },
                        new
                        {
                            FiberWeightId = 2,
                            Name = "Fingering",
                            Symbol = 1
                        },
                        new
                        {
                            FiberWeightId = 3,
                            Name = "Fine",
                            Symbol = 2
                        },
                        new
                        {
                            FiberWeightId = 4,
                            Name = "DK",
                            Symbol = 3
                        },
                        new
                        {
                            FiberWeightId = 5,
                            Name = "Worsted",
                            Symbol = 4
                        },
                        new
                        {
                            FiberWeightId = 6,
                            Name = "Bulky",
                            Symbol = 5
                        },
                        new
                        {
                            FiberWeightId = 7,
                            Name = "Super Bulky",
                            Symbol = 6
                        },
                        new
                        {
                            FiberWeightId = 8,
                            Name = "Jumbo",
                            Symbol = 7
                        });
                });

            modelBuilder.Entity("StashMash.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManufacturerId");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            ManufacturerId = 1,
                            Name = "Nako",
                            Url = "http://www.nako.com/"
                        },
                        new
                        {
                            ManufacturerId = 2,
                            Name = "Rowan",
                            Url = "https://knitrowan.com"
                        },
                        new
                        {
                            ManufacturerId = 3,
                            Name = "Shibui",
                            Url = "https://shibuiknits.com"
                        });
                });

            modelBuilder.Entity("StashMash.Models.Yarn", b =>
                {
                    b.Property<int>("YarnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("FiberId")
                        .HasColumnType("int");

                    b.Property<int>("FiberWeightId")
                        .HasColumnType("int");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("MeasurementUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<double>("SkeinWeight")
                        .HasColumnType("float");

                    b.Property<int>("SkeinYardage")
                        .HasColumnType("int");

                    b.HasKey("YarnId");

                    b.HasIndex("FiberId");

                    b.HasIndex("FiberWeightId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Yarn");

                    b.HasData(
                        new
                        {
                            YarnId = 1,
                            DateUpdated = new DateTime(2021, 10, 3, 6, 26, 42, 60, DateTimeKind.Local).AddTicks(7053),
                            FiberId = 3,
                            FiberWeightId = 3,
                            ManufacturerId = 1,
                            Name = "Arya Ebruli",
                            SkeinWeight = 100.0,
                            SkeinYardage = 550
                        },
                        new
                        {
                            YarnId = 2,
                            DateUpdated = new DateTime(2021, 10, 3, 6, 26, 42, 61, DateTimeKind.Local).AddTicks(4451),
                            FiberId = 4,
                            FiberWeightId = 6,
                            ManufacturerId = 2,
                            Name = "Brushed Fleece",
                            SkeinWeight = 50.0,
                            SkeinYardage = 115
                        },
                        new
                        {
                            YarnId = 3,
                            DateUpdated = new DateTime(2021, 10, 3, 6, 26, 42, 61, DateTimeKind.Local).AddTicks(4509),
                            FiberId = 19,
                            FiberWeightId = 1,
                            ManufacturerId = 3,
                            Name = "Silk Cloud",
                            SkeinWeight = 25.0,
                            SkeinYardage = 330
                        });
                });

            modelBuilder.Entity("StashMash.Models.YarnDetail", b =>
                {
                    b.Property<int>("YarnDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<double>("QuantityOfSkeins")
                        .HasColumnType("float");

                    b.Property<string>("YarnColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YarnColorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YarnColorLot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YarnId")
                        .HasColumnType("int");

                    b.HasKey("YarnDetailId");

                    b.HasIndex("YarnId");

                    b.ToTable("YarnDetails");

                    b.HasData(
                        new
                        {
                            YarnDetailId = 1,
                            DateUpdated = new DateTime(2021, 10, 3, 6, 26, 42, 61, DateTimeKind.Local).AddTicks(5115),
                            QuantityOfSkeins = 4.0,
                            YarnColor = "Gray",
                            YarnColorCode = "86398",
                            YarnColorLot = "76643",
                            YarnId = 1
                        },
                        new
                        {
                            YarnDetailId = 2,
                            DateUpdated = new DateTime(2021, 10, 3, 6, 26, 42, 61, DateTimeKind.Local).AddTicks(6205),
                            QuantityOfSkeins = 1.0,
                            YarnColor = "Green",
                            YarnColorCode = "00236",
                            YarnColorLot = "3848",
                            YarnId = 2
                        },
                        new
                        {
                            YarnDetailId = 3,
                            DateUpdated = new DateTime(2021, 10, 3, 6, 26, 42, 61, DateTimeKind.Local).AddTicks(6246),
                            QuantityOfSkeins = 7.0,
                            YarnColor = "Silver",
                            YarnColorCode = "2022",
                            YarnColorLot = "1256",
                            YarnId = 3
                        });
                });

            modelBuilder.Entity("StashMash.Models.Yarn", b =>
                {
                    b.HasOne("StashMash.Models.Fiber", "Fiber")
                        .WithMany()
                        .HasForeignKey("FiberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StashMash.Models.FiberWeight", "FiberWeight")
                        .WithMany()
                        .HasForeignKey("FiberWeightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StashMash.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StashMash.Models.YarnDetail", b =>
                {
                    b.HasOne("StashMash.Models.Yarn", "Yarn")
                        .WithMany()
                        .HasForeignKey("YarnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}