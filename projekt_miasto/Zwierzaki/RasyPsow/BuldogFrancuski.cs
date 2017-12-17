using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Zwierzaki.RasyPsow
{
    class BuldogFrancuski : Pies
    {
        public override string RasaZwierzaka()
        {
            return "Buldog Francuski";
        }
        public BuldogFrancuski(string imie, int wiek) : base(imie, wiek)
        {
            Rodzaj = RodzajZwierzatka.DOMOWE;
        }

    }
}
