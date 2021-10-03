using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StashMash.Models
{
    public class YarnDetail
    {
        public int YarnDetailId { get; set; }
        [Required(ErrorMessage ="You must enter a yarn to provide the details.")]
        public int YarnId { get; set; }
        public Yarn Yarn { get; set; }
        public string YarnColor { get; set; }
        public string YarnColorCode { get; set; }
        public string YarnColorLot { get; set; }
        public double QuantityOfSkeins { get; set; }
        public DateTime DateUpdated { get; set; } = DateTime.Now;
    }
}
