using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StashMash.Models
{
    public class FiberWeight
    {
        public int FiberWeightId { get; set; }
        [Required(ErrorMessage ="Please enter the numerical symbol for the yarn weight.")]
        public int Symbol { get; set; }
        public String Name { get; set; }
    }
}
