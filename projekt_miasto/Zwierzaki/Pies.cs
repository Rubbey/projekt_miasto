using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Zwierzaki
{
    abstract class Pies : Zwierzatko
    {
        public override string GatunekZwierzatka()
        {
            return "Pies";
        }

        public override void NiechZwierzCosPowie()
        {
            Console.WriteLine("Wooff! Woooff!");
        }
        
    }
}
