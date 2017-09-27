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
    public partial class FormSimulationChoix : Form
    {
        #region Variables membres

        private int _ChoixSimulation;

        #endregion

        #region Propriétés

        public int ChoixSimulation
        {
            get { return _ChoixSimulation; }
            set { _ChoixSimulation = value; }
        }

        #endregion

        #region Constructeurs

        public FormSimulationChoix()
        {
            InitializeComponent();
        }

        #endregion

        #region Evenements Boutons

        private void btMaisonSelectionnee_Click(object sender, EventArgs e)
        {
            ChoixSimulation = 1;
            this.Dispose();
        }

        private void btToutesLesMaisons_Click(object sender, EventArgs e)
        {
            ChoixSimulation = 2;
            this.Dispose();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            ChoixSimulation = 0;
            this.Dispose();
        }

        #endregion

    }
}
