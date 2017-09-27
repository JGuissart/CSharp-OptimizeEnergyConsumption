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
    public partial class FormPieceAjout : Form
    {
        #region Variables Membres

        private String _NomPiece;
        private bool _Valide;

        #endregion

        #region Propriétés

        public String NomPiece
        {
            get { return _NomPiece; }
            set { _NomPiece = value; }
        }

        public bool Valide
        {
            get { return _Valide; }
            set { _Valide = value; }
        }

        #endregion

        #region Constructeurs

        public FormPieceAjout()
        {
            InitializeComponent();
        }

        #endregion

        #region Evenements Boutons

        private void btValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNomPiece.Text))
                MessageBox.Show("Veuillez entrer le nom de la pièce !");
            else
            {
                Valide = true;
                NomPiece = tbNomPiece.Text;
                this.Dispose();
            }
        }

        #endregion
    }
}
