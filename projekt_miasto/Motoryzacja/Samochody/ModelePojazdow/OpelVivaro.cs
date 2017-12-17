using projekt_miasto.Motoryzacja.Samochody.MarkiPojazdow;
using projekt_miasto.Motoryzacja.Silniki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Samochody.ModelePojazdow
{
    class OpelVivaro : OpelCiezarowe
    {
        public OpelVivaro() : base()
        {
            base.Silnik = new SilnikDiesela(2.0);
            base.ZbiornikPaliwa = new ZbiornikPaliwa(95);
        }

        public override string Model()
        {
            return "Vivaro";
        }
    }
}
