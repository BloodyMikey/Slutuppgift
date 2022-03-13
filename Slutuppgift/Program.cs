using System;
using System.Collections.Generic;
using static System.Console;

namespace Slutuppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CursorVisible = false;
            Title = "Cortex GodisAutomat.";
            try
            {
                //Gör så att accsi art ser bra ut
                WindowHeight = 130;
                WindowWidth = 40;
            }
            catch
            {
                //error om window size blir fel
                Console.WriteLine("Kunde inte ställa in storleken på rutan.\nDu kan forsätta men kanske kommer se lite konstigt ut.");       
            }
            Console.WriteLine(@"
Inbrotssäkra GodisMaskinen
Cortexcorp 2022
Byggd av CortexCorp





2022 Copyrighted all rights reserved");
            //styr alla menyer
            Knapp.ValfriForts();
            Maskin minMaskin = new Maskin();
            minMaskin.Start();
        }
    }
}
