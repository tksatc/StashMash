using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace StashMash.Models
{
    public class NeedleType
    {
        public int NeedleTypeId { get; set; }

        [Required(ErrorMessage = "Please enter the type of needle.")]
        [StringLength(20, ErrorMessage = "The needle type name cannot exceed 20 characters.")]
        public string Name { get; set; }
    }
}
