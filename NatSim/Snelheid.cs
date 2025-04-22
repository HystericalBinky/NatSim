using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NatSim
{
    public struct Snelheid
    {
        // Eigenschappen
        public int X { get; set; }
        public int Y { get; set; }

        // Initialisatie 
        public Snelheid(int x, int y) : this()
        {
            X = x;
            Y = y;
        }

        // Methoden
        // Keerom: het object gaat dezelfde weg terug.
        public Snelheid Keerom()
        {
            X = -1 * X;
            Y = -1 * Y;
            return new Snelheid(X, Y);
        }

        public Snelheid Stuiter(Vlak vlak)
        {
            // Stuiter: Als een object tegen een horizontaal vlak, boven, of beneden,
            // bots, wordt de y-component van de snelheid omgedraaid.
            // Als een object tegen een verticaal vlak, links of rechts,
            // botst, wordt de x-component van de snelheid omgedraaid.
            // Bij een botsing precies in een hoek, worden beide componenten omgedraaid.
            switch (vlak)
            {
                case Vlak.Horizontaal:
                    Y = -1 * Y;
                    break;
                case Vlak.Verticaal:
                    X = -1 * X;
                    break;
                case Vlak.Hoek:
                    X = -1 * X;
                    Y = -1 * Y;
                    break;
            }
            return new Snelheid(X, Y);
        }
    }
}
