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

            
            Menu.StartMenu();

            //Zwierzyniec.Instancja().DodajZwierzatko(new Zwierzaki.RasyPsow.Jamnik("Zenon", 10));
            //Zwierzyniec.Instancja().DodajZwierzatko(new Zwierzaki.RasyKotow.Syberyjski("Mietek", 90));
            //Zwierzyniec.Instancja().DodajZwierzatko(new Zwierzaki.RasyPsow.York("Fifi", 1));


            
            //osoba.AdoptujZwierza(Zwierzyniec.Instancja().PobierzZwierzatko(0));
            //osoba.WyswietlInformacje();

            //Zwierzyniec.Instancja().WyswietlInformacje();

            //test1

            //Osoba Ja = Osoba.StworzOsobe(); 
            //Ja.KupPojazd(new BMWX5());
            //Ja.Samochody.ElementAt(0).ZbiornikPaliwa.Dotankuj();
            //Ja.Samochody.ElementAt(0).JedziemyWSinaDal();

            Console.ReadLine();
        }
    }
}
