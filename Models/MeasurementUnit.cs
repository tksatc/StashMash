using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace StashMash.Models
{
    public class MeasurementUnit
    {
        public int MeasurementUnitId { get; set; }
        [Required(ErrorMessage = "Please enter a description of the unit.")]
        public string Name { get; set; }
    }
}
