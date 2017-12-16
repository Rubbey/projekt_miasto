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
        private List<Zwierzatko> o_listaZwierzatek;

        //tutaj powinny znaleźć sie odpowiedni konstruktor
        private Zwierzyniec()
        {
            Zwierzyniec o_instancja = new Zwierzyniec();
        }

        public static Zwierzyniec Instancja()
        {
            if (o_instancja == null) new Zwierzyniec();
            return o_instancja;
        }
        //statyczna funkcja, ktora powinna w odpowiedni sposob (jeśli to wymagane) zainicjować instancję klasy Zwierzyniec/lub zwrócić już zainicjowaną

        public Zwierzatko DodajZwierzatko(Zwierzatko o_zwierzatko)
        {
            o_listaZwierzatek.Add(o_zwierzatko);
            return o_zwierzatko;
        }
        //metoda dodaje zwierzaka przekazanego jako argument

        public Zwierzatko PobierzZwierzatko(int i_indeksZwierzatka)
        {
            while (i_indeksZwierzatka < 0 || i_indeksZwierzatka >= o_listaZwierzatek.Count)
            {
                Console.WriteLine("Nie ma Zwierzaka o podanym indeksie!");
                PobierzZwierzatko(Toolbox.inputInteger("Podaj indeks Zwierzaka", 0, o_listaZwierzatek.Count));
            }

            Zwierzatko TempZwierz = o_listaZwierzatek.ElementAt(i_indeksZwierzatka);
            o_listaZwierzatek.RemoveAt(i_indeksZwierzatka);
            return TempZwierz;
        }
        //pobieramy zwierzaka z listy - jednoczesnie go z niej usuwajac - metoda powinna być "odporna" na błędy

        public void WyswietlInformacje()
        {
            Console.WriteLine("Dostępne Zwierzaki:");
            foreach (Zwierzatko Zwierz in o_listaZwierzatek)
            {
                Console.WriteLine("Nr: {0}\t Zwierzak: {1}", o_listaZwierzatek.IndexOf(Zwierz), Zwierz.Imie);
            }                        
        }
        //ta metoda wyświetli listę dostępnych zwierzaków z informacją o indeksie, pod którym zwierzak występuje
    }
}
