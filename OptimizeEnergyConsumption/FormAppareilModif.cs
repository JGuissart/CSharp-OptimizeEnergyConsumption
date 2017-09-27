using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumptionLib;

namespace OptimizeEnergyConsumption
{
    public partial class FormAppareilModif : Form
    {
        #region Variables membres

        private CAppliance _Appareil;
        private CApplianceSleepMode _ASM;
        private bool _Valide;

        #endregion

        #region Propriétés

        public CAppliance Appareil
        {
            get { return _Appareil; }
            set { _Appareil = value; }
        }

        public CApplianceSleepMode ASM
        {
            get { return _ASM; }
            set { _ASM = value; }
        }

        public bool Valide
        {
            get { return _Valide; }
            set { _Valide = value; }
        }

        #endregion

        #region Constructeurs

        public FormAppareilModif()
        {
            InitializeComponent();
        }

        public FormAppareilModif(CAppliance app)
        {
            InitializeComponent();
            Appareil = app;
            ASM = null;

            tfNomAppareil.Text = app.NomAppareil;
            tfMarque.Text = app.Marque;
            tfModele.Text = app.Modele;
            tfNumeroSerie.Text = app.NumeroSerie;
            tfConsoNormale.Text = app.Consommation.ToString();

            lbConsoVeille.Visible = false;
            tfConsoVeille.Visible = false;

            int iTailleEnMoins = this.Size.Height - tfNomAppareil.Size.Height;
            this.Size = new Size(this.Size.Width, iTailleEnMoins);
            int iNouvelleCoordonneeY = btValider.Location.Y - tfNomAppareil.Size.Height;
            btValider.Location = new Point(btValider.Location.X, iNouvelleCoordonneeY);
            btAnnuler.Location = new Point(btAnnuler.Location.Y, iNouvelleCoordonneeY);
        }

        public FormAppareilModif(CApplianceSleepMode app)
        {
            InitializeComponent();
            ASM = app;
            Appareil = null;

            tfNomAppareil.Text = app.NomAppareil;
            tfMarque.Text = app.Marque;
            tfModele.Text = app.Modele;
            tfNumeroSerie.Text = app.NumeroSerie;
            tfConsoNormale.Text = app.Consommation.ToString();
            tfConsoVeille.Text = app.ConsommationVeille.ToString();
        }

        #endregion

        #region Evenements Boutons

        private void btValider_Click(object sender, EventArgs e)
        {
            try
            {
                VerificationChamps();

                if (Appareil != null)
                {
                    if (tfNomAppareil.Text != Appareil.NomAppareil)
                    {
                        Appareil.NomAppareil = tfNomAppareil.Text;
                        Valide = true;
                    }

                    if (tfMarque.Text != Appareil.Marque)
                    {
                        Appareil.Marque = tfMarque.Text;
                        Valide = true;
                    }

                    if (tfModele.Text != Appareil.Modele)
                    {
                        Appareil.Modele = tfModele.Text;
                        Valide = true;
                    }

                    if (tfNumeroSerie.Text != Appareil.NumeroSerie)
                    {
                        Appareil.NumeroSerie = tfNumeroSerie.Text;
                        Valide = true;
                    }

                    if (Appareil.Consommation != Convert.ToDouble(tfConsoNormale.Text))
                    {
                        Appareil.Consommation = Convert.ToDouble(tfConsoNormale.Text);
                        Valide = true;
                    }
                }
                else // On s'occupera à coup sûr d'un appareil avec un mode veille
                {
                    if (tfNomAppareil.Text != ASM.NomAppareil)
                    {
                        ASM.NomAppareil = tfNomAppareil.Text;
                        Valide = true;
                    }

                    if (tfMarque.Text != ASM.Marque)
                    {
                        ASM.Marque = tfMarque.Text;
                        Valide = true;
                    }

                    if (tfModele.Text != ASM.Modele)
                    {
                        ASM.Modele = tfModele.Text;
                        Valide = true;
                    }

                    if (tfNumeroSerie.Text != ASM.NumeroSerie)
                    {
                        ASM.NumeroSerie = tfNumeroSerie.Text;
                        Valide = true;
                    }

                    if (ASM.Consommation != Convert.ToDouble(tfConsoNormale.Text))
                    {
                        ASM.Consommation = Convert.ToDouble(tfConsoNormale.Text);
                        Valide = true;
                    }

                    if (ASM.ConsommationVeille != Convert.ToDouble(tfConsoVeille.Text))
                    {
                        ASM.ConsommationVeille = Convert.ToDouble(tfConsoVeille.Text);
                        Valide = true;
                    }
                }

                this.Dispose();
            }
            catch (NullOrEmptyStringException ex)
            {
                MessageBox.Show("Exception levée: " + ex.Message);
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion

        #region Méthode

        public void VerificationChamps()
        {
            if (string.IsNullOrEmpty(tfNomAppareil.Text) || string.IsNullOrWhiteSpace(tfNomAppareil.Text))
                throw new NullOrEmptyStringException("Le champs \"Nom de l'appareil\" est vide");

            if (string.IsNullOrEmpty(tfMarque.Text) || string.IsNullOrWhiteSpace(tfMarque.Text))
                throw new NullOrEmptyStringException("Le champs \"Marque\" est vide");

            if (string.IsNullOrEmpty(tfModele.Text) || string.IsNullOrWhiteSpace(tfModele.Text))
                throw new NullOrEmptyStringException("Le champs \"Modèle\" est vide");

            if (string.IsNullOrEmpty(tfNumeroSerie.Text) || string.IsNullOrWhiteSpace(tfNumeroSerie.Text))
                throw new NullOrEmptyStringException("Le champs \"Numéro de série\" est vide");

            if (string.IsNullOrEmpty(tfConsoNormale.Text) || string.IsNullOrWhiteSpace(tfConsoNormale.Text))
                throw new NullOrEmptyStringException("Le champs \"Consommation normale\" est vide");

            if (tfConsoVeille.Visible)
                if (string.IsNullOrEmpty(tfConsoVeille.Text) || string.IsNullOrWhiteSpace(tfConsoVeille.Text))
                    throw new NullOrEmptyStringException("Le champs \"Consommation en veille\" est vide");
        }

        #endregion
    }
}
