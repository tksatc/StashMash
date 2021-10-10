using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StashMash.Models
{
    public class PatternProperties
    {
        public int PatternPropertiesId { get; set; }

        public int PatternId { get; set; }
        public Pattern Pattern { get; set; }

        public string yarnWeightOption { get; set; }
        public string yarnWeightId { get; set; }

        public string needleTypeOption { get; set; }
        public string needleTypeId { get; set; }

        public string needleSizeOption { get; set; }
        public string needleSizeId { get; set; }

        public string wearableSizeOption { get; set; }
        public string wearableSizeId { get; set; }
    }
}
