using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatSim
{
    public abstract class Leven : GrafischObject
    {
        // Initialisatie
        public Leven()
        {
            // In dit geval wordt iets van het type klasse aangemaakt zonder
            // parameters.
            // Omdat er ook een timer wordt geïnstalleerd die het object automatisch
            // weer laat verdwijnen, stellen we de levensduur in op
            // de grootste waarde.
            initClass(1,"",int.MaxValue);
        }
        public Leven(int verhoudingTicksJaren, string latijnseNaam, int levensduur)
        {
            initClass(verhoudingTicksJaren, latijnseNaam, levensduur);
        }
        private void initClass(int verhoudingTicksJaren, string latijnseNaam,
                               int levensduur)
        {
            VerhoudingTicksJaren = verhoudingTicksJaren;
            // Instellen ReadOnly-variabelen
            _latijnseNaam = latijnseNaam;
            _levensduur = levensduur;
            _verouder = new Timer();
            _verouder.Interval = _aantalTicksPerSeconde * verhoudingTicksJaren;
            _verouder.Start();
            _verouder.Tick += _verouder_Tick;
        }

        private void _verouder_Tick(object sender, EventArgs e)
        {
            // Een jaar bestaat uit x ticks.
            // Na een aantal jaren is de 'eindeleeftijd' bereikt en
            // houdt het object op te bestaan.
            if (Leeftijd < Levensduur)
            {
                Leeftijd++;
            }
            else
            {
                _verouder.Stop();
                Sterf();
            }
        }

        // Interne variabelen
        private const int _aantalTicksPerSeconde = 1000;
        private string _latijnseNaam;
        private double _levensduur;
        private Timer _verouder;

        // Eigenschappen
        public int Leeftijd { get; set; }
        public int VerhoudingTicksJaren { get; set; }
        public int Voedingswaarde { get; set; }

        // ReadOnly-eigenschappen
        public string LatijnseNaam { get { return _latijnseNaam; } }
        public double Levensduur { get { return _levensduur; } }
        public string NederlandseNaam { get { return base.ToString().Split('.').
                                       Last(); } }
        public Timer Verouder { get { return _verouder; } }

        // Methoden
        public void Sterf()
        {
            Verwijder();
            OnEinde();
        }

        public bool IsPlant
        {
            // Deze code kijkt of het type van het object erft van Plant
            // en geeft het resultaat terug.
            // Met GetType bepaal je het type van het object.
            // Met IsSubclassOf bekijk je of deze klasse erft van, in dit geval Plant:
            get { return this.GetType().IsSubclassOf(typeof(Plant)); }
        }

        public bool IsDier
        {
            // Deze code kijkt of het type van het object erft van Plant
            // en geeft het resultaat terug.
            // Met GetType bepaal je het type van het object.
            // Met IsSubclassOf bekijk je of deze klasse erft van, in dit geval Plant:
            get { return this.GetType().IsSubclassOf(typeof(Dier)); }
        }

        public event EventHandler<EventArgs> Einde;

        protected virtual void OnEinde()
        {
            // Check of er abonnees zijn op het event Einde.
            if (Einde != null)
            {
                // Activeren van het event Einde
                Einde(this, EventArgs.Empty);
            }
        }
    }
}
