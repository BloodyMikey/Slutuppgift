using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Slutuppgift.Menyer;

namespace Slutuppgift
{
    class Maskin
    {
        //Körs en gång för att starta upp visa saker.
        public RunOnce MinEnGång;
        //Start menyn
        public Intro MinIntro;
        //info menyn
        public Information MinInformation;
        //avsluta menyn
        public Avsluta MinAvsluta;
        //Godis Info / hälsan
        public GodisInfo MinGodisInfo;
        //köp godis menyn
        public KöpGodis MinGodis;
        //lägger till godis
        public AddGodis MinAddGodis;
        //Styr hur man köper och lägger in godis
        public GodisManager MinGodisManager;
        public Maskin()
        {
            MinEnGång = new RunOnce(this);
            MinGodisManager = new GodisManager();
            MinIntro = new Intro(this);
            MinInformation = new Information(this);
            MinAvsluta = new Avsluta(this);
            MinGodis = new KöpGodis(this);
            MinAddGodis = new AddGodis(this);
            MinGodisInfo = new GodisInfo(this);

        }
        //startar allting i en viss ordning
        public void Start()
        {

            MinEnGång.Kör();
        }
    }
}
