using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutuppgift.Menyer
{
    class Information : Maskinen
    {
        //information om maskinen
        public Information(Maskin maskin) : base(maskin)
        {
        }
        public override void Kör()
        {
            string info =
@"Allt godis i denna anläggning är EU-markerat.
*******************************************************************************************************

Allt godis kommer bara från certifierade fabriker.
Maskinen är av den senaste teknologin från 2022 att det går inte att hacka maskinen för att få
gratis godis.

Maskinen plockar godiset åt dig så att man kan inte ta mer än vad man väljer att betala för.
I praktiken innebär detta att kunden kan välja sitt godis digitalt för att sedan få en utskriven lapp i 
handen. Detta elminer sätten att stjäla ur en maskin.

Dessutom så blir det ingen smittorisk utöver att det är ingen mennisko kontakt medans maskinen anväds av 
en normal användare.


********************************************************************************************************



Medverkande personal på anläggningen:

Mikey Täglund
Ciccan Björklund
Henke Jehren


Behöver du hjälp eller mer information? Gå till www.cortex.nu";
            string[] val = {"Återgå till menyn","Avsluta"};
            Meny meny = new Meny(info, val);
            int valdVal = meny.Kör();
            switch (valdVal)
            {
                case 0:
                    MinMaskin.MinIntro.Kör();
                    return;
                case 1:
                    MinMaskin.MinAvsluta.Kör();
                    break;
            }
        
        }
    }
}
