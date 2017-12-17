using projekt_miasto.Motoryzacja.Samochody.MarkiPojazdow;
using projekt_miasto.Motoryzacja.Silniki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Samochody.ModelePojazdow
{
    class JaguarFpeace : JaguarTerenowe
    {
        public JaguarFpeace() : base()
        {
            base.Silnik = new SilnikBenzynowy(5.2);
            base.ZbiornikPaliwa = new ZbiornikPaliwa(120);
        }

        public override string Model()
        {
            return "F-Peace";
        }
    }
}
