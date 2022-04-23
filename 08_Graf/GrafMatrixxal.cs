using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_Graf
{
    class GrafMatrixxal<T> : Graf<T>
    {
        public GrafMatrixxal(int csucsokSzama)
        {

        }
        public override void UjCsucs(T tartalom)
        {
            throw new NotImplementedException();
        }

        public override void UjEl(T honnan, T hova, double suly = 1, bool iranyitott = false)
        {
            throw new NotImplementedException();
        }

        protected override List<El> Szomszedok(T csucs)
        {
            throw new NotImplementedException();
        }
    }
}
