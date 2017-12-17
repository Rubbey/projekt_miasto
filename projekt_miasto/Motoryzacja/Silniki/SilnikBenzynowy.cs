using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Silniki
{
    class SilnikBenzynowy : Silnik
    {
        public SilnikBenzynowy(double pojemnoscSilnia) : base(pojemnoscSilnia)
        {
        }

        public override string TypSilnika()
        {            
            return "Silnik benzynowy";
        }

    }
}
