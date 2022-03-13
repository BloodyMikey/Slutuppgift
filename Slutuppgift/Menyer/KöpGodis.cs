using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutuppgift.Menyer
{
    //menyn för att köpa godis
    class KöpGodis : Maskinen
    {
        public KöpGodis(Maskin maskin) : base(maskin)
        {
        }
        public override void Kör()
        {
            string info = @" ____________________________________________
 |############################################|
|#|                           |##############|
|#|  =====  ..--''`  |~~``|   |##|````````|##|
|#|  |   |  \     |  :    |   |##| Exact  |##|
|#|  |___|   /___ |  | ___|   |##| Change |##|
|#|  /=__\  ./.__\   |/,__\   |##| Only   |##|
|#|  \__//   \__//    \__//   |##|________|##|
|#|===========================|##############|
|#|```````````````````````````|##############|
|#| =.._      +++     //////  |##############|
|#| \/  \     | |     \    \  |#|`````````|##|
|#|  \___\    |_|     /___ /  |#| _______ |##|
|#|  / __\\  /|_|\   // __\   |#| |1|2|3| |##|
|#|  \__//-  \|_//   -\__//   |#| |4|5|6| |##|
|#|===========================|#| |7|8|9| |##|
|#|```````````````````````````|#| ``````` |##|
|#| ..--    ______   .--._.   |#|[=======]|##|
|#| \   \   |    |   |    |   |#|  _   _  |##|
|#|  \___\  : ___:   | ___|   |#| ||| ( ) |##|
|#|  / __\  |/ __\   // __\   |#| |||  `  |##|
|#|  \__//   \__//  /_\__//   |#|  ~      |##|
|#|===========================|#|_________|##|
|#|```````````````````````````|##############|
|############################################|
|#|||||||||||||||||||||||||||||####```````###|
|#||||||||||||PUSH|||||||||||||####\|||||/###|
|############################################|
\\\\\\\\\\\\\\\\\\\\\\///////////////////////
 | _______________________________________ | ";
            string[] val = { "Lägg till godis i varukorgen","Kolla hur mycket du har i varukorgen", "Avsluta köpet", "Återgå till föregånde meny" };
            Meny meny = new Meny(info, val);
            int valdVal = meny.Kör();
            switch (valdVal)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Du valde att köpa godis.\nVäl något av föjande godis baserad på deras siffra. Sedan hur många du vill ha.\n\n");
                    MinMaskin.MinGodisManager.SkrivAlltGodis();
                    MinMaskin.MinGodisManager.KöpGodis();
                    MinMaskin.MinGodisManager.SkrivVarukorgen();
                    Knapp.EnterFortsätt();
                    MinMaskin.MinGodis.Kör();
                    return;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Detta har du lagt i varukorgen.");
                    MinMaskin.MinGodisManager.SkrivVarukorgen();
                    Knapp.EnterFortsätt();
                    MinMaskin.MinGodis.Kör();
                    break;
                case 2:
                    MinMaskin.MinGodisManager.TömVarukorg();
                    Knapp.EnterFortsätt();
                    MinMaskin.MinGodis.Kör();
                    break;
                case 3:
                    MinMaskin.MinIntro.Kör();
                    break;
            }
        }
    }
}
