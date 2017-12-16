using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Silniki
{
    class SilnikDiesela : Silnik
    {
        public string RodzajSilnika { get; private set; }

        public SilnikDiesela() : base()
        {
            this.RodzajSilnika = "Silnik Diesela";
        }

        public override string TypSilnika()
        {
            return this.RodzajSilnika;
        }

        public override void WyswietlInformacje()
        {
            Console.WriteLine("Typ silnika: {0},", this.RodzajSilnika);
            base.WyswietlInformacje();
        }
    }
}
