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
        public string Name { get; set; } = null!;

        [Display(Name = "Number")]        
        [Required(ErrorMessage = "The field {0} is required.")]
        public int Number { get; set; }

        [Display(Name = "Arrival Date")]        
        [Required(ErrorMessage = "The field {0} is required.")]
        public DateTime ArrivalDate { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(150, ErrorMessage = "The {0} field must have a maximum of {1} characters.")]
        public string Description { get; set; } = null!;

        public bool Dimension { get; set; }

        [RequiredIf("Dimension", true, ErrorMessage = "The field {0} is required.")]
        public decimal? Product_Width { get; set; }

        [RequiredIf("Dimension", true, ErrorMessage = "The field {0} is required.")]
        public decimal? Product_Length { get; set; }

        [RequiredIf("Dimension", true, ErrorMessage = "The field {0} is required.")]
        public decimal? Product_High { get; set; }
    }
}
