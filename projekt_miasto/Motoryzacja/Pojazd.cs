﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja
{
    abstract class Pojazd : IInformacje
    {
        public enum RodzajPojazdu
        {
            JEDNOSLAD = 1,
            OSOBOWY = 2,
            TERENOWY = 3,
            CIEZAROWY = 4
        };

        public ZbiornikPaliwa ZbiornikPaliwa { get; protected set; }
        public Silnik Silnik { get; protected set; }
        public RodzajPojazdu Rodzaj { get; private set; }


        public Pojazd()
        {
            UstawRodzajPojazdu(0);
        }
        public Pojazd(int rodzajPojazdu)
        {
            UstawRodzajPojazdu(rodzajPojazdu);
        }

        public void UstawRodzajPojazdu(int rodzajPojazdu)
        {
            bool done = false;
            while (!done)
            {
                switch (rodzajPojazdu)
                {
                    case 1:
                        this.Rodzaj = RodzajPojazdu.JEDNOSLAD;
                        done = true;
                        break;
                    case 2:
                        this.Rodzaj = RodzajPojazdu.OSOBOWY;
                        done = true;
                        break;
                    case 3:
                        this.Rodzaj = RodzajPojazdu.TERENOWY;
                        done = true;
                        break;
                    case 4:
                        this.Rodzaj = RodzajPojazdu.CIEZAROWY;
                        done = true;
                        break;
                    default:
                        rodzajPojazdu = Toolbox.inputInteger("Podaj rodzaj pojazdu.\n [1]-JEDNOSLAD\t [2]-OSOBOWY\n [3]-TERENOWY\t [4]-CIZAROWY\n Twój wybór: ", 1, 4);                       
                        break;
                }
            }
        }        


        public virtual void WyswietlInformacje()
        {
            Console.WriteLine("Rodzaj pojazdu: {0}",this.Rodzaj);
            Console.WriteLine("Marka: {0}", this.Marka());
            Console.WriteLine("Model: {0}", this.Model());

            if (Silnik != null)
            {
                Silnik.WyswietlInformacje();
            }

            if (ZbiornikPaliwa != null)
            {
                ZbiornikPaliwa.WyswietlInformacje();
            }
        }
        public abstract string Marka();
        public abstract string Model();

        public virtual long JedziemyWSinaDal(long liczbaKilometrow)
        
        {
            if (this.Silnik != null)
            {
                return this.Silnik.JedziemyWSinaDal(liczbaKilometrow, this.ZbiornikPaliwa);                
            }
            else
            {
                Console.WriteLine("Bez silnika nie pojedziemy! :(");
                return 0;
            }
        }

        public virtual long JedziemyWSinaDal()        
        {
            if (this.Silnik != null)
            {
                return this.Silnik.JedziemyWSinaDal((long)Toolbox.inputInteger("Ile kilometrow chcesz przejechac? ",1,int.MaxValue), this.ZbiornikPaliwa);
            }
            else
            {
                Console.WriteLine("Bez silnika nie pojedziemy! :(");
                return 0;
            }
        }
    }
    
}

