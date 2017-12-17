using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Zwierzaki
{
    class Kot : Zwierzatko
    {
        public override string GatunekZwierzatka()
        {
            return "ssak";
        }

        public override void NiechZwierzCosPowie()
        {
            Console.WriteLine("Miaaaallll...");
        }

        public override string RasaZwierzaka()        
        {
            return "Kot";
        }   
    }
}
