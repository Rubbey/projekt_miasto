using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Zwierzaki.RasyKotow
{
    class MainCoon : Kot
    {
        public override string RasaZwierzaka()
        {
            return "Mine Coon";
        }
        public MainCoon(string imie, int wiek) : base(imie, wiek)
        {
            Rodzaj = RodzajZwierzatka.DOMOWE;
        }

    }
}
