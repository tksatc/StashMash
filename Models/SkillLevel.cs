using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace StashMash.Models
{
    public class SkillLevel
    {
        public int SkillLevelId { get; set; }

        [Required(ErrorMessage = "Please enter a skill level.")]
        [Range(1, 50, ErrorMessage = "Skill Level must be between 1 and 50 characters."]
        public string Level { get; set; }
    }
}
