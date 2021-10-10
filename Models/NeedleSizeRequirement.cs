using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StashMash.Models
{
    public class NeedleSizeRequirement
    {
        public int NeedleSizeRequirementId { get; set; }
        public int PatternId { get; set; }
        public Pattern Pattern { get; set; }
        public string needleSizeOption { get; set; }
        public string needleSizeId { get; set; }
    }
}
