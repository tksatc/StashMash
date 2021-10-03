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
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
