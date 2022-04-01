using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BazaZaVajeEntities context = new BazaZaVajeEntities();
            // vsi dobavitelji
            //var x1 = from a in context.DOBAVITELJ
            //         select a;
            var x1 = context.DOBAVITELJ;
            //foreach (var y in x1)
            //{
            //    Console.WriteLine(y.D_IME+" "+y.D_KONTAKT);
            //}
            //            a.izberi P_OPIS, P_ZALOGA, P_MIN, P_CENA iz tabele PRODUKT, kjer je P_DATUM manjši od
            //20.jan. 2004
            DateTime datum = DateTime.Parse("20.1.2004");
            var x2 = from a in context.PRODUKT
                     where a.P_DATUM < datum
                     select new { Opis = a.P_OPIS, Zaloga = a.P_ZALOGA, MinZaloga = a.P_ZALOGA, Cena = a.P_CENA };
            //foreach (var y in x2)
            //{
            //    Console.WriteLine(y.Opis+" "+y.Cena);
            //}
            //b.izberi P_OPIS, P_ZALOGA, P_DATUM in današnjidatum + 365 naj se imenuje ZAPADLOST iz
            //  tabele PRODUKT
            DateTime danes = DateTime.Now;
            danes=danes.AddDays(365);
            var x3 = from a in context.PRODUKT
                     select new { Opis = a.P_OPIS, Zaloga = a.P_ZALOGA, MinZaloga = a.P_ZALOGA, 
                         Cena = a.P_CENA,Zapadlost=danes };
            //foreach (var y in x3)
            //{
            //    Console.WriteLine(y.Opis + " " + y.Zapadlost);
            //}
            //c.izberi P_OPIS, P_ZALOGA, P_MIN, P_CENA iz tabele PRODUKT, kjer je P_CENA manjša od 50 in 
            //je P_DATUM večji kot 15.jan. 2004

            //d.izberi vse atribute iz tabele DOBAVITELJ katerih ime se začne s Smith
            var x4 = from a in context.DOBAVITELJ
                     where a.D_KONTAKT.StartsWith("Smith")
                     select a;
            foreach (var y in x4)
            {
                Console.WriteLine(y.D_KONTAKT);
            }
            //e.izberi vse dobavitelje, kjer je zaloga v produktu manjša od dvakratnika minimalne zaloge

            //f.izberi D_KODA od dobaviteljev, ki so nam že dobavili katerega izmed produktov.Vsak
            //dobavitelj naj bo v rešitvi samo enkrat
            var x5 = (from a in context.PRODUKT
                     select a.D_KODA).Distinct();
            foreach (var y in x5)
            {
                Console.WriteLine(y);
            }
            //g.izberi kodo in ime dobavitelja, ki nam še niso ničesar dobavili(njihova koda se ne pojavlja v
            //tabeli PRODUKT)
            Console.WriteLine("Niso dobavili");
            var x6 = context.DOBAVITELJ.Where(e => !x5.Any(p => p == e.D_KODA));
            foreach (var y in x6)
            {
                Console.WriteLine(y.D_KODA);
            }
            //h.izpiši vsoto vseh stanj pri kupcih(KUP_STANJE) (2089, 28)
            var x7 = context.KUPEC.Sum(e => e.KUP_STANJE);
            var x8 = (from a in context.KUPEC
                      select a.KUP_STANJE).Sum();
            Console.WriteLine("prvi rezultat "+x7);
            Console.WriteLine("drugi rezultat "+x8);
            //i.izračunaj celotno vrednost blaga na zalogi(15.084,52€) 
            //j.izpiši število različnih produktov posameznega dobavitelja po posameznem dobavitelju iz
            //tabele produkt(rešitev ima 6 vrstic, če izključimo dobavitelja null)
            Console.ReadLine();
        }
    }
}
