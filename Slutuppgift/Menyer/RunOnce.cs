using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutuppgift.Menyer
{
    internal class RunOnce : Maskinen
    {
        // som sagt körs en gång för att lägga in förinstälda godiset i minnet.
        public RunOnce(Maskin maskin) : base(maskin)
        {
        }
        public override void Kör()
        {
            MinMaskin.MinGodisManager.FärdigtGodis();
            MinMaskin.MinIntro.Kör();
        }
    }
}
