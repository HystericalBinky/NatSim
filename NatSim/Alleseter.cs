using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatSim
{
    public abstract class Alleseter : Dier
    {
        public override void Eet(Leven leven)
        {
            if (leven.IsPlant)
            {
                // Wat doet een planteneter met giftige planten?
                if (WordtVergiftigdDoor.Contains(leven.NederlandseNaam))
                {
                    // Normaal eet de planteneter geen giftige planten. Behalve als de
                    // planteneter honger heeft. Alleen gaat de planteneter dan wel dood.
                    // De planteneter eet een giftige plant en wordt verwijderd.
                    if (Honger())
                    {
                        this.Sterf();
                        leven.Sterf();
                    }
                    else
                    {
                        // Als de plant niet eetbaar is, keer dan om.
                        SnelheidObject = SnelheidObject.Keerom();
                    }
                }
                // Alles wat niet giftig is wordt gewoon opgegeten als er nog plek is
                else if (MaagGevuld < 100)
                {
                    MaagGevuld = MaagGevuld + leven.Voedingswaarde;
                    leven.Sterf();
                }
            }
            else if (leven.IsDier)
            {
                // Alles wat kleiner is wordt gewoon opgegeten als er nog plek is
                if (MaagGevuld < 100)
                {
                    // Als het dier kleiner is eet de vleeseter het dier op.
                    if (leven.GraphicsVenster.Afmetingen.Width < this.GraphicsVenster.Afmetingen.Width && leven.GraphicsVenster.Afmetingen.Height < this.GraphicsVenster.Afmetingen.Height)
                    {
                        MaagGevuld = MaagGevuld + leven.Voedingswaarde;
                        leven.Sterf();
                    }
                    // Als het dier groter is keert de vleeseter om.
                    else
                    {
                        SnelheidObject = SnelheidObject.Keerom();
                    }
                }
            }
            // Als het leven geen plant of dier is keert de planteneter om.
            else
            {
                SnelheidObject = SnelheidObject.Keerom();
            }
        }
        public Alleseter(int verhoudingTicksJaren,
                           string latijnseNaam,
                           int levensduur,
                           double gewichtMaximaal)
               : base(verhoudingTicksJaren, latijnseNaam, levensduur, gewichtMaximaal) { }
    }
}
