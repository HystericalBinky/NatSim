using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatSim
{
    public partial class FrmNatSim : Form
    {
        SoortLeven soortPlant = SoortLeven.Gras;
        SoortLeven soortDier = SoortLeven.Konijn;

        Natuur natuur = new Natuur();
        //
        // Initialisatie
        //
        Graphics papier;
        // private Graphics papier;

        public FrmNatSim()
        {
            //
            // Constructor
            //
            InitializeComponent();
           
            papier = pbWereld.CreateGraphics();

            // Koppel het Resize-event van het formulier aan een event handler
            this.Resize += FrmNatSim_Resize;

            // Abonneren op de diverse events van de lijst Natuur:
            natuur.NieuwLeven += natuur_NieuwLeven;
            natuur.Getroffen += natuur_Getroffen;

            void natuur_NieuwLeven(object sender, NieuwLevenEventArgs e)
            {
                e.NieuwLeven.Teken(papier);
            }
        }

        private void natuur_Getroffen(object sender, GetroffenEventArgs e)
        {
            lblInformatie.Text = e.GeraaktOp.ToString("hh:mm:ss tt") +
                                 Environment.NewLine + Environment.NewLine +
                                 e.Getroffen.ToString();
        }

        private void FrmNatSim_Resize(object sender, EventArgs e)
        {
            // Roep de methodes aan die de UI-componenten schalen
            ResizePictureBox();
                {
                // Deze methode zorgt ervoor dat, zodra de grootte van het
                // formulier wijzigt, de groote van de PictureBo pbWereld zo
                // word aangepast dat het formuler opotimaal gevuld wordt.
                int margeBreedte = 40;
                int margeHoogte = 64;
                pbWereld.Width = this.Width - grbDieren.Width - grbPLanten.Width - margeBreedte;
                pbWereld.Height = this.Height - margeHoogte;
                papier = pbWereld.CreateGraphics();
                }

            ResizeLblInformatie();
            {
                // Deze methode zorgt ervoor dat, zodra de grootte van het
                // formjulier wijzigt, de hoogte van het informatielabel lbnlInfo zo
                // wordt aangepast dat het formulier optimaal gebruikt wordt.
                int margeHoogte = 88;
                lblInformatie.Height=this.Height - margeHoogte - pnlKnoppen.Height; 
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKonijn.Checked) soortDier = SoortLeven.Konijn;
        }

        private void FrmNatSim_Load(object sender, EventArgs e)
        {

        }

        private void ResizePictureBox()
        {
            // Deze methode zorgt ervoor dat, zodra de grootte van het
            // formulier wijzigt, de grootte van de PictureBox pbWereld zo
            // wordt aangepast dat het formulier optimaal gevuld wordt.
            int margeBreedte = 40;
            int margeHoogte = 64;
            pbWereld.Width =
                this.Width - grbDieren.Width - grbPLanten.Width - margeBreedte;
            pbWereld.Height = this.Height - margeBreedte;
            papier = pbWereld.CreateGraphics();
        }

        private void ResizeLblInformatie()
        {
            // Deze methode zorgt ervoor dat, zodra de grootte van het
            // formulier wijzigt, de hoogte van het informatielabel lblInfo zo
            // wordt aangepast dat het formulier optimaal gebruikt wordt.
            int margeHoogte = 88;
            lblInformatie.Height = this.Height - margeHoogte - pnlKnoppen.Height;
        }

        private void pbWereld_MouseClick(object sender, MouseEventArgs e)   // sender is muisklik, extra gegevens bij het event
                                                                            // (hier: welke knop en locatie).
        {
            SoortLeven soortLeven = SoortLeven.Gras;
            if (e.Button== MouseButtons.Left)
            {
                soortLeven = soortDier;
            }
            else if (e.Button == MouseButtons.Right)
            {
                soortLeven = soortPlant;
            }

            switch (soortLeven)
            {
                case SoortLeven.Gras:
                    natuur.Add(new Gras(e.Location));
                    break;
                case SoortLeven.Vingerhoedskruid:
                    natuur.Add(new Vingerhoedskruid(e.Location)); 
                    break;
                case SoortLeven.Venijnboom:
                    natuur.Add(new Venijnboom(e.Location));
                    break;
                case SoortLeven.Koe:
                    natuur.Add(new Koe(e.Location));
                    break;
                case SoortLeven.Konijn:
                    natuur.Add(new Konijn(e.Location));
                    break;
                case SoortLeven.Beer:
                    // Zodra er een Klasse Beer gemaakt is moet onderstaande regel geactiveerd
                    // worden:
                    // natuur.Add(new Beer(e.Location);
                    break;
                case SoortLeven.Lynx:
                    // Zodra er een Klasse Lynx gemaakt is moet onderstaande regel geactiveerd
                    // worden:
                    // natuur.Add(new Lynx(e.Location);
                    break;
                default:
                    break;
            }

            // Het als laatste aan de lijst natuur toegevoegde element wordt getekend:
            natuur.Last().Teken(papier);
        }

        private void TekenDier(Point positie)
        {
            if (rdbKonijn.Checked == true)
            {
                Konijn Konijn01 = new Konijn(positie, "Flappie", Color.Brown);
                Konijn01.Teken(pbWereld.CreateGraphics());
            }
            if (rdbKoe.Checked == true)
            {
                Koe Koe01 = new Koe(positie, "Berta", Color.Green);
                Koe01.Teken(pbWereld.CreateGraphics());
            }
        }

        private void TekenPlant(Point locatie)

        {
            if (rdbVenijnboom.Checked == true)
            {
                Venijnboom Venijnboom01 = new Venijnboom(locatie);
                Venijnboom01.Teken(pbWereld.CreateGraphics());
            }
            if (rbnGras.Checked == true)
            {
                Gras Gras01 = new Gras(locatie);
                Gras01.Teken(pbWereld.CreateGraphics());
            }
        }

     

        private void pbWereld_Click(object sender, EventArgs e)
        {

        }

        private void rbnGras_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnGras.Checked) soortPlant = SoortLeven.Gras;
        }

        private void rdbKoe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKoe.Checked) soortDier = SoortLeven.Koe;
        }

        private void rdbLynx_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLynx.Checked) soortDier = SoortLeven.Lynx;
        }

        private void rdbBeer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBeer.Checked) soortDier = SoortLeven.Beer;
        }

        private void rdbVenijnboom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVenijnboom.Checked) soortPlant = SoortLeven.Venijnboom;
        }

        private void rbnVingerhoedskruit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnVingerhoedskruit.Checked) soortPlant = SoortLeven.Vingerhoedskruid;
        }

        private void pbWereld_MouseMove(object sender, MouseEventArgs e)
        {
            if (chbZaai.Checked && rbnGras.Checked) 
            {
                Gras.Zaaien(e.Location, pbWereld.CreateGraphics());
            }
            else
            {
                // Bij het bewegen van de muis wordt gekeken of er een levend object getroffen
                // wordt. Zo ja, dan wordt het event geactiveerd dat aangeeft dat het object
                // getroffen is:
                lblInformatie.Text = "";
                natuur.LevenGeraakt(e.Location);
            }
        }
    }

    public enum Bloeiwijze
    {
        none,
        hoofdje,
        bloemkoek,
        bloemkluwen,
        aar,
        aartje,
        katje,
        bloeikolf,
        tros,
        schermvormigeTros,
        bundel,
        scherm,
        schijnkrans,
        eentakkigBijscherm,
        schroef,
        sikkel,
        schicht,
        waaier,
        samengesteldScherm,
        samengesteldGevorktScherm,
        samengesteldeAar,
        pluim,
        dichasialePluim,
        tuil,
        dichasiaTuil,
        thyrsys,
        kegel

    }

    public enum Vlak
    {
        Horizontaal,
        Verticaal,
        Hoek,
        Geen
    }
}
