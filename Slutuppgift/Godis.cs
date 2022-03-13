using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutuppgift
{
    public class Godis
    {
        //stuktur på hur godis skall bete sig och eller kosta.
        public string GodisNamn { get; set; }
        public string GodisTyp { get; set; }
        public decimal Pris { get; set; }

        public Godis()
        {
            GodisNamn = "";
            GodisTyp = "";
            Pris = 0.00M;
        }
        public Godis(string a,string b, decimal c)
        {
            GodisNamn = a;
            GodisTyp=b;
            Pris = c;
        }

        public override string ToString()
        {
            return $"{GodisNamn} Det kostar: {Pris} Kr";
        }

    }
}
