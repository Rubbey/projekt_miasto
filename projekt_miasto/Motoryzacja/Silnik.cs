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

        
        public Silnik(double pojemnoscSilnika)
        {
            this.PojemnoscSilnika = pojemnoscSilnika;
            this.LiczbaPrzejechanychKilometrow = 0;
            this.ZuzyciePaliwa = (PojemnoscSilnika * 2.5) / 100.0;
        }

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine("Typ silnika = {0}", this.TypSilnika());
            Console.WriteLine("Pojemnosc: {0}\t Przebieg: {1}\t Zuzycie paliwa: {2}",this.PojemnoscSilnika, this.LiczbaPrzejechanychKilometrow, this.ZuzyciePaliwa);
        }
        
        public virtual long JedziemyWSinaDal(long liczbaKilometrow, ZbiornikPaliwa zbiornikPaliwa)
        {
            
            double liczbaMozliwychDoPrzejechaniaKilometrow = zbiornikPaliwa.IloscPaliwa / ZuzyciePaliwa;
            if (liczbaKilometrow > liczbaMozliwychDoPrzejechaniaKilometrow)
            {
                Console.WriteLine("Nie ma wystarczającej ilości paliwa na przejechanie całego dystansu!\nJadę ile sie da [{0}km]! ", (int)liczbaMozliwychDoPrzejechaniaKilometrow);
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
        
    }
}
