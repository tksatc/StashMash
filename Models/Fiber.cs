using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StashMash.Models
{
    public class Fiber
    {
        public int FiberId { get; set; }
        [Required(ErrorMessage ="Please enter the type of fiber.")]
        public String Name { get; set; }
    }
}
