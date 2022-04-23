using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_Interfeszek
{
    class MobilTelefon : IEladhato
    {
        public bool Garancia { get; }
        public string Tipus { get; }

        private int ar;

        public int Ar
        {
            get
            {
                return ar;
            }
        }

        public MobilTelefon(string tipus, bool garancia)
        {
            this.Tipus = tipus;
            this.Garancia = garancia;
            ar = garancia ? 100000 : 50000;
        }

        public void LeAkcioz()
        {
            ar = (int)(ar * 0.75);
        }

    }
}
