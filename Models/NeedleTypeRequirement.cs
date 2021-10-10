using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StashMash.Models
{
    public class NeedleTypeRequirement
    {
        public int NeedleTypeRequirementId { get; set; }
        public int PatternId { get; set; }
        public Pattern Pattern { get; set; }
        public string needleTypeOption { get; set; }
        public string needleTypeId { get; set; }
    }
}
