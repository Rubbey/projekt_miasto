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
            /*
            Miasto miasto = new Miasto();
            miasto.uzupelnijMiasto();
            miasto.wyswietlDaneOsob();            
            Console.ReadKey();
            */

           

            List<IInformacje> ListaInformacji = new List<IInformacje>();

            ListaInformacji.Add(new Osoba("Jacek", "Kuźmicz"));
            ListaInformacji.Add(new Adres("", "", "", 5));

            for (int i = 0; i < ListaInformacji.Count; ++i)
                ListaInformacji[i].WyswietlInformacje();
                        

            Console.ReadKey();

        }
    }
}
