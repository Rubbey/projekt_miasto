using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Zwierzaki
{
    abstract class Kot : Zwierzatko
    {
        public override string GatunekZwierzatka()
        {
            return "Kot";
        }

        public override void NiechZwierzCosPowie()
        {
            Console.WriteLine("Dej mje zrec!! Miaaallll!!!!");
        }

        public Kot(string imie, int wiek): base(imie, wiek)
        {

        }

    }
}
