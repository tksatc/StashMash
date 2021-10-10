using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace StashMash.Models
{
    public class Designer
    {
        public int DesignerId { get; set; }
        [StringLength(20, ErrorMessage = "The first name cannot exceed 20 characters.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a last name for the designer.")]
        [StringLength(20, ErrorMessage = "The last name cannot exceed 20 characters.")]
        public string LastName { get; set; }
    }
}
