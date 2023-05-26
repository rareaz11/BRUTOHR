using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUTO
{
    internal class Program
    {// Aplikacija radi na osnovu unosa bruto iznosa --
        //izracunava doprinose(moI moII)
        //dohodak, odbitak, porez Osnovica,prirez ako ga ima , porez, zdravstveno
        
        static void Main(string[] args)
        {
            Postavi();
            
      
        }

        public static void Postavi()
        {

            int godine;
            string prvoZaposlenje;
        p:

            int odabir;
            Console.WriteLine("DOBRODOSLI U IZBORNIK \n BRUTO--NETO i ostala davanja");
            Console.WriteLine("1.Izracun preko Bruto");
            Console.WriteLine("2.Izracun preko neto");// ovo jos nije napravljeno
            try
            {
                odabir = Convert.ToInt32(Console.ReadLine());




                switch (odabir)
                {
                    case 1:

                        decimal x;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ovjde unosite BRUTO PLACU NE NETO!!!!!!!!!!!!!");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.WriteLine("upiste bruto placu: ");

                        //x je bruto
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("upiste koliko godina imate: ");
                        godine = Convert.ToInt32(Console.ReadLine());
                    q:
                        Console.WriteLine("ovo vam je prvo zaposljenje(Odgovroite iskljucivo sa odgovorima da i ne) ");
                        prvoZaposlenje = Console.ReadLine();
                        if (prvoZaposlenje == "da" || prvoZaposlenje == "ne")
                        {
                            Console.WriteLine("ODGOVOR PRIHVACEN");
                        }
                        else
                        {
                            Console.WriteLine("UPISITE ISKLJICIVO DA ILI NE NA PITANJE DA LI VAM JE OVO PRVO ZAPOSLJENJE");
                            goto q;
                        }
                        decimal y = x * 0.15m;//prvi stup doprinos
                        decimal z = x * 0.05m;//Mo 2 stup
                                              //Doprnosi su y+z
                        decimal doprinosi = y + z;
                        decimal dohodak = x - doprinosi;
                        //osobni odbitak je uvijek jednak 4000 kn 
                        decimal odbitakOsobni = 4000m;
                        int djeca;
                    u:
                        Console.WriteLine("unesite broj koliko imate djece");
                        djeca = Convert.ToInt32(Console.ReadLine());
                        decimal brDjece;
                        switch (djeca)
                        {
                            case 0:

                                Console.WriteLine("Odabrali ste da nemea te djece: ");
                                brDjece = 0m;



                                break;
                            case 1:

                                Console.WriteLine("Odabrali ste da imate 1 dijete ");

                                brDjece = 1750m;



                                break;
                            case 2:

                                Console.WriteLine("Odabrali ste da imate 2 te djece: ");
                                brDjece = 2500m + 1750m;



                                break;

                            case 3:

                                Console.WriteLine("Odabrali ste da imate 3 djece: ");
                                brDjece = 3500m + 2500m + 1750m;



                                break;
                            case 4:

                                Console.WriteLine("Odabrali ste da imate 4 te djece: ");
                                brDjece = 4750m + 3500m + 2500m + 1750m;



                                break;
                            case 5:

                                Console.WriteLine("Odabrali ste da imate 5 djece: ");
                                brDjece = 6250m + 4750m + 3500m + 2500m + 1750m;



                                break;
                            case 6:

                                Console.WriteLine("Odabrali ste da imate 6 te djece: ");
                                brDjece = 8000m + 6250m + 4750m + 3500m + 2500m + 1750m;



                                break;
                            case 7:

                                Console.WriteLine("Odabrali ste da imate 7 te djece: ");
                                brDjece = 10000m + 8000m + 6250m + 4750m + 3500m + 2500m + 1750m;




                                break;
                            default:
                                Console.WriteLine("pogresan unos\npokusajte opet  ");
                                goto u;


                        }


                        decimal poreznaOsn = dohodak - odbitakOsobni - brDjece;
                        decimal porez;
                        if (poreznaOsn <= 30000)

                        {
                            porez = poreznaOsn * 0.20m;
                        }
                        else
                        {
                            porez = poreznaOsn * 0.30m;
                        }



                        decimal prirez = 0;
                        Console.WriteLine("odaberite gdje zivite radi prireza:");
                        Console.WriteLine("1.selo");
                        Console.WriteLine("2.Grad");
                        Console.WriteLine("3.Zagreb");
                        int prirezOdaberi;
                        prirezOdaberi = Convert.ToInt32(Console.ReadLine());

                        switch (prirezOdaberi)

                        {
                            case 1:
                                prirez = porez * 0.12m;

                                break;

                            case 2:
                                prirez = porez * 0.15m;

                                break;
                            case 3:
                                prirez = porez * 0.18m;

                                break;

                        }
                        if (poreznaOsn < 0)
                        {
                            prirez = 0;
                            porez = 0;
                        }


                        prirez = porez * 0.15m;
                        decimal zdravstevno;


                        if (godine < 25)
                        {
                            prirez = 0;
                        }
                        if (prvoZaposlenje == "da") 
                        {
                            zdravstevno = 0;
                        }
                        else 
                        {
                            zdravstevno = x * 0.165m;
                        }
                        decimal netto = dohodak - porez - prirez;
                        
                        decimal ukupno = x + zdravstevno;
                        Console.WriteLine("Bruto je : " + x);
                        Console.WriteLine("DOPRINOSI SU " + doprinosi);
                        Console.WriteLine("Dohodak je : " + dohodak);
                        Console.WriteLine("osobni odbitak je : " + odbitakOsobni);
                        Console.WriteLine("za djecu odbitak je : " + brDjece);
                        Console.WriteLine("porezna Osnovica je : " + poreznaOsn);
                        Console.WriteLine("porez je : " + porez);
                        Console.WriteLine("prirez;  " + prirez);
                        Console.WriteLine("neto je : " + netto);
                        Console.WriteLine("davanje za zdravstvenoo:" + zdravstevno);
                        Console.WriteLine("ukupno : " + ukupno);
                        Console.ReadLine();




                        break;

                    case 2:
                        // za sda nije ispunjeno
                        Console.WriteLine("unesena pogresna vrijdnost");

                        goto p;

                    default: Console.WriteLine("unesena pogresna vrijdnost");
                        goto p;



                }





            }
            catch (Exception) 
            {
                string mes ="Pogreska\nunesite broj a ne tekst";
                
                Console.WriteLine( mes);
                Console.ReadLine();
                goto p;
            }
           }
    }
}
