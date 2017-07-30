using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Freezer.Data
{
    class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; }

        public DateTime? ManufactureDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        //public string Location { get; set; }
        public string Type { get; set; }
        //public string Description { get; set; }
    }
}
