using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Silniki
{
    class SilnikParowy : Silnik
    {
        public SilnikParowy(double pojemnoscSilnika) : base(pojemnoscSilnika)
        {
        }

        public override string TypSilnika()
        {
            return "Silnik parowy";
        }

    }
}

