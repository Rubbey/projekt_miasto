using projekt_miasto.Motoryzacja.Samochody.MarkiPojazdow;
using projekt_miasto.Motoryzacja.Silniki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Samochody.ModelePojazdow
{
    class BMWGS : BmwMotocykle
    {
        public BMWGS() : base()
        {
            base.Silnik = new SilnikBenzynowy(1.8);
            base.ZbiornikPaliwa = new ZbiornikPaliwa(25);
        }

        public override string Model()
        {
            return "GS";
        }
    }
}
