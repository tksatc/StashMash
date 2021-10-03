using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StashMash.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        [Required(ErrorMessage ="Please enter the manufacturer's name")]
        [StringLength(30, ErrorMessage ="The manufacturer's name cannot exceed 30 characters.")]
        public String Name { get; set; }

        public String Url { get; set; }
    }
}
