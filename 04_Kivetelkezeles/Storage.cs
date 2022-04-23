using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_Kivetel
{
    class Storage
    {
        string[,] data;
        int counter;

        static Random r;

        static Storage()
        {
            r = new Random();
        }

        public Storage(int rows, int columns)
        {
            data = new string[rows, columns];
        }

        public void AddItem(string item)
        {
            if (counter < data.Length)
            {
                int i = -1;
                int j = -1;
                do
                {
                    i = r.Next(0, data.GetLength(0));
                    j = r.Next(0, data.GetLength(1));
                } while (data[i, j] != null);
                data[i, j] = item;
                counter++;
            }
            else
            {
                throw new StorageFullException(counter, data.GetLength(0), data.GetLength(1));
            }
            
        }

        public string GetItem(int i, int j)
        {
            string item = data[i, j];
            data[i, j] = null;
            counter--;
            return item;
        }
    }
}
