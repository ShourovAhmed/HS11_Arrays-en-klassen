using System;
using System.Collections.Generic;
using System.Text;

namespace Kaarten
{
    enum Suite { Schoppen, Harten, Klaveren, Ruiten}
    class Speelkaart
    {
        public Speelkaart(int get, Suite kleur)
        {
            Nummer = get;
            kleur = Kleur;
        }

        public int Nummer { get; set; }
        public Suite Kleur { get; set; }
    }
}
