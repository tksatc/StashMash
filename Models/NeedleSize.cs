using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace StashMash.Models
{
    public class NeedleSize
    {
        public int NeedleSizeId { get; set; }

        [Required(ErrorMessage = "Please enter the diameter of the needle.")]
        [Range(1, 5, ErrorMessage = "The diameter must be between 1 and 5 characters, including a decimal point.")]
        public double Size { get; set; }
        public int MeasurementUnitId { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }

        public double EquivalentUS { get; set; }
    }
}
