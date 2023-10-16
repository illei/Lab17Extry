using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17Extry.ShopResources
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stoc { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Label Label { get; set; }
        public override string ToString()
        {
            return $"Name of Product:{Name}, Stoc:{Stoc} Labele:{Label} ";
        }
    }
}
