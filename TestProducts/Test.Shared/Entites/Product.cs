using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Test.Shared.Helpers;

namespace Test.Shared.Entites
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [MaxLength(50, ErrorMessage = "The {0} field must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "The field {0} is required.")]
        public string Name { get; set; }

        [Display(Name = "Number")]        
        [Required(ErrorMessage = "The field {0} is required.")]
        public int Number { get; set; }

        [Display(Name = "Date Arrival")]        
        [Required(ErrorMessage = "The field {0} is required.")]
        public DateTime DateArrival { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public bool Dimension { get; set; }

        [RequiredIf("Dimension", true, ErrorMessage = "The field {0} is required.")]
        public decimal? Width_Product { get; set; }

        [RequiredIf("Dimension", true, ErrorMessage = "The field {0} is required.")]
        public decimal? Length_Product { get; set; }

        [RequiredIf("Dimension", true, ErrorMessage = "The field {0} is required.")]
        public decimal? High_Product { get; set; }
    }
}
