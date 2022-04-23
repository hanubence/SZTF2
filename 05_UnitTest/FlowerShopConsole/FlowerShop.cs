using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopConsole
{
    public class FlowerShop
    {
        private Flower[] items;

        public Flower[] Items
        {
            get
            {
                return items;
            }
        }

        public FlowerShop()
        {
            items = new Flower[0];
        }

        public void AddFlower(Flower flower)
        {
            if (flower.Name.Length < 2)
            {
                throw new ArgumentException("Nem elég hosszú a virág neve!");
            }


            Flower[] newItems = new Flower[items.Length + 1];
            for (int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }
            newItems[newItems.Length - 1] = flower;
            items = newItems;
        }

        public Flower MostExpensiveFlower()
        {
            int maxindex = 0;
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i].Price > items[maxindex].Price)
                {
                    maxindex = i;
                }
            }
            return items[maxindex];
        }

        public Flower[] Filter(string flowerName)
        {
            int count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Name.ToUpper().Contains(flowerName.ToUpper()))
                {
                    count++;
                }
            }
            Flower[] filteredFlowers = new Flower[count];
            count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Name.ToUpper().Contains(flowerName.ToUpper()))
                {
                    filteredFlowers[count++] = items[i];
                }
            }
            return filteredFlowers;
        }


    }

}
