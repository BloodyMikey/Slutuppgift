using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Slutuppgift.Menyer
{
    class Intro : Maskinen
    {
        public Intro(Maskin maskin) : base(maskin)
        {
        }
        public override void Kör()
        {
            //Huvudmenyn
            string info =
@" ____________________________________________
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
 | _______________________________________ |

Välkommen Gör gärna något val med pil upp eller ned. välj med Enter
";
            string[] val = {"Köp Godis","Information om Maskinen","Godis Information","Lägg till Godis i Maskinen","Stäng av maskinen"};
            Meny meny = new Meny(info, val);
            int valdVal = meny.Kör();
            switch (valdVal)
            {
                case 0:
                    MinMaskin.MinGodis.Kör();
                    break;
                case 1:
                    MinMaskin.MinInformation.Kör();
                    break;
                case 2:
                    MinMaskin.MinGodisInfo.Kör();
                    break;
                case 3:
                    MinMaskin.MinAddGodis.Kör();
                    break;
                case 4:
                    MinMaskin.MinAvsluta.Kör();
                    break;
            }
        }
    }
}
