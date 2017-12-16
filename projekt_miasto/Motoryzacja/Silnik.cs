using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja
{
    abstract class Silnik : IInformacje
    {
        public long LiczbaPrzejechanychKilometrow { get; private set; }
        public double PojemnoscSilnika { get; private set; }
        public double ZuzyciePaliwa { get; private set; }

        //tutaj jak zwykle powinny znaleźć się odpowiednie konstruktory - silnik musi mieć pojemność i jakąś startową wartość kilometrów
        public Silnik()
        {
            LiczbaPrzejechanychKilometrow = Toolbox.inputInteger("Podaj aktualny przebieg silnika w km: ", 0, int.MaxValue);
            PojemnoscSilnika = Toolbox.inputDouble("Podaj pojemnosc silnika: ", 0.7f, 25.0f);
            ZuzyciePaliwa = (PojemnoscSilnika * 2.5f)/100;
        }

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine("Pojemnosc: {0}\t Przebieg: {1}\t Zuzycie paliwa: {2}",this.PojemnoscSilnika, this.LiczbaPrzejechanychKilometrow, this.ZuzyciePaliwa);
        }
        //ta metoda wyświetli informację o instancji silnika

        public virtual long JedziemyWSinaDal(long liczbaKilometrow, ZbiornikPaliwa zbiornikPaliwa)
        {
            /*  
            metoda powinna pozwolić na przejechanie liczby kilometrów, na która pozwala ilość paliwa w zbiorniku - nie wiecej,
            dodatkowo liczba przejechanych kilometrow powinna byc podbijana
            funkcja jako wartosc powrotna przekazuje liczbe autentycznie przejechanych kilometrow
            do obliczenia zużycia paliwa proszę wykorzystać pole PojemnoscSilnika - oczywiście chodzi tu o jakis prosty wzór - nie chcemy, bawić się w inżynierów mechaników :D
            */
            double liczbaMozliwychDoPrzejechaniaKilometrow = zbiornikPaliwa.IloscPaliwa / ZuzyciePaliwa;
            if (liczbaKilometrow > liczbaMozliwychDoPrzejechaniaKilometrow)
            {
                Console.WriteLine("Nie ma wystarczającej ilości paliwa na przejechanie całego dystansu!\nJadę ile sie da [{}km]! ", (int)liczbaMozliwychDoPrzejechaniaKilometrow);
                this.LiczbaPrzejechanychKilometrow += (long)liczbaMozliwychDoPrzejechaniaKilometrow;
                return (long)liczbaMozliwychDoPrzejechaniaKilometrow; ;
            }
           else
            {
                this.LiczbaPrzejechanychKilometrow += liczbaKilometrow;
                Console.WriteLine("Wruuuuummmm... Przejechalismy {0}km! ", liczbaKilometrow);
                return liczbaKilometrow;
            }
        }

        public abstract string TypSilnika();
        //metoda musi być przysłonieta po stronie klasy dziedziczącej - jej zadaniem jest przekazanie nazwy typu silnika    
    }
}
