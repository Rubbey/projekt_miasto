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
            DOMOWE = 0x0001,
            HODOWLANE = 0x0002,
            BRAK_DANYCH = 0x0000
        };

        public string Imie { get; private set; }
        public int Wiek { get; private set; }
        public RodzajZwierzatka Plec { get; private set; }

        public Zwierzatko()     //tutaj powinny znaleźć sie odpowiednie konstruktory
        {
            this.Plec = RodzajZwierzatka.BRAK_DANYCH;
            this.UstawDane(Toolbox.BRAK_DANYCH, 0);
        }

        public Zwierzatko(string imie, int wiek) : this()
        {
            this.UstawDane(imie, wiek);
           
        }

                                                         
        public void UstawDane(string imie, int wiek)       //metoda UstawDane powinna być przeciążona dla kilku wariantów argumentów
        {                                                 //dodatkowo powinna zawierać sprawdzenia poprawności wprowadzanych danych

            if (!string.IsNullOrEmpty(imie)) this.Imie = imie;              //tutaj sprawdzacz czy jako pierwszy argument jest podany ciąg znaków, jesli jest to przypisuje to jako imie
            else this.Imie = Toolbox.inputString("Podaj imie: ", false);    //jesli nie, wywoluje metode inputString z Toolboxa i jej wynik prypisuje jako imie

            if (wiek >= 0 && wiek <= 99) this.Wiek = wiek;                  //a tutaj sprawdzasz czy drugi argument jest w przedziale <0,99>, jesli tak przypisuje to jako wiek
            else this.Wiek = Toolbox.inputInteger("Podaj wiek: ", 0, 99);   //jeśli nie, wywoluje metode inputInteger i jej wynik przypisuje jako wiek
        }
        
        /*
            metody abstrakcyjne nie posiadają w klasie , w której zostały zdefioniowane swoich deklaracji - jedynie nagłówek
            każda klasa, która będzie dziedziczyła z klasy bazowej musi posiadać implementacje tych metod
        */

        public abstract string GatunekZwierzatka();
        public abstract string RasaZwierzaka();
        public abstract void NiechZwierzCosPowie();

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine("Imię: {0}\nWiek: {1}\nRodzaj: {3}\nGatunek: {4}\nRasa: {5}", this.Imie, this.Wiek, this.Plec);
        }
        //ta metoda moze wyswietlic podstawowe informacje o zwierzaku
    }
}
