using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace NatSim
{
    public abstract class Dier : Leven, IBewegendObject
    {
        //
        // Constructor
        //
        public Dier(int verhoudingTicksJaren,
                    string latijnseNaam,
                    int levensduur,
                    double gewichtMaximaal)
               : base(verhoudingTicksJaren,latijnseNaam,levensduur)
        {
            initDier(gewichtMaximaal);
        }
        private void initDier(double gewichtMaximaal)
        {
            _gewichtMaximaal = gewichtMaximaal;
            WordtVergiftigdDoor = new List<string>();
        }

        // 
        // Private variabelen
        //
        // Maximaal gewicht van een dier in kg
        private double _gewichtMaximaal = 0;

        //
        // Eigenschappen voor alle dieren
        //
        // van 0 tot 100% (honger tot 75%)
        public int MaagGevuld { get; set; }
        // Aantal ticks dat het duurt voordat een maltijd verteerd is
        public int SpijsverteringsDuur {  get; set; }
        // Maximaal gewicht van een dier in kg
        public double GewichtMaximaal
            { get { return GewichtMaximaal; } }
        public List<string> WordtVergiftigdDoor { get; set; }
        public Snelheid SnelheidObject { get; set; }

        // 
        // Methoden
        //
        // Een kenmerk van dieren is dat ze eten. Op dit niveau weten we nog niet wat.
        // Een konijn zal geen lynx eten, andersom wel en een lynx zal geen gras eten.
        public abstract void Eet(Leven leven);
        // Dieren zullen wel, net als in NatSim, alleen eten als ze honger hebben:
        public bool Honger()
            {
                return (MaagGevuld < 25); 
            }

        // Dieren bewegen, dit maken we mogelijk met de methode Beweeg():
        public void Beweeg()
        {
            Verwijder();
            Locatie = Stap();
            Teken();
        }

        // Methoden voor IBewegendObject
        public Point Stap()
        {
            return Stap(this.SnelheidObject);
        }
        public Point Stap(Snelheid snelheidObject)
        {
            this.SnelheidObject = snelheidObject;

            // Waar komt het object terecht bij de voorgenomen stap?
            int berekendeX = Locatie.X + (SnelheidObject.X);
            int berekendeY = Locatie.Y + (SnelheidObject.Y);

            // Bepalen van het nieuwe Tekengebied waar het object getekend gaat worden:
            Rechthoek nieuwTekengebied = new Rechthoek(new Point(berekendeX, berekendeY),
                                                                Tekengebied.Afmetingen);
            // Berekenen van een nieuwe richting naar aanleiding van een
            // eventuele overschrijding van een grens.
            Vlak vlak = Rechthoek.GrensBereikt(nieuwTekengebied, GraphicsVenster);

            // Berekenen van nieuwe richting als het object een rand tegenkomt.
            SnelheidObject = SnelheidObject.Stuiter(vlak);

            // Opnieuw berekenen van de snelheid zodat een wijziging
            // van de richting meegenomen wordt.
            berekendeX = Locatie.X + (SnelheidObject.X);
            berekendeY = Locatie.Y + (SnelheidObject.Y);

            return new Point(berekendeX, berekendeY);
        }

        // Eigenschappen voor IBewegendObject
        public System.Windows.Forms.Timer Klok { get { return Klok; } set { Klok = value; } }
    }
}
