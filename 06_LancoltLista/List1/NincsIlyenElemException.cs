using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_List
{
    class NincsIlyenElemException : Exception
    {
        public NincsIlyenElemException() 
            : base("Nincs ilyen elem a láncolt listában")
        {

        }
    }
}
