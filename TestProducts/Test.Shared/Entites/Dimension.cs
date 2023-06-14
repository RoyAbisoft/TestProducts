using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Shared.Entites
{
    public class Dimension
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        public Product Product { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        public decimal Longitude { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        public decimal Latitude { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        public decimal Altitude { get; set; }
    }
}
