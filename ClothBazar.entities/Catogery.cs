using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.entities
{
    public class Catogery : Base
    {
        public string ImageUrl { get; set; }
        public List<Product> Products { get; set; }
    }
}
