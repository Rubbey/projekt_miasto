using projekt_miasto.Motoryzacja.Samochody.MarkiPojazdow;
using projekt_miasto.Motoryzacja.Silniki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Samochody.ModelePojazdow
{
    class BMWX5 : BmwTerenowe
    {
        public BMWX5() : base()
        {
            base.Silnik = new SilnikBenzynowy(5);
            base.ZbiornikPaliwa = new ZbiornikPaliwa(100);
        }

        public override string Model()
        {
            return "X5";
        }
    }
}
