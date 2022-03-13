using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutuppgift.Menyer
{
    class Avsluta : Maskinen
    {
        //avslutar programmet med en kod som synns i ascii art
        public Avsluta(Maskin maskin) : base(maskin)
        {
        }
        public override void Kör()
        {
            while (true)
            {
                try
                {

                    Console.Clear();
                    Console.WriteLine(@" ____________________________________________
|############################################|
|#|                           |##############|
|#|  =====  ..--''`  |~~``|   |##|````````|##|
|#|  |   |  \     |  :    |   |##| Exit   |##|
|#|  |___|   /___ |  | ___|   |##| Code   |##|
|#|  /=__\  ./.__\   |/,__\   |##| 1234   |##|
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
 |________________________________|CR98|___|

Vad god skriv in koden för att stänga av maskinen.
");
                    int x = Convert.ToInt32(Console.ReadLine());

                    //Denna kod är för att stänga av maskinen."
                    if (x == 1234)
                    {
                        Console.WriteLine("Korrekt inmatning!");
                        Knapp.Avsluta();
                    }

                    else
                    {
                        Console.WriteLine("\nFelaktig inmatning...\n\nTryck På Enter för att återgå till huvudmeny");
                        Console.ReadLine();
                        MinMaskin.MinIntro.Kör();
                    }
                }
                catch
                {
                    Console.WriteLine("\nFelaktig inmatning...\n\nTryck På Enter för att återgå till huvudmeny");
                    Console.ReadLine();
                    MinMaskin.MinIntro.Kör();
                    break;
                }
            }
        }
    }
}
