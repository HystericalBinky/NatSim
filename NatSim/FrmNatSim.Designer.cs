namespace NatSim
{
    partial class FrmNatSim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDieren = new System.Windows.Forms.GroupBox();
            this.rdbBeer = new System.Windows.Forms.RadioButton();
            this.rdbLynx = new System.Windows.Forms.RadioButton();
            this.rdbKoe = new System.Windows.Forms.RadioButton();
            this.rdbKonijn = new System.Windows.Forms.RadioButton();
            this.grbPLanten = new System.Windows.Forms.GroupBox();
            this.chbZaai = new System.Windows.Forms.CheckBox();
            this.rbnVingerhoedskruit = new System.Windows.Forms.RadioButton();
            this.rdbVenijnboom = new System.Windows.Forms.RadioButton();
            this.rbnGras = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblInformatie = new System.Windows.Forms.Label();
            this.pbWereld = new System.Windows.Forms.PictureBox();
            this.pnlKnoppen = new System.Windows.Forms.Panel();
            this.btnEinde = new System.Windows.Forms.Button();
            this.hsbSnelheid = new System.Windows.Forms.HScrollBar();
            this.Label2 = new System.Windows.Forms.Label();
            this.grbDieren.SuspendLayout();
            this.grbPLanten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWereld)).BeginInit();
            this.pnlKnoppen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDieren
            // 
            this.grbDieren.BackColor = System.Drawing.Color.BurlyWood;
            this.grbDieren.Controls.Add(this.rdbBeer);
            this.grbDieren.Controls.Add(this.rdbLynx);
            this.grbDieren.Controls.Add(this.rdbKoe);
            this.grbDieren.Controls.Add(this.rdbKonijn);
            this.grbDieren.Location = new System.Drawing.Point(9, 10);
            this.grbDieren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDieren.Name = "grbDieren";
            this.grbDieren.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDieren.Size = new System.Drawing.Size(89, 156);
            this.grbDieren.TabIndex = 0;
            this.grbDieren.TabStop = false;
            this.grbDieren.Text = "Dieren";
            // 
            // rdbBeer
            // 
            this.rdbBeer.AutoSize = true;
            this.rdbBeer.Location = new System.Drawing.Point(4, 72);
            this.rdbBeer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbBeer.Name = "rdbBeer";
            this.rdbBeer.Size = new System.Drawing.Size(47, 17);
            this.rdbBeer.TabIndex = 4;
            this.rdbBeer.TabStop = true;
            this.rdbBeer.Text = "Beer";
            this.rdbBeer.UseVisualStyleBackColor = true;
            this.rdbBeer.CheckedChanged += new System.EventHandler(this.rdbBeer_CheckedChanged);
            // 
            // rdbLynx
            // 
            this.rdbLynx.AutoSize = true;
            this.rdbLynx.Location = new System.Drawing.Point(4, 53);
            this.rdbLynx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbLynx.Name = "rdbLynx";
            this.rdbLynx.Size = new System.Drawing.Size(47, 17);
            this.rdbLynx.TabIndex = 3;
            this.rdbLynx.TabStop = true;
            this.rdbLynx.Text = "Lynx";
            this.rdbLynx.UseVisualStyleBackColor = true;
            this.rdbLynx.CheckedChanged += new System.EventHandler(this.rdbLynx_CheckedChanged);
            // 
            // rdbKoe
            // 
            this.rdbKoe.AutoSize = true;
            this.rdbKoe.Location = new System.Drawing.Point(4, 34);
            this.rdbKoe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbKoe.Name = "rdbKoe";
            this.rdbKoe.Size = new System.Drawing.Size(44, 17);
            this.rdbKoe.TabIndex = 2;
            this.rdbKoe.TabStop = true;
            this.rdbKoe.Text = "Koe";
            this.rdbKoe.UseVisualStyleBackColor = true;
            this.rdbKoe.CheckedChanged += new System.EventHandler(this.rdbKoe_CheckedChanged);
            // 
            // rdbKonijn
            // 
            this.rdbKonijn.AutoSize = true;
            this.rdbKonijn.Checked = true;
            this.rdbKonijn.Location = new System.Drawing.Point(4, 15);
            this.rdbKonijn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbKonijn.Name = "rdbKonijn";
            this.rdbKonijn.Size = new System.Drawing.Size(54, 17);
            this.rdbKonijn.TabIndex = 1;
            this.rdbKonijn.TabStop = true;
            this.rdbKonijn.Text = "Konijn";
            this.rdbKonijn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.rdbKonijn.UseVisualStyleBackColor = true;
            this.rdbKonijn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grbPLanten
            // 
            this.grbPLanten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbPLanten.BackColor = System.Drawing.Color.PaleGreen;
            this.grbPLanten.Controls.Add(this.chbZaai);
            this.grbPLanten.Controls.Add(this.rbnVingerhoedskruit);
            this.grbPLanten.Controls.Add(this.rdbVenijnboom);
            this.grbPLanten.Controls.Add(this.rbnGras);
            this.grbPLanten.Location = new System.Drawing.Point(9, 171);
            this.grbPLanten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPLanten.Name = "grbPLanten";
            this.grbPLanten.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPLanten.Size = new System.Drawing.Size(89, 137);
            this.grbPLanten.TabIndex = 1;
            this.grbPLanten.TabStop = false;
            this.grbPLanten.Text = "Planten";
            // 
            // chbZaai
            // 
            this.chbZaai.AutoSize = true;
            this.chbZaai.Location = new System.Drawing.Point(46, 16);
            this.chbZaai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbZaai.Name = "chbZaai";
            this.chbZaai.Size = new System.Drawing.Size(47, 17);
            this.chbZaai.TabIndex = 6;
            this.chbZaai.Text = "Zaai";
            this.chbZaai.UseVisualStyleBackColor = true;
            // 
            // rbnVingerhoedskruit
            // 
            this.rbnVingerhoedskruit.AutoSize = true;
            this.rbnVingerhoedskruit.Location = new System.Drawing.Point(4, 53);
            this.rbnVingerhoedskruit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbnVingerhoedskruit.Name = "rbnVingerhoedskruit";
            this.rbnVingerhoedskruit.Size = new System.Drawing.Size(104, 17);
            this.rbnVingerhoedskruit.TabIndex = 8;
            this.rbnVingerhoedskruit.TabStop = true;
            this.rbnVingerhoedskruit.Text = "Vingerhoedskruit";
            this.rbnVingerhoedskruit.UseVisualStyleBackColor = true;
            this.rbnVingerhoedskruit.CheckedChanged += new System.EventHandler(this.rbnVingerhoedskruit_CheckedChanged);
            // 
            // rdbVenijnboom
            // 
            this.rdbVenijnboom.AutoSize = true;
            this.rdbVenijnboom.Location = new System.Drawing.Point(4, 34);
            this.rdbVenijnboom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbVenijnboom.Name = "rdbVenijnboom";
            this.rdbVenijnboom.Size = new System.Drawing.Size(80, 17);
            this.rdbVenijnboom.TabIndex = 7;
            this.rdbVenijnboom.TabStop = true;
            this.rdbVenijnboom.Text = "Venijnboom";
            this.rdbVenijnboom.UseVisualStyleBackColor = true;
            this.rdbVenijnboom.CheckedChanged += new System.EventHandler(this.rdbVenijnboom_CheckedChanged);
            // 
            // rbnGras
            // 
            this.rbnGras.AutoSize = true;
            this.rbnGras.Checked = true;
            this.rbnGras.Location = new System.Drawing.Point(4, 15);
            this.rbnGras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbnGras.Name = "rbnGras";
            this.rbnGras.Size = new System.Drawing.Size(47, 17);
            this.rbnGras.TabIndex = 5;
            this.rbnGras.TabStop = true;
            this.rbnGras.Text = "Gras";
            this.rbnGras.UseVisualStyleBackColor = true;
            this.rbnGras.CheckedChanged += new System.EventHandler(this.rbnGras_CheckedChanged);
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(379, 10);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(66, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Natuurinfo";
            // 
            // lblInformatie
            // 
            this.lblInformatie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformatie.BackColor = System.Drawing.Color.Khaki;
            this.lblInformatie.Location = new System.Drawing.Point(362, 25);
            this.lblInformatie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformatie.Name = "lblInformatie";
            this.lblInformatie.Size = new System.Drawing.Size(77, 141);
            this.lblInformatie.TabIndex = 0;
            // 
            // pbWereld
            // 
            this.pbWereld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbWereld.Location = new System.Drawing.Point(103, 10);
            this.pbWereld.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbWereld.Name = "pbWereld";
            this.pbWereld.Size = new System.Drawing.Size(256, 299);
            this.pbWereld.TabIndex = 2;
            this.pbWereld.TabStop = false;
            this.pbWereld.Click += new System.EventHandler(this.pbWereld_Click);
            this.pbWereld.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbWereld_MouseClick);
            this.pbWereld.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbWereld_MouseMove);
            // 
            // pnlKnoppen
            // 
            this.pnlKnoppen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKnoppen.Controls.Add(this.btnEinde);
            this.pnlKnoppen.Controls.Add(this.hsbSnelheid);
            this.pnlKnoppen.Controls.Add(this.Label2);
            this.pnlKnoppen.Location = new System.Drawing.Point(364, 171);
            this.pnlKnoppen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlKnoppen.Name = "pnlKnoppen";
            this.pnlKnoppen.Size = new System.Drawing.Size(75, 137);
            this.pnlKnoppen.TabIndex = 0;
            // 
            // btnEinde
            // 
            this.btnEinde.BackColor = System.Drawing.Color.LightCoral;
            this.btnEinde.Location = new System.Drawing.Point(16, 116);
            this.btnEinde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(56, 19);
            this.btnEinde.TabIndex = 10;
            this.btnEinde.Text = "Einde";
            this.btnEinde.UseVisualStyleBackColor = false;
            // 
            // hsbSnelheid
            // 
            this.hsbSnelheid.Location = new System.Drawing.Point(16, 106);
            this.hsbSnelheid.Minimum = 1;
            this.hsbSnelheid.Name = "hsbSnelheid";
            this.hsbSnelheid.Size = new System.Drawing.Size(56, 10);
            this.hsbSnelheid.TabIndex = 9;
            this.hsbSnelheid.Value = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(14, 95);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Snelheid";
            // 
            // FrmNatSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(447, 311);
            this.Controls.Add(this.pnlKnoppen);
            this.Controls.Add(this.pbWereld);
            this.Controls.Add(this.lblInformatie);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.grbPLanten);
            this.Controls.Add(this.grbDieren);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmNatSim";
            this.Text = "Natuursimulatie";
            this.Load += new System.EventHandler(this.FrmNatSim_Load);
            this.grbDieren.ResumeLayout(false);
            this.grbDieren.PerformLayout();
            this.grbPLanten.ResumeLayout(false);
            this.grbPLanten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWereld)).EndInit();
            this.pnlKnoppen.ResumeLayout(false);
            this.pnlKnoppen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDieren;
        private System.Windows.Forms.RadioButton rdbKonijn;
        private System.Windows.Forms.RadioButton rdbKoe;
        private System.Windows.Forms.RadioButton rdbLynx;
        private System.Windows.Forms.RadioButton rdbBeer;
        private System.Windows.Forms.GroupBox grbPLanten;
        private System.Windows.Forms.RadioButton rdbVenijnboom;
        private System.Windows.Forms.RadioButton rbnGras;
        private System.Windows.Forms.CheckBox chbZaai;
        private System.Windows.Forms.RadioButton rbnVingerhoedskruit;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label lblInformatie;
        private System.Windows.Forms.PictureBox pbWereld;
        private System.Windows.Forms.Panel pnlKnoppen;
        private System.Windows.Forms.Button btnEinde;
        private System.Windows.Forms.HScrollBar hsbSnelheid;
        private System.Windows.Forms.Label Label2;
    }
}

