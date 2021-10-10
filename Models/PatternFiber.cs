using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StashMash.Models
{
    public class PatternFiber
    {
        public int PatternFiberId { get; set; }
        public int PatternId { get; set; }
        public Pattern Pattern { get; set; }
        public string yarnWeightOption { get; set; }
        public int yarnWeightId { get; set; }
    }
}
