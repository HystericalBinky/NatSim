using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace NatSim
{
    public interface IBewegendObject
    {
        // Eigenschappen
        Snelheid SnelheidObject { get; set; } // De verplaatsing over de x- en de y- as
                                              // per tijdseenheid.
        Timer Klok { get; set; }              // Hoe vaak wordt het scherm ververst?

        // Methoden
        Point Stap();
        Point Stap(Snelheid snelheidObject);
    }
}
