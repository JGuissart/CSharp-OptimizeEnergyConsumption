using ConsumptionLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimizeEnergyConsumption
{
    public partial class FormAppareilAjoutHeure : Form
    {
        #region Variables membres

        private bool _HeureMarcheFin;
        private bool _HeureVeilleFin;
        private bool _Valide;
        private List<String> _ListeHeureMarche;
        private List<String> _ListeHeureVeille;
        private CAppliance _Appareil;
        private CApplianceSleepMode _AppareilVeille;

        #endregion

        #region Propriétés

        public bool HeureMarcheFin
        {
            get { return _HeureMarcheFin; }
            set { _HeureMarcheFin = value; }
        }

        public bool HeureVeilleFin
        {
            get { return _HeureVeilleFin; }
            set { _HeureVeilleFin = value; }
        }

        public bool Valide
        {
            get { return _Valide; }
            set { _Valide = value; }
        }

        public List<String> ListeHeureMarche
        {
            get { return _ListeHeureMarche; }
            set { _ListeHeureMarche = value; }
        }

        public List<String> ListeHeureVeille
        {
            get { return _ListeHeureVeille; }
            set { _ListeHeureVeille = value; }
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

        public FormAppareilAjoutHeure()
        {
            InitializeComponent();
            initialiserComboBoxes();
        }

        public FormAppareilAjoutHeure(CAppliance app)
        {
            InitializeComponent();
            initialiserComboBoxes();
            Appareil = app;
            AppareilVeille = null;
            btAjoutHeureVeille.Enabled = false;
            listBoxHeureVeille.Enabled = false;
            cbHeureDebutVeille.Enabled = false;
            cbHeureFinVeille.Enabled = false;

            ListeHeureMarche = new List<string>();
            ListeHeureVeille = new List<string>();
        }

        public FormAppareilAjoutHeure(CApplianceSleepMode app)
        {
            InitializeComponent();
            initialiserComboBoxes();
            AppareilVeille = app;
            Appareil = null;

            ListeHeureMarche = new List<string>();
            ListeHeureVeille = new List<string>();
        }

        #endregion

        #region Evenements Boutons

        private void btAjoutHeureMarche_Click(object sender, EventArgs e)
        {
            String heure;

            if (HeureMarcheFin)
                heure = (String)cbHeureDebutMarche.SelectedItem + "-" + (String)cbHeureFinMarche.SelectedItem;
            else
            {
                heure = (String)cbHeureDebutMarche.SelectedItem;
                cbHeureDebutMarche.Enabled = false;
                cbHeureFinMarche.Enabled = false;
            }

            if (!listBoxHeureMarche.Items.Contains(heure))
            {
                listBoxHeureMarche.Items.Add(heure);
                HeureMarcheFin = false;
            }
            else
                MessageBox.Show("L'heure spécifiée est déjà dans la liste !");
        }

        private void btAjoutHeureVeille_Click(object sender, EventArgs e)
        {
            String heure;

            if (HeureVeilleFin)
                heure = (String)cbHeureDebutVeille.SelectedItem + "-" + (String)cbHeureFinVeille.SelectedItem;
            else
            {
                heure = (String)cbHeureDebutVeille.SelectedItem;
                cbHeureDebutVeille.Enabled = false;
                cbHeureFinVeille.Enabled = false;
            }

            if (!listBoxHeureVeille.Items.Contains(heure))
            {
                listBoxHeureVeille.Items.Add(heure);
                HeureVeilleFin = false;
            }
            else
                MessageBox.Show("L'heure spécifiée est déjà dans la liste !");
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (listBoxHeureMarche.Items.Count > 0)
            {
                foreach (String S in listBoxHeureMarche.Items)
                {
                    ListeHeureMarche.Add(S);
                }

                Valide = true;
            }

            if (AppareilVeille != null)
            {
                if (listBoxHeureVeille.Items.Count > 0)
                {
                    foreach (String S in listBoxHeureVeille.Items)
                    {
                        ListeHeureVeille.Add(S);
                    }
                }
                else
                    Valide = false;
            }

            if (Valide)
            {
                if (Appareil != null)
                {
                    foreach (String S in ListeHeureMarche)
                    {
                        Appareil.Autorisation[S] = true;
                    }
                }
                else
                {
                    foreach (String S in ListeHeureMarche)
                    {
                        AppareilVeille.Autorisation[S] = true;
                    }

                    foreach (String S in ListeHeureVeille)
                    {
                        AppareilVeille.AutorisationVeille[S] = true;
                    }

                    
                }
                this.Dispose();
            }
            else
                MessageBox.Show("Une des 2 listes est vides alors qu'elle ne devrait pas ...");
        }

        #endregion

        #region Evenements ComboBox

        private void cbHeureFinMarche_SelectedIndexChanged(object sender, EventArgs e)
        {
            HeureMarcheFin = true;
        }

        private void cbHeureFinVeille_SelectedIndexChanged(object sender, EventArgs e)
        {
            HeureVeilleFin = true;
        }

        #endregion

        #region Méthodes

        private void initialiserComboBoxes()
        {
            for (int i = 0; i < 24; i++)
            {
                cbHeureDebutMarche.Items.Add(i.ToString() + "h");
                cbHeureFinMarche.Items.Add(i.ToString() + "h");
                cbHeureDebutVeille.Items.Add(i.ToString() + "h");
                cbHeureFinVeille.Items.Add(i.ToString() + "h");

                cbHeureDebutMarche.Items.Add(i.ToString() + "h30");
                cbHeureFinMarche.Items.Add(i.ToString() + "h30");
                cbHeureDebutVeille.Items.Add(i.ToString() + "h30");
                cbHeureFinVeille.Items.Add(i.ToString() + "h30");
            }
        }

        #endregion
    }
}
