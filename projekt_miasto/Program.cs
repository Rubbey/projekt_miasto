using projekt_miasto.Motoryzacja;
using projekt_miasto.Motoryzacja.Samochody.ModelePojazdow;
using projekt_miasto.Motoryzacja.Silniki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba Ja = Osoba.StworzOsobe(); 
            Ja.KupPojazd(new BMWX5());
            Ja.Samochody.ElementAt(0).ZbiornikPaliwa.Dotankuj();
            Ja.Samochody.ElementAt(0).JedziemyWSinaDal();

            Console.ReadLine();
        }
    }
}
