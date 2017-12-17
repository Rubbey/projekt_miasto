using projekt_miasto.Motoryzacja.Samochody.MarkiPojazdow;
using projekt_miasto.Motoryzacja.Silniki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Samochody.ModelePojazdow
{
    class BMW320 : BmwOsobowe
    {
        public BMW320() : base()
        {
            base.Silnik = new SilnikDiesela(2.0);
            base.ZbiornikPaliwa = new ZbiornikPaliwa(80);
        }

        public override string Model()
        {
            return "320";
        }
    }
}
