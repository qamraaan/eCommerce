using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.entities
{
    public class Product : Base
    {
        public Catogery catogery { get; set; }
        public decimal Price { get; set; }
    }
}
