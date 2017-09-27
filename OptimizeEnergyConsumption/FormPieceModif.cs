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
    public partial class FormPieceModif : Form
    {
        #region Variables membres

        private bool _Valider;
        private string NomActuel;
        private string _NouveauNom;

        #endregion

        #region Propriétés

        public bool Valider
        {
            get { return _Valider; }
            set { _Valider = value; }
        }

        public string NouveauNom
        {
            get { return _NouveauNom; }
            set { _NouveauNom = value; }
        }

        #endregion

        #region Constructeurs

        public FormPieceModif()
        {
            InitializeComponent();
        }

        public FormPieceModif(string nomPiece)
        {
            InitializeComponent();

            tfNomPiece.Text = nomPiece;
            NomActuel = nomPiece;
        }

        #endregion

        #region Evenements Boutons

        private void btValider_Click(object sender, EventArgs e)
        {
            if (NomActuel != tfNomPiece.Text)
            {
                NouveauNom = tfNomPiece.Text;
                Valider = true;
            }

            this.Dispose();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion
    }
}
