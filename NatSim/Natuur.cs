using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NatSim
{
    public enum SoortLeven
    {
        Gras,
        Vingerhoedskruid,
        Venijnboom,
        Koe,
        Konijn,
        Beer,
        Lynx
    }
    public class Natuur : List<Leven>
    {
        // 
        // Constructors
        //
        public Natuur() : base()
        {
            _levensKlok.Interval = 10;
            _levensKlok.Start();
            _levensKlok.Tick += _levensKlok_Tick;
        }

        private void _levensKlok_Tick(object sender, EventArgs e)
        {
            foreach (Leven leven in this)
            {
                if (leven.IsDier)
                {
                    ((Dier)leven).Beweeg();
                }
            }
        }

        //
        // Private variabelen
        //
        Timer _levensKlok = new Timer();

        // 
        // Publieke methoden
        //
        public new void Add(Leven leven)
        {
            // Abonneren op het bericht dat het object gestorven is.
            leven.Einde += leven_Einde;
            // Abonneren als er op het object geklikt is.
            leven.OpObject += leven_OpObject;
            // In het geval het object een dier is moet de snelheid meegegeven worden:
            if (leven.IsDier == true)
            {
                Random random = new Random();
                Snelheid snelheid = new Snelheid(random.Next(-4, 4), random.Next(-4, 4));
                ((Dier)leven).SnelheidObject = snelheid;
            }
            // Toevoegen van het leven aan de lijst (List). Hiervoor gebruiken we de
            // methode die bij de base-klasse hoort waarvan geërfd is:
            base.Add(leven);
            // Het activeren van het event NieuwLeven als er geabonneerd wordt op
            // het event.
            if (NieuwLeven != null)
            {
                NieuwLeven(this, new NieuwLevenEventArgs(leven));
            }
        }

        private void leven_OpObject(object sender, EventArgs e)
        {
            // Als iemand zich geabonneerd heeft op Getroffen dan wordt
            // als het ware het onderliggende event dat is afgegaan doorgegeven.
            // Zo kun je een ketting van events maken.
            if (Getroffen != null)
            {
                // Als een object uit de lijst geactiveerd wordt
                // dan activeert Natuur het Getroffen event.
                Getroffen(this, new GetroffenEventArgs((Leven)sender));
            }
        }

        private void leven_Einde(object sender, EventArgs e)
        {
            // Als een leven beëindigd is wordt het uit de lijst
            // natuur verwijderd:
            this.Remove((Leven)sender); ;
        }

        public void LevenGeraakt(Point locatie)
        {
            foreach (Leven leven in this)
            {
                leven.IsOpObject(locatie);
            }
        }

        public event EventHandler<NieuwLevenEventArgs> NieuwLeven;
        public event EventHandler<GetroffenEventArgs> Getroffen;
    }

    // 
    // De klassen die zorgen voor extra informatie bij een event NieuwLeven
    //
    public class NieuwLevenEventArgs : EventArgs
    {
        // Constructor
        public NieuwLevenEventArgs(Leven leven)
        {
            NieuwLeven = leven;
        }

        // Eigenschappen
        public Leven NieuwLeven { get; set; }
    }

    public class GetroffenEventArgs : EventArgs
    {
        // Constructor
        public GetroffenEventArgs(Leven leven)
        {
            Getroffen = leven;
            GeraaktOp = DateTime.Now;
        }

        // Eigenschappen
        public Leven Getroffen { get; set; }
        public DateTime GeraaktOp { get; set; }
    }
}
