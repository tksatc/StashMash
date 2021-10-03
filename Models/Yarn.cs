using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StashMash.Models
{
    public class Yarn
    {
        public int YarnId { get; set; }
        [Required(ErrorMessage ="Please enter the manufacturer")]
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        [Required(ErrorMessage ="Please enter the name of the yarn.")]
        [StringLength(30, ErrorMessage ="The yarn name cannot exceed 30 characters.")]
        public String Name { get; set; }
        public int FiberId { get; set; }
        public Fiber Fiber { get; set; }
        [Required(ErrorMessage ="Please enter the yarn weight, 0-7.")]
        [Range(1, 1, ErrorMessage ="The yarn weight is a single digit between 0 and 7.")]
        public int FiberWeightId { get; set; }
        public FiberWeight FiberWeight { get; set; }

        public int SkeinYardage { get; set; }
        public double SkeinWeight { get; set; }
        public string MeasurementUnit { get; set; }
        public DateTime DateUpdated { get; set; } = DateTime.Now;
    }
}
