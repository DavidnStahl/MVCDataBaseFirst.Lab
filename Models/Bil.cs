using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDataBaseCodeFirst.LAB.Models
{
    public class Bil
    {
      

        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

    }

}
