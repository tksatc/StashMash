using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StashMash.Models
{
    public class StashMashContext : DbContext
    {
        public StashMashContext(DbContextOptions<StashMashContext> options)
            : base(options)
        { }

        public DbSet<YarnDetail> YarnDetails { get; set; }
        public DbSet<Yarn> Yarn { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Fiber> Fibers { get; set; }
        public DbSet<FiberWeight> FiberWeights { get; set; }

        // Added 10-10-21
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
        public DbSet<ProductLine> ProductLines { get; set; }
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<NeedleType> NeedleTypes { get; set; }
        public DbSet<NeedleSize> NeedleSizes { get; set; }
        public DbSet<NeedleLength> NeedleLengths { get; set; }
        public DbSet<Needle> Needles { get; set; }
        public DbSet<Designer> Designers { get; set; }
        public DbSet<SkillLevel> SkillLevels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<WearableSize> WearableSizes { get; set; }
        public DbSet<Pattern> Patterns { get; set; }
        public DbSet<PatternProperties> PatternProperties { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer { ManufacturerId = 4, Name = "Knitter's Pride", Url = "https://www.knitterspride.com" },
                new Manufacturer { ManufacturerId = 5, Name = "Addi", Url = "https://addi.de" },
                new Manufacturer { ManufacturerId = 6, Name = "Clover", Url = "https://clover-usa.com" },
                new Manufacturer { ManufacturerId = 7, Name = "Cocoknits", Url = "https://cocoknits.com" },
                new Manufacturer { ManufacturerId = 8, Name = "Churchmouse Yarns & Tees", Url = "https://churchmouseyarns.com" },
                new Manufacturer { ManufacturerId = 9, Name = "Louet", Url = "https://louet.com" }
                );

            modelBuilder.Entity<Designer>().HasData(
                new Designer { DesignerId = 1, FirstName = "Julie", LastName = "Weisenberger" },
                new Designer { DesignerId = 2, LastName = "Churchmouse Classic" },
                new Designer { DesignerId = 3, FirstName = "Trudy", LastName = "Van Stralen" }
                );

            modelBuilder.Entity<MeasurementUnit>().HasData(
                new MeasurementUnit { MeasurementUnitId = 1, Name = "in" },
                new MeasurementUnit { MeasurementUnitId = 2, Name = "yards" },
                new MeasurementUnit { MeasurementUnitId = 3, Name = "cm" },
                new MeasurementUnit { MeasurementUnitId = 4, Name = "mm" }
                );

            modelBuilder.Entity<ProductLine>().HasData(
                new ProductLine { ProductLineId = 1, Name = "yarn" },
                new ProductLine { ProductLineId = 2, Name = "needles" },
                new ProductLine { ProductLineId = 3, Name = "patterns" }
                );

            modelBuilder.Entity<MaterialType>().HasData(
                new MaterialType { MaterialTypeId = 1, Name = "aluminum" },
                new MaterialType { MaterialTypeId = 2, Name = "bamboo" },
                new MaterialType { MaterialTypeId = 3, Name = "wood" },
                new MaterialType { MaterialTypeId = 4, Name = "plastic" }
                );

            modelBuilder.Entity<NeedleType>().HasData(
                new NeedleType { NeedleTypeId = 1, Name = "DPN" },
                new NeedleType { NeedleTypeId = 2, Name = "straight" },
                new NeedleType { NeedleTypeId = 3, Name = "circular" },
                new NeedleType { NeedleTypeId = 4, Name = "interchangeable" },
                new NeedleType { NeedleTypeId = 5, Name = "cable" }
                );

            modelBuilder.Entity<NeedleSize>().HasData(
                new NeedleSize { NeedleSizeId = 1, Size = 2.0, MeasurementUnitId = 4, EquivalentUS = 0 },
                new NeedleSize { NeedleSizeId = 2, Size = 2.25, MeasurementUnitId = 4, EquivalentUS = 1 },
                new NeedleSize { NeedleSizeId = 3, Size = 2.5, MeasurementUnitId = 4, EquivalentUS = 1.5 },
                new NeedleSize { NeedleSizeId = 4, Size = 2.75, MeasurementUnitId = 4, EquivalentUS = 2 },
                new NeedleSize { NeedleSizeId = 5, Size = 3.0, MeasurementUnitId = 4, EquivalentUS = 2.5 },
                new NeedleSize { NeedleSizeId = 6, Size = 3.25, MeasurementUnitId = 4, EquivalentUS = 3 },
                new NeedleSize { NeedleSizeId = 7, Size = 3.5, MeasurementUnitId = 4, EquivalentUS = 4 },
                new NeedleSize { NeedleSizeId = 8, Size = 3.75, MeasurementUnitId = 4, EquivalentUS = 5 },
                new NeedleSize { NeedleSizeId = 9, Size = 4.0, MeasurementUnitId = 4, EquivalentUS = 6 },
                new NeedleSize { NeedleSizeId = 10, Size = 4.5, MeasurementUnitId = 4, EquivalentUS = 7 },
                new NeedleSize { NeedleSizeId = 11, Size = 5.0, MeasurementUnitId = 4, EquivalentUS = 8 },
                new NeedleSize { NeedleSizeId = 12, Size = 5.5, MeasurementUnitId = 4, EquivalentUS = 9 },
                new NeedleSize { NeedleSizeId = 13, Size = 6.0, MeasurementUnitId = 4, EquivalentUS = 10 },
                new NeedleSize { NeedleSizeId = 14, Size = 6.5, MeasurementUnitId = 4, EquivalentUS = 10.5 },
                new NeedleSize { NeedleSizeId = 15, Size = 7.0, MeasurementUnitId = 4 },
                new NeedleSize { NeedleSizeId = 16, Size = 7.5, MeasurementUnitId = 4 },
                new NeedleSize { NeedleSizeId = 17, Size = 8.0, MeasurementUnitId = 4, EquivalentUS = 11 },
                new NeedleSize { NeedleSizeId = 18, Size = 9.0, MeasurementUnitId = 4, EquivalentUS = 13 },
                new NeedleSize { NeedleSizeId = 19, Size = 10.0, MeasurementUnitId = 4, EquivalentUS = 15 },
                new NeedleSize { NeedleSizeId = 20, Size = 12, MeasurementUnitId = 4, EquivalentUS = 17 },
                new NeedleSize { NeedleSizeId = 21, Size = 15, MeasurementUnitId = 4, EquivalentUS = 19 },
                new NeedleSize { NeedleSizeId = 22, Size = 19.0, MeasurementUnitId = 4, EquivalentUS = 35 },
                new NeedleSize { NeedleSizeId = 23, Size = 20.0, MeasurementUnitId = 4, EquivalentUS = 36 },
                new NeedleSize { NeedleSizeId = 24, Size = 25.0, MeasurementUnitId = 4, EquivalentUS = 50 }
                );

            modelBuilder.Entity<NeedleLength>().HasData(
                new NeedleLength { NeedleLengthId = 1, Length = 4, MeasurementUnitId = 1 },
                new NeedleLength { NeedleLengthId = 2, Length = 5, MeasurementUnitId = 1 },
                new NeedleLength { NeedleLengthId = 3, Length = 6, MeasurementUnitId = 1 },
                new NeedleLength { NeedleLengthId = 4, Length = 7, MeasurementUnitId = 1 },
                new NeedleLength { NeedleLengthId = 5, Length = 8, MeasurementUnitId = 1 },
                new NeedleLength { NeedleLengthId = 6, Length = 9, MeasurementUnitId = 1 },
                new NeedleLength { NeedleLengthId = 7, Length = 10, MeasurementUnitId = 1 },
                new NeedleLength { NeedleLengthId = 8, Length = 12, MeasurementUnitId = 1 },
                new NeedleLength { NeedleLengthId = 9, Length = 14, MeasurementUnitId = 1 },
                new NeedleLength { NeedleLengthId = 10, Length = 16, MeasurementUnitId = 1 },
                new NeedleLength { NeedleLengthId = 11, Length = 24, MeasurementUnitId = 1 },
                new NeedleLength { NeedleLengthId = 12, Length = 32, MeasurementUnitId = 1 },
                new NeedleLength { NeedleLengthId = 13, Length = 40, MeasurementUnitId = 1 },
                new NeedleLength { NeedleLengthId = 14, Length = 60, MeasurementUnitId = 1 }
                );

            modelBuilder.Entity<Needle>().HasData(
                new Needle 
                {
                    NeedleId = 1,
                    ManufacturerId = 4,
                    NeedleTypeId = 4,
                    MaterialTypeId = 3,
                    NeedleSizeId = 7
                },
                new Needle
                {
                    NeedleId = 2,
                    ManufacturerId = 4,
                    NeedleTypeId = 4,
                    MaterialTypeId = 3,
                    NeedleSizeId = 8
                },
                new Needle
                {
                    NeedleId = 3,
                    ManufacturerId = 4,
                    NeedleTypeId = 4,
                    MaterialTypeId = 3,
                    NeedleSizeId = 9
                }
                );

            modelBuilder.Entity<SkillLevel>().HasData(
                new SkillLevel { SkillLevelId = 1, Level = "beginner" },
                new SkillLevel { SkillLevelId = 2, Level = "easy" },
                new SkillLevel { SkillLevelId = 3, Level = "intermediate" },
                new SkillLevel { SkillLevelId = 4, Level = "experienced"}
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { PatternCategoryId = 1, Name = "home decor" },
                new Category { PatternCategoryId = 2, Name = "home use" },
                new Category { PatternCategoryId = 3, Name = "infant clothing" },
                new Category { PatternCategoryId = 4, Name = "children clothing" },
                new Category { PatternCategoryId = 5, Name = "women clothing" },
                new Category { PatternCategoryId = 6, Name = "men clothing" },
                new Category { PatternCategoryId = 7, Name = "wearable accessories" },
                new Category { PatternCategoryId = 8, Name = "toys" },
                new Category { PatternCategoryId = 9, Name = "pets" }
                );

            modelBuilder.Entity<WearableSize>().HasData(
                new WearableSize { WearableSizeId = 1, Name = "XXS" },
                new WearableSize { WearableSizeId = 2, Name = "XS" },
                new WearableSize { WearableSizeId = 3, Name = "S" },
                new WearableSize { WearableSizeId = 4, Name = "M" },
                new WearableSize { WearableSizeId = 5, Name = "L" },
                new WearableSize { WearableSizeId = 6, Name = "XL" },
                new WearableSize { WearableSizeId = 7, Name = "2X" },
                new WearableSize { WearableSizeId = 8, Name = "3X" }
                );

            modelBuilder.Entity<Pattern>().HasData(
                new Pattern
                {
                    PatternId = 1,
                    Name = "Rosemarie",
                    ManufacturerId = 9,
                    DesignerId = 3,
                    CategoryId = 5,
                    SkillLevelId = 4,
                    StorageLocation = "shelf"
                },
                new Pattern
                {
                    PatternId = 2,
                    Name = "Simple Tee",
                    ManufacturerId = 8,
                    DesignerId = 2,
                    CategoryId = 5,
                    SkillLevelId = 3,
                    StorageLocation = "shelf"
                },
                new Pattern
                {
                    PatternId = 3,
                    Name = "Gretel",
                    ManufacturerId = 7,
                    DesignerId = 1,
                    CategoryId = 5,
                    SkillLevelId = 3,
                    StorageLocation = "shelf"
                }
                );

            modelBuilder.Entity<PatternProperties>().HasData(
                new PatternProperties
                {
                    PatternPropertiesId = 1,
                    PatternId = 3,
                    yarnWeightOption = "fiberWeightId",
                    yarnWeightId = "3",
                    needleTypeOption = "needleTypeId",
                    needleTypeId = "5",
                    needleSizeOption = "needleSizeId",
                    needleSizeId = "9",
                    wearableSizeOption = "wearableSizeId",
                    wearableSizeId = "5"
                }
                );



// END OF 10-10-21 ADDITIONS

modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer { ManufacturerId = 1, Name = "Nako", Url = "http://www.nako.com/" },
                new Manufacturer { ManufacturerId = 2, Name = "Rowan", Url = "https://knitrowan.com" },
                new Manufacturer { ManufacturerId = 3, Name = "Shibui", Url = "https://shibuiknits.com" }
                );

            modelBuilder.Entity<Fiber>().HasData(
                new Fiber { FiberId = 1, Name = "Wool" },
                new Fiber { FiberId = 2, Name = "Cashmere" },
                new Fiber { FiberId = 3, Name = "Alpaca" },
                new Fiber { FiberId = 4, Name = "Merino Wool" },
                new Fiber { FiberId = 5, Name = "Organic Wool" },
                new Fiber { FiberId = 6, Name = "Cotton" },
                new Fiber { FiberId = 7, Name = "Mercerized Cotton" },
                new Fiber { FiberId = 8, Name = "Silk" },
                new Fiber { FiberId = 9, Name = "Hemp" },
                new Fiber { FiberId = 10, Name = "Bamboo" },
                new Fiber { FiberId = 11, Name = "Acrylic" },
                new Fiber { FiberId = 12, Name = "Angora" },
                new Fiber { FiberId = 13, Name = "Boucle" },
                new Fiber { FiberId = 14, Name = "Chenille" },
                new Fiber { FiberId = 15, Name = "Faux Fur" },
                new Fiber { FiberId = 16, Name = "Railroad Ribbon" },
                new Fiber { FiberId = 17, Name = "Polyester" },
                new Fiber { FiberId = 18, Name = "Mohair" },
                new Fiber { FiberId = 19, Name = "Kid Mohair" },
                new Fiber { FiberId = 20, Name = "Eyelash" }
                );

            modelBuilder.Entity<FiberWeight>().HasData(
                new FiberWeight { FiberWeightId = 1, Name = "Lace", Symbol = 0 },
                new FiberWeight { FiberWeightId = 2, Name = "Fingering", Symbol = 1 },
                new FiberWeight { FiberWeightId = 3, Name = "Fine", Symbol = 2 },
                new FiberWeight { FiberWeightId = 4, Name = "DK", Symbol = 3 },
                new FiberWeight { FiberWeightId = 5, Name = "Worsted", Symbol = 4 },
                new FiberWeight { FiberWeightId = 6, Name = "Bulky", Symbol = 5 },
                new FiberWeight { FiberWeightId = 7, Name = "Super Bulky", Symbol = 6 },
                new FiberWeight { FiberWeightId = 8, Name = "Jumbo", Symbol = 7 }
                );

            modelBuilder.Entity<Yarn>().HasData(
                new Yarn { YarnId = 1, Name = "Arya Ebruli", ManufacturerId = 1, FiberId = 3, FiberWeightId = 3, SkeinYardage = 550, SkeinWeight = 100 },
                new Yarn { YarnId = 2, Name = "Brushed Fleece", ManufacturerId = 2, FiberId = 4, FiberWeightId = 6, SkeinYardage = 115, SkeinWeight = 50},
                new Yarn { YarnId = 3, Name = "Silk Cloud", ManufacturerId = 3, FiberId = 19, FiberWeightId = 1, SkeinYardage = 330, SkeinWeight = 25}
                );
            modelBuilder.Entity<YarnDetail>().HasData(
                new YarnDetail { YarnDetailId = 1, YarnId = 1, YarnColor = "Gray", YarnColorCode = "86398", YarnColorLot = "76643", QuantityOfSkeins = 4},
                new YarnDetail { YarnDetailId = 2, YarnId = 2, YarnColor = "Green", YarnColorCode = "00236", YarnColorLot = "3848", QuantityOfSkeins = 1},
                new YarnDetail { YarnDetailId = 3, YarnId = 3, YarnColor = "Silver", YarnColorCode = "2022", YarnColorLot = "1256", QuantityOfSkeins = 7}
                );
        }
    }
}
