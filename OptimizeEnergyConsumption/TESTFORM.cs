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
    public partial class TESTFORM : Form
    {
        private List<CAppliance> lApp;
        public TESTFORM()
        {
            InitializeComponent();
            lApp = new List<CAppliance>();
            test();
        }

        private void test()
        {
            CAppliance app1 = new CAppliance();
            CApplianceSleepMode app2 = new CApplianceSleepMode();
            lApp.Add(app1);
            lApp.Add(app2);

            foreach (CAppliance A in lApp)
            {
                MessageBox.Show(A.ToString());
            }
        }
    }
}
