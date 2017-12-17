using projekt_miasto.Motoryzacja.Samochody.MarkiPojazdow;
using projekt_miasto.Motoryzacja.Silniki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Samochody.ModelePojazdow
{
    class JaguarXF : JaguarOsobowe
    {
        public JaguarXF() : base()
        {
            base.Silnik = new SilnikBenzynowy(4.1);
            base.ZbiornikPaliwa = new ZbiornikPaliwa(90);
        }

        public override string Model()
        {
            return "XF";
        }
    }
}
