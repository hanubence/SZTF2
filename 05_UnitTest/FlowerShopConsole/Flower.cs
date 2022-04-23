using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopConsole
{
    public class Flower
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public bool PotIncluded { get; set; }

        public Flower(string name, int price, bool potincluded)
        {
            this.Name = name;
            this.Price = price;
            this.PotIncluded = potincluded;
        }

        public override bool Equals(object obj)
        {
            return this.GetHashCode() == (obj as Flower).GetHashCode();
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() 
                * Price.GetHashCode() * PotIncluded.GetHashCode();
        }
    }
}
