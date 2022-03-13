using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutuppgift.Menyer
{
    internal class AddGodis : Maskinen
    {
        // lägga till godis i minnet.
        public AddGodis(Maskin maskin) : base(maskin)
        {
        }
        public override void Kör()
        {
            Console.CursorVisible = true;
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
            string[] val = { "Lägg till mer godis i Maskinen", "Kolla Vilka godisar som finns i manskinen", "Återgå till föregånde meny" };
            Meny meny = new Meny(info, val);
            int valdVal = meny.Kör();
            switch (valdVal)
            {
                case 0:
                    Console.WriteLine("Skriv Godisnamn:");
                    var godisnamn = Console.ReadLine();
                    Console.WriteLine(MinMaskin.MinGodisManager.SkapaGodis(godisnamn));
                    MinMaskin.MinAddGodis.Kör();
                    break;
                case 1:
                    MinMaskin.MinGodisManager.SkrivAlltGodis();
                    Knapp.EnterFortsätt();
                    MinMaskin.MinAddGodis.Kör();
                    break;
                case 2:
                    MinMaskin.MinIntro.Kör();
                    break;

            }
        }
    }
}
