using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NatSim
{
    public class Vingerhoedskruid : Plant
    {
        // 
        // Initialisatie
        //

        public Vingerhoedskruid() : base(1, "Digitalis purpurea", 10, Bloeiwijze.tuil)
        {
            initClass(new Point(0, 0));
        }
        public Vingerhoedskruid(Point locatie) : base(1, "Digitalis purpurea", 10, Bloeiwijze.tuil)
        {
            initClass(locatie);
        }
        private void initClass(Point locatie)
        {
            Locatie = locatie;
            Tekengebied.Afmetingen = new Size(15, 50);
            Kleur = Color.MediumPurple;
            Voedingswaarde = 3;
        }
        public static void Zaaien(Point locatie, Graphics papier, int lengte,
                                  int breedte, int zaaiAfstand)
        {
            // Berekenen van het punt vanaf waar gezaaid gaat worden
            // (de locatie ligt midden in het gebied):
            int puntX = locatie.X - lengte / 2;
            int puntY = locatie.Y - breedte / 2;

            // Variabelen die de uitgansposities bewaren zodat
            // deze hersteld en opnieuw gebruikt kunnen worden:
            Point oorspronkelijkeLocatie = locatie;
            int startpuntY = puntY;

            // Bepalen tot welke locatie er gezaaid gaat worden:
            lengte = puntX + lengte;
            breedte = puntY + breedte;
            while (puntX < lengte)
            {
                while (puntY < breedte)
                {
                    locatie = new Point(puntX, puntY);
                    Gras gras = new Gras(locatie);
                    gras.Teken(papier);
                    puntY = puntY + zaaiAfstand;
                }
                puntY = startpuntY;
                puntX = puntX + zaaiAfstand;
            }
        }
        public static void Zaaien(Point locatie, Graphics papier, Plant plant)
        {
            Zaaien(locatie, papier, 150, 46, 15);
        }
    }
}
