using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{

    abstract class Zwierzatko : IInformacje
    {
        public enum RodzajZwierzatka
        {
            DOMOWE = 1,
            HODOWLANE = 2,
            BRAK_DANYCH = 0
        };

        public string Imie { get; private set; }
        public int Wiek { get; private set; }
        public RodzajZwierzatka Rodzaj { get; protected set; }              

        public Zwierzatko()
        {
            this.Rodzaj = RodzajZwierzatka.BRAK_DANYCH;
            this.UstawDane(Toolbox.BRAK_DANYCH, 0);
        }

        public Zwierzatko(string imie, int wiek) : this()
        {
            this.UstawDane(imie, wiek);
        }

        public void UstawDane()
        {
            this.Imie = Toolbox.inputString("Podaj imie: ", false);
            this.Wiek = Toolbox.inputInteger("Podaj wiek: ", 0, 99);
        }

        public void UstawDane(string imie)
        {
            if (!string.IsNullOrEmpty(imie)) this.Imie = imie;
            else this.Imie = "Ten zwierzk nie posiada jeszcze imienia! :(";
        }

        public void UstawDane(string imie, int wiek)         
        {
            if (!string.IsNullOrEmpty(imie)) this.Imie = imie;
            else this.Imie = "Ten zwierzk nie posiada jeszcze imienia! :(";

            if (wiek >= 0 && wiek <= 99) this.Wiek = wiek;
            else throw new ArgumentOutOfRangeException();
        }        

        public abstract string GatunekZwierzatka();
        public abstract string RasaZwierzaka();
        public abstract void NiechZwierzCosPowie();

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine("Imię: {0}\tWiek: {1}\nGatunek: {2}\tRasa: {3}\nRodzaj: {4}\n--------------------------", this.Imie, this.Wiek, this.GatunekZwierzatka(), this.RasaZwierzaka(), this.Rodzaj);
        }
        
    }
}
