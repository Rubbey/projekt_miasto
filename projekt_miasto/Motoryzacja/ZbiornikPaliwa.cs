using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja
{
    class ZbiornikPaliwa : IInformacje
    {
        public long MaksymalnaIloscPaliwa { get; private set; }
        public long IloscPaliwa { get; private set; }

        
        public ZbiornikPaliwa(long maxPaliwa )
        {
            MaksymalnaIloscPaliwa = maxPaliwa;
            IloscPaliwa = 0;
        }

        public void Dotankuj(long iloscPaliwa)
        {
            if (IloscPaliwa == MaksymalnaIloscPaliwa)
            {
                Console.WriteLine("Zbiornik jest Pełny!");
            }
            else if (iloscPaliwa > this.MaksymalnaIloscPaliwa - this.IloscPaliwa) 
            {
                Console.WriteLine("Możesz dotankować maksymalnie {0}l paliwa!", this.MaksymalnaIloscPaliwa - this.IloscPaliwa);                
            }
            else
            {
                this.IloscPaliwa += iloscPaliwa;
                Console.WriteLine("Zbirnik dotankowany! masz {0}l paliwa!", IloscPaliwa);
            }
        }

        public void Dotankuj()
        {
            long iloscPaliwa = Toolbox.inputInteger("Ile litrów paliwa chcesz zatankować? ", 0, (int)MaksymalnaIloscPaliwa - (int)IloscPaliwa);
            this.IloscPaliwa += iloscPaliwa;
            Console.WriteLine("Zbirnik dotankowany! masz {0}l paliwa!", IloscPaliwa);
        }

        public long Pobierz(long iloscPaliwa)
        {
            this.IloscPaliwa -= iloscPaliwa;
            if (this.IloscPaliwa-iloscPaliwa < 0)
            {
                this.IloscPaliwa = 0;
                Console.WriteLine("Skonczylo sie paliwo!");
            }
            return this.IloscPaliwa;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Pojemność zbirnika paliwa: {0}\n Aktualna ilość paliwa w zbiorniku: {1}", this.MaksymalnaIloscPaliwa, this.IloscPaliwa);
        }
       
    }
}
