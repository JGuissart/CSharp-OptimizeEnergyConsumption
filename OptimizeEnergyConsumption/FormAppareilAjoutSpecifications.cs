using ConsumptionLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimizeEnergyConsumption
{
    public partial class FormAppareilAjoutSpecifications : Form
    {
        #region Variables membres

        private bool _Valide;
        private bool _AppareilEnVeille;
        private CAppliance _Appareil;
        private CApplianceSleepMode _AppareilVeille;

        #endregion

        #region Propriétés

        public bool Valide
        {
            get { return _Valide; }
            set { _Valide = value; }
        }

        public bool AppareilEnVeille
        {
            get { return _AppareilEnVeille; }
            set { _AppareilEnVeille = value; }
        }

        public CAppliance Appareil
        {
            get { return _Appareil; }
            set { _Appareil = value; }
        }

        public CApplianceSleepMode AppareilVeille
        {
            get { return _AppareilVeille; }
            set { _AppareilVeille = value; }
        }

        #endregion

        #region Constructeurs

        public FormAppareilAjoutSpecifications()
        {
            InitializeComponent();

            DialogResult dr = MessageBox.Show("Voulez-vous créer un appareil avec un mode veille ?", "Spécification de l'appareil", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                AppareilEnVeille = true;
                tfConsoVeille.Enabled = true;
                lbConsoVeille.Enabled = true;
            }
        }

        #endregion

        #region Evenements Boutons

        private void btValider_Click(object sender, EventArgs e)
        {
            try
            {
                Valide = true;

                verificationChamps();

                if (AppareilEnVeille)
                {
                    // Les consommations sont divisées par 2 car on parcourt des plages de 30 mins !!!!
                    AppareilVeille = new CApplianceSleepMode(tfNomAppareil.Text, tfMarque.Text, tfModele.Text, tfNumeroSerie.Text, Convert.ToDouble(tfConsoNormale.Text) / 2, Convert.ToDouble(tfConsoVeille.Text) / 2, cbType.SelectedIndex);
                    FormAppareilAjoutHeure FAAH = new FormAppareilAjoutHeure(AppareilVeille);
                    FAAH.ShowDialog();
                }
                else
                {
                    // Les consommations sont divisées par 2 car on parcourt des plages de 30 mins !!!!
                    Appareil = new CAppliance(tfNomAppareil.Text, tfMarque.Text, tfModele.Text, tfNumeroSerie.Text, Convert.ToDouble(tfConsoNormale.Text) / 2, cbType.SelectedIndex);
                    FormAppareilAjoutHeure FAAH = new FormAppareilAjoutHeure(Appareil);
                    FAAH.ShowDialog();
                }
                
                this.Dispose();
            }
            catch (NullOrEmptyStringException ex)
            {
                Valide = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous quittez la création d'un appareil ! Celui-ci ne sera pas enregistré !");
            this.Dispose();
        }

        private void btReinit_Click(object sender, EventArgs e)
        {
            cbType.SelectedItem = null;
            tfNomAppareil.Text = null;
            tfMarque.Text = null;
            tfModele.Text = null;
            tfNumeroSerie.Text = null;
            tfConsoNormale.Text = null;
            tfConsoVeille.Text = null;
        }

        #endregion

        #region Evenements TextBox

        private void tfNomAppareil_TextChanged(object sender, EventArgs e)
        {
            if (tfNomAppareil.Text != "")
            {
                String currentUser = Environment.UserName;
                pbVNom.Image = Image.FromFile(@"C:\Users\" + currentUser + @"\Mes documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\Images\Icones\V.png");
            }
            else
                pbVNom.Image = null;
        }

        private void tfMarque_TextChanged(object sender, EventArgs e)
        {
            if (tfMarque.Text != "")
            {
                String currentUser = Environment.UserName;
                pbVMarque.Image = Image.FromFile(@"C:\Users\" + currentUser + @"\Mes documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\Images\Icones\V.png");
            }
            else
                pbVMarque.Image = null;
        }

        private void tfModele_TextChanged(object sender, EventArgs e)
        {
            if (tfModele.Text != "")
            {
                String currentUser = Environment.UserName;
                pbVModele.Image = Image.FromFile(@"C:\Users\" + currentUser + @"\Mes documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\Images\Icones\V.png");
            }
            else
                pbVModele.Image = null;
        }

        private void tfNumeroSerie_TextChanged(object sender, EventArgs e)
        {
            if (tfNumeroSerie.Text != "")
            {
                String currentUser = Environment.UserName;
                pbVNum.Image = Image.FromFile(@"C:\Users\" + currentUser + @"\Mes documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\Images\Icones\V.png");
            }
            else
                pbVNum.Image = null;
        }

        private void tfConsoNormale_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double dConsoNormale = Convert.ToDouble(tfConsoNormale.Text);
                String currentUser = Environment.UserName;
                pbVConsoN.Image = Image.FromFile(@"C:\Users\" + currentUser + @"\Mes documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\Images\Icones\V.png");
            }
            catch (FormatException)
            {
                if (!tfConsoNormale.Text.Equals(""))
                    MessageBox.Show("Le format entré ne correspond pas !");
                pbVConsoN.Image = null;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Le numéro entré est trop grand ...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbVConsoN.Image = null;
            }
        }

        private void tfConsoVeille_TextChanged(object sender, EventArgs e)
        {
            if (tfConsoVeille.Enabled)
            {
                try
                {
                    double dConsoNormale = Convert.ToDouble(tfConsoVeille.Text);
                    String currentUser = Environment.UserName;
                    pbVConsoV.Image = Image.FromFile(@"C:\Users\" + currentUser + @"\Mes documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\Images\Icones\V.png");
                }
                catch (FormatException)
                {
                    if (!tfConsoVeille.Text.Equals(""))
                        MessageBox.Show("Le format entré ne correspond pas !");

                    pbVConsoV.Image = null;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Le numéro entré est trop grand ...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbVConsoV.Image = null;
                }
            }
        }

        #endregion

        #region Evenements ComboBox

        private void cbType_TextChanged(object sender, EventArgs e)
        {
            if (cbType.Text != "")
            {
                String currentUser = Environment.UserName;
                pbVType.Image = Image.FromFile(@"C:\Users\" + currentUser + @"\Mes documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\Images\Icones\V.png");
            }
            else
                pbVType.Image = null;
        }

        #endregion

        #region Méthodes

        private void verificationChamps()
        {
            if (string.IsNullOrEmpty(tfNomAppareil.Text) || string.IsNullOrEmpty(tfMarque.Text) || string.IsNullOrEmpty(tfModele.Text) || string.IsNullOrEmpty(tfNumeroSerie.Text) || string.IsNullOrEmpty(tfConsoNormale.Text))
                throw new NullOrEmptyStringException("Vous devez remplir tous les champs !");

            if (tfConsoVeille.Enabled)
            {
                if (string.IsNullOrEmpty(tfConsoVeille.Text))
                    throw new NullOrEmptyStringException("Vous devez remplir tous les champs !");
            }
        }

        #endregion
    }
}
