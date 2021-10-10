using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StashMash.Models
{
    public class WearableSize
    {
        public int WearableSizeId { get; set; }
        public int PatternId { get; set; }
        public Pattern Pattern { get; set; }
        public string wearableSizeOption { get; set; }
        public string wearableSizeId { get; set; }
    }
}
