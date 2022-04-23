using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_Kivetel
{
    class StorageFullException : Exception
    {
        public int CounterPosition { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public StorageFullException(int counterPosition, int row, int column)
            : base("Storage is full")
        {
            this.CounterPosition = counterPosition;
            this.Row = row;
            this.Column = column;
        }



    }
}
