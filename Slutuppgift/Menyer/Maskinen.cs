using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutuppgift.Menyer
{
    //hela programmet styrs här inne
    class Maskinen
    {
        protected Maskin MinMaskin;
        public Maskinen(Maskin maskin)
        {
            MinMaskin = maskin;
        }
        virtual public void Kör()
        {
            // Styr alla menyer
        }
    }
}
