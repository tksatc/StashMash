using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace StashMash.Models
{
    public class Category
    {
        public int PatternCategoryId { get; set; }

        [Required(ErrorMessage = "Please enter a category name.")]
        [StringLength(50, ErrorMessage = "Category name cannot exceed 50 characters.")]
        public string Name { get; set; }
    }
}
