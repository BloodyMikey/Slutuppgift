using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Slutuppgift.Menyer
{
    class GodisInfo : Maskinen
    {
        //information om olika godis sorter
        public GodisInfo(Maskin maskin) : base(maskin)
        {
        }
        public override void Kör()
        {
            string info = @"Godis och snacks

Många kalorier men inte så mycket näring. Det är gemensamt för godis,
choklad, glass, bakverk, sylt, marmelad och chips.
Här får du svar på frågor om Vårt godis

Exempel på godissorter";
            string[] val = { "Choklad", "Dragé", "Gelé", "Gelébjörn", "Geléhallon", "Vingummi", "Karameller", "Plkagris", "Klubba", "Knäck", "Kola", "Lakrits", "Saltlakrits", "Mintkyssar", "Skumgodis", "Tuggummi", "Återgå till menyn"};
            Meny meny = new Meny(info, val);
            int valdVal = meny.Kör();
            switch (valdVal)
            {
                case 0:
                    Clear();
                    Console.WriteLine(@"Choklad är ett samlingsnamn för livsmedel baserade på kakaobönan. Bönan
framställs av kakaoträdet Theobroma cacaos frukt. Kakaoträdet har
odlats i Mellanamerika åtminstone sedan 600-talet av mayafolket.
Bönorna tros ha använts i åtminstone 2 500 år. Till Europa togs choklad
första gången 1502 av Christofer Columbus, och Spanien etablerade
tidigt ett monopol på import. Först förtärdes chokladen i form av
chokladdryck, och chokladhus som sålde drycken öppnade på många ställen
i Europa. 1828 upptäckte man hur man kunde framställa pulver av
kakaobönorna, vilket ledde till att den första chokladkakan
tillverkades 1847.

Många typer av choklad innehåller förutom kakao, i form av kakaomassa
eller kakaosmör, även socker. Mörk choklad innehåller i huvudsak
kakaomassa, medan vit choklad består av kakaosmör. Den kan vara
flytande, pasta eller i block, eller användas som en smaksättare i
annan mat.

När mjölk ingår i blandningen kallas den mjölkchoklad. Choklad används
som tilltugg, i bakverk, glass, dryck eller sötsaker, men kan även
användas som krydda i matlagning. Idag används huvudsakligen tre olika
sorters kakaobönor vid tillverkningen av choklad.
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 1:
                    Clear();
                    Console.WriteLine(@"Dragé är en sötsak med ett hölje, vanligen av socker eller choklad;
även själva höljet kallas dragé, och godisbiten sägs vara dragerad.
Tabletter, nötter, mandlar, choklad, karameller eller andra fasta ämnen
(inlägg) får ett hölje av sockerlag eller smält choklad. Dragéägg är
vanligt som påskgodis.

När rörsockret kom till Europa började bland annat Nederländerna att
skapa nya godissorter, exempelvis mandlar och valnötter överdragna med
ett sockerlager. De franska sockeröverdragna mandlarna kallas grosse
dragées (stora dragéer). En variant har blankt överdrag, perlé, och en
har en mattare, lissé. Dragering användes även till läkemedel,
huvudsakligen tabletter, som kapslades in i ett sockerlager för att bli
mer aptitliga
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 2:
                    Clear();
                    Console.WriteLine(@"Gelé (uttal: /ʃe'le) betecknar ett mer eller mindre genomskinligt,
halvfast ämne med dallrande konsistens. Det förekommer dels som
födoämne, dels i många tekniska tillämpningar. I det senare fallet är
benämningen ofta gel
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 3:
                    Clear();
                    Console.WriteLine(@"Gelébjörnar, även kända som godisnallar, gelénallar eller gummibjörnar,
är gelégodis med fruktsmak i form av stiliserade björnar. De finns i
olika färger och består av bland annat socker, gelatin, fruktjuice och
färgämnen.

Gelébjörnar finns även i gelatinfria varianter.
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 4:
                    Clear();
                    Console.WriteLine(@"Geléhallon är en sorts gelégodis (ofta gelatin- eller pektinbaserat)
som är starkt färgat i vanligtvis rött eller rosa. Konfektbitarna
påminner om hallon till formen och är överdragna med socker. Åtminstone
sedan början av 1960-talet har geléhallon kallats för jungfrubröst.

Geléhallon är en traditionell konfekt som kan beläggas i Sverige sedan
åtminstone 1904. Av en annons i Göteborgs Aftonblad från detta år
verkar det dock som att geléhallon redan var allmänt känt. I USA dök
det upp i en annons redan 1859.

Konfekttillverkaren Aroma i Stockholm har tillverkat geléhallon från
1928 och Toms Sverige AB i Habo från 1952 till nedläggningen 2013
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 5:
                    Clear();
                    Console.WriteLine(@"Vingummin är ett fast gelégodis som brukar säljas i blandade färger. De
är ofta tillverkade av gelatin, blandat med sötningsmedel och
färgämnen. Namnet till trots innehåller vingummin inget vin.

Enligt Cadbury Schweppes är röd och svart de vanligaste färgerna. De är
mycket populära i Storbritannien och Irland, men också i andra länder i
samväldet som Nya Zeeland, Sydafrika och Kanada, samt i norra och
mellersta Europa. Kända producenter av vingummi är bland annat
varumärkena Bassett's och Marks & Spencer.
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 6:
                    Clear();
                    Console.WriteLine(@"En karamell (ursprungligen franska, caramel) är en sötsak baserad på
smält socker. Karameller finns i många smaker, och brukar oftast vara
hårda och knapriga. De är inte gjorda för att tugga på utan för att
suga på. De brukar oftast vara inlindade i cellofan. Karameller säljs
även i påsar och som lösviktsgodis.

Hårda karameller började tillverkas efter att sockerpriset sjönk i
början av 1800-talet, i samband med att många nya godissorter kom till.

Socker smälter vid en temperatur strax över 130 grader. När det åter
stelnar blir det hårt och genomskinligt. Egentligen avser karamell
endast produkter där sockret upphettats mera, till 150-200 grader. I
det temperaturområdet inträder den så kallade karamelliseringen. Färg,
smak och konsistens förändras då, och förändringen kvarstår även då
sockret svalnat och stelnat. Sockret blir brunare ju högre temperaturen
är och smaken blir allt beskare och övergår i bränt. Oftast tillsätter
man smakämnen, till exempel kryddor, pepparmintsolja eller fruktaromer.
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 7:
                    Clear();
                    Console.WriteLine(@"En polkagris är en typ av hårt pepparmintgodis bestående av vatten,
socker, pepparmintsolja eller -arom och ättika. Den klassiska
varianten är röd-vit-randiga stänger. Polkagrisar brukar i Sverige
förknippas med den småländska orten Gränna, där de började tillverkas
av Amalia Eriksson under 1800-talet. Polkagrisar hör ofta julen till.
En polkagris är sällan formad som en gris; däremot kan stången ofta ha
en krok i ena änden (för att lättare kunna hängas i en julgran) och
benämns då polkakäpp.
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 8:
                    Clear();
                    Console.WriteLine(@"En godisklubba eller vardagligt klubba (även kallad slickepinne) är
godis fastsatt på en pinne som är avsedd att hålla i medan man äter
godiset.

Godiset består vanligen av karamell, men även choklad, kola eller
skumgodis förekommer. Det finns även klubbor med fyllning. Pinnen är
ofta gjord av lindat papper eller ihålig plast. Även trä förekommer,
men det var vanligare förr. Godisklubbor finns i många olika former,
storlekar, färger och smaker.
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 9:
                    Clear();
                    Console.WriteLine(@"Knäck är en vanlig typ av hemgjort bakelse bestående av lika delar
sirap, socker och grädde som kokas ihop och som ofta smaksätts med
hackad mandel. När smeten har kokats ihop till lagom konsistens, som
kan vara mjuk till mycket hård, beroende på tycke och smak, fördelas
den i veckade små pappersformar där den får stelna. Det har också varit
vanligt att tillsätta till exempel skorpsmulor eller kokosflingor, för
att dryga ut, och bakpulver, för att knäcken skall bli porös. Knäck
görs traditionellt med ljus sirap, men det går även att använda mörk
sirap för en mindre söt och mer påtagligt nötig smak.

Inget julgodis har stått emot alla växlingar så väl som den klassiska
knäcken. Knäck är, möjligen i sällskap med några få andra
konfektsorter, att betrakta som en viktig del av ett svenskt julfirande.

Knäck är känt sedan slutet av 1800-talet.
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 10:
                    Clear();
                    Console.WriteLine(@"Kola, på finlandssvenska tjinuski eller kinuski, är ett slags godis med
seg konsistens. Det kokas på socker och (oftast) någon mejeriprodukt.

Ordet kola kommer av att extrakt av kolanöt ursprungligen tillsattes i
kolakaramellerna eller kolorna (som även senare i tid verkar vara
annorlunda mot dagens kolor genom att innehålla choklad eller kakao).
Tjinuski och kinuski, som också kan syfta på kolakräm eller kolasås,
kommer av ryskans tjanusjki, som betyder kola eller knäck.
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 11:
                    Clear();
                    Console.WriteLine(@"Lakrits (uttal: [la'kri(t)s] eller [laː'kri(t)s]) är en massa som
framställs ur lakritsrot från Glycyrrhiza glabra. Lakritsrot innehåller
glykosiden glycyrrhizin, lakritsens viktigaste ingrediens, och har en
söt smak. Lakrits är ett vanligt smakämne i godis och läkemedel, men
förekommer även i till exempel likör och glass. Produkter med
lakritssmak kan även innehålla anis som ersättare eller smakförstärkare
till lakrits. I godissammanhang kallas lakrits ibland sötlakrits. Detta
för att särskilja smaken från saltlakrits som innehåller det
konstgjorda saltet salmiak. I Europa produceras lakrits främst i
Spanien, Italien och Turkiet.
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 12:
                    Clear();
                    Console.WriteLine(@"Saltlakrits, även kallat salmiakgodis, är godis med lakritssmak som har
tillsatts saltet salmiak (ammoniumklorid) och därför får en salt smak.
Saltlakrits säljs och konsumeras mest i de nordiska länderna, i
Nederländerna och i Baltikum. Skall inte förväxlas med lakritsrot eller
ren lakrits.

Lakritsrot har använts som medicin åtminstone sedan 1600-talet, och
användes då främst mot 'dålig mage'. Även i hostmedicin som
'Quilla-sirap' och som halstabletter används det fortfarande.Bronzol
(en föregångare i smak och utseende till Lakrisal) var en storsäljare
på 1950 - talet.Då kom också salta gubbar, skruvar och grodor, som
fortfarande finns i Sverige, samt den lilla tablettasken med platta,
rombformade tabletter som kort och gott hette Salmiak.Andra tabletter
som överlevt är Salt i sol och något yngre Salta katten.I Finland är
saltlakrits och salmiak populärt.Där finns till och med en förening
som heter Finlands Salmiakförening.Den delade postumt ut ett pris till
dansken Per Fjelsten som uppfann Turkisk peppar vilken togs över av
Fazer 1996.Även som drink, så kallad shot, är salmiak mycket populärt
främst genom Salmiakki Koskenkorva.Nu för tiden finns även snus med
salmiaksmak.

Saltlakrits innehåller ungefär 70 gram salmiak per kilo.Enligt ett
EU - förslag som presenterades våren 2012 skulle den tillåtna maxgränsen
för salmiak i matvaror sänkas till 3 gram per kilo, vilket skulle
innebära ett förbud mot saltlakrits.Livsmedelsföretagen,
godistillverkare och branschorganisationer i Norden har protesterat mot
förslaget och hösten 2012 infördes ett undantag för saltlakritsen.
Saltlakritsen kommer därför att få finnas kvar.
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 13:
                    Clear();
                    Console.WriteLine(@"Mintkyssar eller chokladkyssar är ett slags konfekt som oftast bakas
som julgodis. Mintkyssen smakar mint och har en klick mörk choklad på
toppen
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 14:
                    Clear();
                    Console.WriteLine(@"Skumgodis är en typ av godis som består av en skumliknande massa av
socker, stärkelsesirap och konsistensgivande medel, oftast gelatin och
smakämnen. Skumgodis finns i olika smaksättningar och har ibland
chokladöverdrag som kan innehålla kokosflingor eller vara försett med
strössel.

Exempel på skumgodis är: skumbananer och skumkantareller. Exempel på
skumgodis med chokladöverdrag är kokosprickar. Skumgodis förekommer
också i julversion i form av tomtar, chokladtomtar eller grankottar.
Marshmallows är också en typ av skumgodis, exempelvis godiset
''sockerbitar'' i Sverige.
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 15:
                    Clear();
                    Console.WriteLine(@"Tuggummi (tugg-gummi, engelska chewing gum), är ursprungligen ett
amerikanskt njutningsmedel, som bereddes av chiclegummi (mjölksaften av
Manilkara chicle), socker, pepparmyntsolja och andra aromatiska ämnen.
Tuggummi framställdes i stor fabriksmässig skala i Nordamerika kring år
1900. Formmässigt är tuggummin ofta tunna och rektangulära, men är även
vanliga som runda kulor i tuggummiautomater och som glasspinnar.
Tuggummi används även för att tillfälligt ge en bättre andedräkt.
");
                    Knapp.ValfriForts();
                    MinMaskin.MinGodisInfo.Kör();
                    return;
                case 16:
                    MinMaskin.MinIntro.Kör();
                    return;

            }
        }
    }
}
