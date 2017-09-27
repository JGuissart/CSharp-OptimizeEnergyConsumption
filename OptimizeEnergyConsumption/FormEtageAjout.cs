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
    public partial class FormEtageAjout : Form
    {
        #region Variables membres

        private bool _Valide;
        private int _NombreEtages;

        #endregion

        #region Propriétés

        public bool Valide
        {
            get { return _Valide; }
            set { _Valide = value; }
        }

        public int NombreEtages
        {
            get { return _NombreEtages; }
            set { _NombreEtages = value; }
        }

        #endregion

        #region Constructeurs

        public FormEtageAjout()
        {
            InitializeComponent();

            for (int i = 1; i <= 10; i++)
                cbNombreEtages.Items.Add(i);

            NombreEtages = 0;
        }

        #endregion

        #region Evenements Boutons

        private void btValider_Click(object sender, EventArgs e)
        {
            try
            {
                NombreEtages = (int)cbNombreEtages.SelectedItem;
                Valide = true;
                this.Dispose();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Veuillez choisir un nombre d'étages à ajouter !");
            }
        }

        #endregion
    }
}
