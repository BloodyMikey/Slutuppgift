using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Slutuppgift
{
    class Meny
    {
        //denna klass gör så att man kan använda sig av piltangeterna
        private int ValdVal;
        private string[] Val;
        private string Info;
        public Meny(string info, string[] val)
        {
            Info = info;
            Val = val;
            ValdVal = 0;
        }

        public void VisaVal()
        {
            WriteLine(Info);
            for (int i = 0; i < Val.Length; i++)
            {
                string NuvarandeVal = Val[i];
                string VisaPil;

                if (i == ValdVal)
                {
                    VisaPil = $"-->  {NuvarandeVal}  <--";
                }
                else
                {
                    VisaPil = $"     {NuvarandeVal}  ";
                }
                WriteLine(VisaPil);
            }
        }
        public int Kör()
        {
            ConsoleKey KnappTryck;
            do
            {
                Clear();
                VisaVal();

                ConsoleKeyInfo knappInfo = ReadKey(true);
                KnappTryck = knappInfo.Key;
                //uppdaterar menyn baseat på knapp man trycker.
                if (KnappTryck == ConsoleKey.W || KnappTryck == ConsoleKey.UpArrow)
                {
                    ValdVal--;
                    if (ValdVal == -1)
                    {
                        ValdVal = Val.Length - 1;
                    }
                }
                else if (KnappTryck == ConsoleKey.DownArrow || KnappTryck == ConsoleKey.S)
                {
                    ValdVal++;
                    if (ValdVal == Val.Length)
                    {
                        ValdVal = 0;
                    }
                }

            } while (KnappTryck != ConsoleKey.Enter);

            return ValdVal;
        }
    }
}
