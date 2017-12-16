using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Silniki
{
    class SilnikBenzynowy : Silnik
    {
        public string RodzajSilnika { get; private set; }

        public SilnikBenzynowy() : base()
        {
            this.RodzajSilnika = "Silnik Benzynowy";
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
