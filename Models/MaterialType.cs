using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace StashMash.Models
{
    public class MaterialType
    {
        public int MaterialTypeId { get; set; }
        [Required(ErrorMessage = "Please enter a description of the material.")]
        [StringLength(20, ErrorMessage = "Material description cannot exceed 20 characters.")]
        public string Name { get; set; }
    }
}
