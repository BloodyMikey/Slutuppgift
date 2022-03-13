using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutuppgift
{
    public class GodisManager
    {
        //denna klass gör så man kan styra godiset
        private List<Godis> godisLista = new List<Godis>();
        private List<Godis> varukorg = new List<Godis>();

        public void FärdigtGodis()
        {
            //förinställt godis
            godisLista.Add(new Godis() { GodisNamn = "Twix", GodisTyp = "Choklad", Pris = 7.90M });
            godisLista.Add(new Godis() { GodisNamn = "Mars", GodisTyp = "Choklad", Pris = 6.90M });
            godisLista.Add(new Godis() { GodisNamn = "Nutella", GodisTyp = "Choklad/Haselnöt", Pris = 48.50M });
            godisLista.Add(new Godis() { GodisNamn = "Chokladkaka Daim", GodisTyp = "Choklad", Pris = 15.00M });
            godisLista.Add(new Godis() { GodisNamn = "Chokladkaka Big Taste", GodisTyp = "Choklad", Pris = 34.50M });
            godisLista.Add(new Godis() { GodisNamn = "Plopp", GodisTyp = "Choklad", Pris = 23.50M });
            godisLista.Add(new Godis() { GodisNamn = "Polly", GodisTyp = "Choklad", Pris = 25.90M });
            godisLista.Add(new Godis() { GodisNamn = "Geisha", GodisTyp = "Choklad", Pris = 19.90M });
            godisLista.Add(new Godis() { GodisNamn = "S-märke Supersalta", GodisTyp = "Gelatin", Pris = 7.90M });
            godisLista.Add(new Godis() { GodisNamn = "Bilar", GodisTyp = "Mjuk", Pris = 15.90M });
            godisLista.Add(new Godis() { GodisNamn = "Nappar Sura", GodisTyp = "Gelatin", Pris = 8.90M });
            godisLista.Add(new Godis() { GodisNamn = "Dumle ", GodisTyp = "Choklad", Pris = 25.90M });
        }
        public string SkapaGodis(string godisnamn)
        {
            //skapa godis i maskinen
            if (godisnamn == "" || godisnamn == null)
            {
                return "Inget godis tillagd var god ge ett godisnamn";

            }

            Godis nygodis = new Godis()
            {
                GodisNamn = godisnamn
            };

            Console.WriteLine("Skriv GodisTyp:");
            var typ = Console.ReadLine();
            nygodis.GodisTyp = typ != "" ? typ : "Okänd Godistyp";

            Console.WriteLine("Skriv Priset:");
            decimal pris;
            nygodis.Pris = decimal.TryParse(Console.ReadLine(), out pris) ? pris : 1.0M;


            godisLista.Add(nygodis);

            return "Employee Created Successfully";

        }

        public void KöpGodis()
        {
            //lägger godis i varukorgen
            Console.WriteLine("Välj ett en godis du vill lägga i varukorgen");
            int valdGodis = 0;
            if (int.TryParse(Console.ReadLine(), out valdGodis))
            {
                if (valdGodis >= 0 && valdGodis < godisLista.Count)
                {
                    Console.WriteLine("Hur många vill du köpa.");
                    int antal = int.Parse(Console.ReadLine());
                    int i = 0;
                    do
                    {
                        varukorg.Add(godisLista[valdGodis]);
                        i++;
                    } while (i < antal);

                }
                else
                {
                    Console.WriteLine("Måste vara en siffra som är tillgänglig");
                    KöpGodis();
                }

            }
            else
            {
                Console.WriteLine("Fel måste vara en siffra");
                KöpGodis();
            }
            
        }
        public void TömVarukorg()
        {
            //tömmer varukorgen och get dig en totalkostnad 
            Console.WriteLine("Detta är din totala kostand idag: "+ VarukorgAvslut()+" Kr");
        }
        public decimal VarukorgAvslut()
        {
            //Detta beräknar totalkostnaden och tömmer varukorgen
            decimal totalKostnad = 0;
            foreach (var c in varukorg)
            {
                totalKostnad += c.Pris;
            }
            varukorg.Clear();
            return totalKostnad;
        }
        public void SkrivAlltGodis()
        {
            //gör ett id för att kunna lägga i varukorgen.
            for (int i = 0; i < godisLista.Count; i++)
            {
                Console.WriteLine("Godis " +i+" "+godisLista[i]);
            }
        }
        public void SkrivVarukorgen()
        {
            //skriver ut vad du har i varukorgen
            Console.WriteLine("Godisar du lagt i varukorgen.");
            for (int i = 0; i < varukorg.Count; i++)
            {
                Console.WriteLine("Godis " + i + " " + varukorg[i]);
            }
        }
    }
}
