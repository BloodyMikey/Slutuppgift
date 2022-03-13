using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//Förinstälda knappval för att underlätta i koden
namespace Slutuppgift
{
    internal class Knapp
    {
        public static void EnterFortsätt()
        {
            void WaitForKey(ConsoleKey key)
            {
                while (ReadKey(true).Key != key)
                { }
            }
            WriteLine("Tryck Enter för att Fortsätta");
            WaitForKey(ConsoleKey.Enter);

        }
        public static void ValfriForts()
        {
            WriteLine("Tryck Valfri knapp för att Fortsätta");
            ReadKey();
        }
        public static void Avsluta()
        {
            void WaitForKey(ConsoleKey key)
            {
                while (ReadKey(true).Key != key)
                { }
            }
            WriteLine("Tryck ESC för att Stänga av");
            WaitForKey(ConsoleKey.Escape);
            Environment.Exit(0);
        }
    }
}
