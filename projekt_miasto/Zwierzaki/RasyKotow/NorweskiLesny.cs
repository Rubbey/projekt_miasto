using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Zwierzaki.RasyKotow
{
    class NorweskiLesny : Kot
    {
        public override string RasaZwierzaka()
        {
            return "Norweski Lesny";
        }
        public NorweskiLesny(string imie, int wiek) : base(imie, wiek)
        {
            Rodzaj = RodzajZwierzatka.DOMOWE;
        }

    }
}
