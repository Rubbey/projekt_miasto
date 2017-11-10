using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Zwierzyniec : IInformacje
    {
        private static Zwierzyniec o_instancja;
        //private List<Zwierzatko> o_listaZwierzatek;

        //tutaj powinny znaleźć sie odpowiedni konstruktor

        //public static Zwierzyniec Instancja() {...}
        //statyczna funkcja, ktora powinna w odpowiedni sposob (jeśli to wymagane) zainicjować instancję klasy Zwierzyniec/lub zwrócić już zainicjowaną

        //public Zwierzatko DodajZwierzatko(Zwierzatko o_zwierzatko) {...}
        //metoda dodaje zwierzaka przekazanego jako argument

        //public Zwierzatko PobierzZwierzatko(int i_indeksZwierzatka) {...}
        //pobieramy zwierzaka z listy - jednoczesnie go z niej usuwajac - metoda powinna być "odporna" na błędy

        public void WyswietlInformacje()
        {
        //    Console.WriteLine("Dostepne zwierzaki:\n Zwierzak: {0}\t Nr: {1}");            
        }
        //ta metoda wyświetli listę dostępnych zwierzaków z informacją o indeksie, pod którym zwierzak występuje
    }
}
