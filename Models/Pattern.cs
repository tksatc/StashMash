using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace StashMash.Models
{
    public class Pattern
    {
        public int PatternId { get; set; }

        [Required(ErrorMessage = "Please enter a name for the pattern.")]
        [StringLength(50, ErrorMessage = "Pattern name cannot exceed 50 characters.")]
        public string Name { get; set; }
        public int ManufacturerId { get; set;}
        public Manufacturer Manufacturer { get; set; }

        public int DesignerId { get; set; }
        public Designer Designer { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SkillLevelId { get; set; }
        public SkillLevel SkillLevel { get; set; }
        public string StorageLocation { get; set; }
        public DateTime DateUpdated { get; set; } = DateTime.Now;
    }
}
