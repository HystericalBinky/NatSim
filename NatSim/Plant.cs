using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NatSim
{
    public abstract class Plant : Leven
    {
        //
        // Initialisatie
        //
        public Plant(){}
        public Plant(int verhoudingTicksJaren, string latijnseNaam,
                     int levensduur, Bloeiwijze bloeiwijzePlant)
            : base(verhoudingTicksJaren, latijnseNaam, levensduur)
        {
            BloeiwijzePlant = bloeiwijzePlant;
        }
        // 
        // Eigenschappen
        //
        public Bloeiwijze BloeiwijzePlant { get; set; }

        public override string ToString()
        {
            return "Latijnse naam: " + LatijnseNaam + Environment.NewLine
            + Environment.NewLine + "Nederlandse naam: " + NederlandseNaam
            + Environment.NewLine + Environment.NewLine + "Levensduur: " + Levensduur
            + Environment.NewLine + Environment.NewLine + "Bloeiwijze: " + BloeiwijzePlant
            + Environment.NewLine + Environment.NewLine + "Locatie: "
            + Locatie.ToString();
        }
    }
}
