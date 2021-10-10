using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace StashMash.Models
{
    public class Needle
    {
        public int NeedleId { get; set; }

        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public int NeedleTypeId { get; set; }
        public NeedleType NeedleType { get; set; }

        public int MaterialTypeId { get; set; }
        public MaterialType MaterialType { get; set; }

        public int NeedleSizeId { get; set; }
        public NeedleSize NeedleSize { get; set; }

        public int NeedleLengthId { get; set; }

        public NeedleLength NeedleLength { get; set; }
        public DateTime DateUpdated { get; set; } = DateTime.Now;
    }
}
