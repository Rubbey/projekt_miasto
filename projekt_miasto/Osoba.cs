using projekt_miasto.Motoryzacja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Osoba : IInformacje
    {
        public enum RodzajPlci 
        {
            MEZCZYZNA   = 0x0001,
            KOBIETA     = 0x0002,
            BRAK_DANYCH = 0x0000
        };

        public string Imie { get;  private set ;}
        public string Nazwisko { get; private set; }
        public RodzajPlci Plec { get; private set; }
        public Adres Adres { get; private set; }

        public List<Pojazd> Samochody = new List<Pojazd>();

        public void KupPojazd(Pojazd pojazd)
        {
            Samochody.Add(pojazd);
        }

        public Pojazd SprzedajPojazd(int i_indeksPojazdu)
        {
            while (i_indeksPojazdu < 0 || i_indeksPojazdu >= Samochody.Count)
            {
                Console.WriteLine("Nie ma Pojazdu o podanym indeksie!");
                SprzedajPojazd(Toolbox.inputInteger("Podaj indeks Pojazdu", 0, Samochody.Count));
            }

            Pojazd TempPojazd = Samochody.ElementAt(i_indeksPojazdu);
            Samochody.RemoveAt(i_indeksPojazdu);
            return TempPojazd;
        }

        public Pojazd PobierzPojazd(int i_indeksPojazdu)
        {
            while (i_indeksPojazdu < 0 || i_indeksPojazdu >= Samochody.Count)
            {
                Console.WriteLine("Nie ma Pojazdu o podanym indeksie!");
                PobierzPojazd(Toolbox.inputInteger("Podaj indeks Pojazdu", 0, Samochody.Count));
            }

            return Samochody.ElementAt(i_indeksPojazdu);            
        }


        public Osoba()
        {

            this.Plec = RodzajPlci.BRAK_DANYCH;
            this.UstawDane(Toolbox.BRAK_DANYCH, Toolbox.BRAK_DANYCH);
            this.Adres = new Adres();
        }

        public Osoba(string imie, string nazwisko) : this()
        {
            this.UstawDane(imie, nazwisko);
        }


        public void UstawDane(string imie, int wiek)
        {
            this.UstawDane(imie, wiek);
        }

        public void UstawDane(string imie, string plec, string adres)
        {
            this.UstawDane(imie, plec, adres);
        }

        public void UstawDane(string imie, string nazwisko)
        {
            if (!string.IsNullOrEmpty(imie))
                this.Imie = imie;

            if (!string.IsNullOrEmpty(nazwisko))
                this.Nazwisko = nazwisko;
        }

       
        public static Osoba StworzOsobe()
        {
            Osoba result = new Osoba();

            Console.WriteLine("=== wprowadz dane nowej osoby ===");

            result.UstawDane(Toolbox.inputString("Podaj imie: ", true),
                            Toolbox.inputString("Podaj nazwisko: ", false));

            result.Adres.UstawDane(Toolbox.inputString("Podaj ulice: ", false),
                                  Toolbox.inputString("Podaj miasto: ", false),
                                  Toolbox.inputPostCode("Podaj kod pocztowy: ", false),
                                  Toolbox.inputInteger("Podaj nr domu: ", 1, int.MaxValue));

            return result;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Imie = {0} Nazwisko = {1}", this.Imie, this.Nazwisko);
            this.Adres.WyswietlInformacje();
        }

    }
}
