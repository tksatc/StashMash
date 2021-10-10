using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace StashMash.Models
{
    public class NeedleLength
    {
        public int NeedleLengthId { get; set; }

        [Required(ErrorMessage = "Please enter the length of the needle.")]
        [Range(1, 5, ErrorMessage = "The length cannot exceed 5 digits.")]
        public decimal Length { get; set; }

        public int MeasurementUnitId { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
    }
}
