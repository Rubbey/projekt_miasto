using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Zwierzyniec : IInformacje
    {
        private static Zwierzyniec o_instancja = null;
        private List<Zwierzatko> o_listaZwierzatek;
       
        public Zwierzyniec()
        {
            o_listaZwierzatek = new List<Zwierzatko>();
        }

        public static Zwierzyniec Instancja()
        {
            if (o_instancja == null)
            {
                o_instancja = new Zwierzyniec();
            }
            return o_instancja;
        }
       
        public Zwierzatko DodajZwierzatko(Zwierzatko o_zwierzatko)
        {
            if (o_zwierzatko != null)
            {
                o_listaZwierzatek.Add(o_zwierzatko);
            }            
            return o_zwierzatko;
        }
       
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
        
        public void WyswietlInformacje()
        {
            Console.WriteLine("Dostępne Zwierzaki:");
            foreach (Zwierzatko Zwierz in o_listaZwierzatek)
            {
                Console.WriteLine("Nr: {0}", o_listaZwierzatek.IndexOf(Zwierz));
                Zwierz.WyswietlInformacje();
            }                        
        }        
    }
}
