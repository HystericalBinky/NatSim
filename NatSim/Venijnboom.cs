using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NatSim
{
    public class Venijnboom : Plant
    {
        //
        // Initialisatie
        //
        public Venijnboom()
            : base(1, "Taxus baccata", 2000, Bloeiwijze.kegel)
        {
            initClass(new Point(0, 0));
        }
        public Venijnboom(Point locatie)
            : base(1, "Taxus baccata", 2000, Bloeiwijze.kegel)
        {
            initClass(locatie);
        }

        private void initClass(Point locatie)
        {
            Locatie = locatie;
            Tekengebied.Afmetingen = new Size(10, 400);
            Kleur = Color.ForestGreen;
        }
        //
        // Variabelen
        //
        private List<string> _geneesmiddelVoor = new List<string> { "Longkanker",
                                                                    "Borstkanker"};
        private int _maximaalGrootte = 20000;

        // 
        // ReadOnly-eigenschappen
        //
        public List<string> GeneesmiddelVoor { get { return _geneesmiddelVoor;} }
        public int MaximaalGrootte { get {  return _maximaalGrootte; } }

        // 
        // Eigenschappen
        //
        public double AantalKubiekeMetersHout { get; set; }
    }
}
