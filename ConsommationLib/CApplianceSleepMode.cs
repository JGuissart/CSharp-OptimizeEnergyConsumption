using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumptionLib
{
    public class CApplianceSleepMode : CAppliance
    {
        #region Variables Membres

        private double _ConsommationVeille;
        private CAutorisation _AutorisationVeille;

        #endregion

        #region Propriétés

        public double ConsommationVeille
        {
            get { return _ConsommationVeille; }
            set { _ConsommationVeille = value; }
        }

        public CAutorisation AutorisationVeille
        {
            get { return _AutorisationVeille; }
            set { _AutorisationVeille = value; }
        }

        #endregion

        #region Constructeurs

        public CApplianceSleepMode() : base()
        {
            ConsommationVeille = 0.0;
            AutorisationVeille = new CAutorisation();
        }

        public CApplianceSleepMode(String n, String M, String m, String ns, double cN, double cV, int t) : base(n, M, m, ns, cN, t)
        {
            ConsommationVeille = cV;
            AutorisationVeille = new CAutorisation();
        }

        #endregion

        #region Méthodes

        public override string ToString()
        {
            return base.ToString();
        }

        public override double ConsumeSleepMode(double prixWatt, int i)
        {
            System.Windows.Forms.MessageBox.Show("Appareil mode veille");
            if (AutorisationVeille.TabBool[i])
            {
                ConsommationJournaliere += ConsommationVeille;

                PrixConsommationJournaliereVeille += ConsommationVeille * prixWatt;

                return ConsommationVeille * prixWatt;
            }
            else
                return 0.0;
        }

        #endregion
    }
}
