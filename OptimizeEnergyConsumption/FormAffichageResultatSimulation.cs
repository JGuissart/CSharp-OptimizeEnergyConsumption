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
    public partial class FormAffichageResultatSimulation : Form
    {
        #region Variables membres

        private CHouse _Maison;
        private List<CHouse> _ListeMaison;
        private double _ResultatConsommationAppareil;
        private double _ResultatConsommationAppareilVeille;

        #endregion

        #region Propriétés

        public CHouse Maison
        {
            get { return _Maison; }
            set { _Maison = value; }
        }

        public List<CHouse> ListeMaison
        {
            get { return _ListeMaison; }
            set { _ListeMaison = value; }
        }

        public double ResultatConsommationAppareil
        {
            get { return _ResultatConsommationAppareil; }
            set { _ResultatConsommationAppareil = value; }
        }

        public double ResultatConsommationAppareilVeille
        {
            get { return _ResultatConsommationAppareilVeille; }
            set { _ResultatConsommationAppareilVeille = value; }
        }

        #endregion

        #region Constructeurs

        public FormAffichageResultatSimulation()
        {
            InitializeComponent();
        }

        public FormAffichageResultatSimulation(CHouse MaisonSelectionnee, double consoNormale, double consoVeille)
        {
            InitializeComponent();

            Maison = MaisonSelectionnee;
            ResultatConsommationAppareil = consoNormale;
            ResultatConsommationAppareilVeille = consoVeille;

            remplirListBox(Maison);

            double consoMaisonJour = Maison.ConsommationJournaliere / 1000;
            double consoMaisonHebdo = consoMaisonJour * 7;
            double consoMaisonMens = consoMaisonJour * 30;
            double consoMaisonAnn = consoMaisonJour * 365;

            lbAfficheConsoMaison.Text = consoMaisonJour.ToString() + " / " + consoMaisonHebdo.ToString() + " / " + consoMaisonMens.ToString() + " / " + consoMaisonAnn.ToString() + "   kW/h";

            double prixMaisonHebdo = Math.Round(Maison.PrixJournalier * 7, 2);
            double prixMaisonMens = Math.Round(Maison.PrixJournalier * 30, 2);
            double prixMaisonAnn = Math.Round(Maison.PrixJournalier * 365, 2);

            lbAffichePrixMaison.Text = Maison.PrixJournalier.ToString() + " / " + prixMaisonHebdo.ToString() + " / " + prixMaisonMens.ToString() + " / " + prixMaisonAnn.ToString() + "   €";

            double consoMoyenneEtageJour = consommationMoyenneEtage(Maison) / 1000;
            double consoEtageHebdo = consoMoyenneEtageJour * 7;
            double consoEtageMens = consoMoyenneEtageJour * 30;
            double consoEtageAnn = consoMoyenneEtageJour * 365;

            lbAfficheConsoEtage.Text = consoMoyenneEtageJour.ToString() + " / " + consoEtageHebdo.ToString() + " / " + consoEtageMens.ToString() + " / " + consoEtageAnn.ToString() + "    kW/h";

            double prixWattHeureMoyen = (0.07366 + 0.0484) / 2;

            double prixEtageJour = Math.Round(consoMoyenneEtageJour * prixWattHeureMoyen, 2);
            double prixEtageHebdo = prixEtageJour * 7;
            double prixEtageMens = prixEtageJour * 30;
            double prixEtageAnn = prixEtageJour * 365;

            lbAffichePrixEtage.Text = prixEtageJour.ToString() + " / " + prixEtageHebdo.ToString() + " / " + prixEtageMens.ToString() + " / " + prixEtageAnn.ToString() + "    €";

            double consoMoyennePieceJour = consommationMoyennePiece(Maison) / 1000;
            double consoPieceHebdo = consoMoyennePieceJour * 7;
            double consoPieceMens = consoMoyennePieceJour * 30;
            double consoPieceAnn = consoMoyennePieceJour * 365;

            lbAfficheConsoPiece.Text = consoMoyennePieceJour.ToString() + " / " + consoPieceHebdo.ToString() + " / " + consoPieceMens.ToString() + " / " + consoPieceAnn.ToString() + "    kW/h";

            double prixPieceJour = Math.Round(consoMoyennePieceJour * prixWattHeureMoyen, 2);
            double prixPieceHebdo = prixPieceJour * 7;
            double prixPieceMens = prixPieceJour * 30;
            double prixPieceAnn = prixPieceJour * 365;

            lbAffichePrixPiece.Text = prixPieceJour.ToString() + " / " + prixPieceHebdo.ToString() + " / " + prixPieceMens.ToString() + " / " + prixPieceAnn.ToString() + "    €";
        }

        public FormAffichageResultatSimulation(List<CHouse> lMaison, double consoNormale, double consoVeille)
        {
            InitializeComponent();

            ListeMaison = lMaison;
            ResultatConsommationAppareil = consoNormale;
            ResultatConsommationAppareilVeille = consoVeille;

            remplirListBox(ListeMaison);
        }

        #endregion

        #region Evenements Boutons

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion

        #region Evenements listBox

        private void listBoxAppareil_SelectedIndexChanged(object sender, EventArgs e)
        {
            CAppliance appTemp = (CAppliance)listBoxAppareil.SelectedItem;

            double consoAppareilJour = appTemp.ConsommationJournaliere / 1000;
            double consoAppareilHebdo = consoAppareilJour * 7;
            double consoAppareilMens = consoAppareilJour * 30;
            double consoAppareilAnn = consoAppareilJour * 365;

            lbAfficheConsoAppareil.Text = consoAppareilJour.ToString() + " / " + consoAppareilHebdo.ToString() + " / " + consoAppareilMens.ToString() + " / " + consoAppareilAnn.ToString() + "    kW/h";

            double prixAppareilJour = Math.Round(appTemp.PrixConsommationJournaliere + appTemp.PrixConsommationJournaliereVeille, 2);
            double prixAppareilHebdo = prixAppareilJour * 7;
            double prixAppareilMens = prixAppareilJour * 30;
            double prixAppareilAnn = prixAppareilJour * 365;

            lbAffichePrixAppareil.Text = prixAppareilJour.ToString() + " / " + prixAppareilHebdo.ToString() + " / " + prixAppareilMens.ToString() + " / " + prixAppareilAnn.ToString() + "    €";

            if (lbAffichePrixAppareil.Visible == false)
            {
                lbAfficheConsoAppareil.Visible = true;
                lbAffichePrixAppareil.Visible = true;
                lbConsommationAppareil.Visible = true;
                lbPrixConsoAppareil.Visible = true;
            }
        }

        #endregion

        #region Méthodes

        private void remplirListBox(CHouse M)
        {
            foreach (CFloor E in M.ListeEtage)
            {
                foreach (CRoom P in E.ListePiece)
                {
                    foreach (IConsumable A in P.ListeApp)
                    {
                        listBoxAppareil.Items.Add(A);
                    }
                }
            }
        }

        private void remplirListBox(List<CHouse> lMaison)
        {
            foreach (CHouse M in lMaison)
            {
                foreach (CFloor E in M.ListeEtage)
                {
                    foreach (CRoom P in E.ListePiece)
                    {
                        foreach (IConsumable A in P.ListeApp)
                        {
                            listBoxAppareil.Items.Add(A);
                        }
                    }
                }
            }
        }

        private double consommationMoyenneEtage(CHouse M)
        {
            int iNombreEtages = 0;

            foreach (CFloor E in M.ListeEtage)
            {
                foreach (CRoom P in E.ListePiece)
                {
                    if (P.ListeApp.Count > 0)
                        iNombreEtages++;
                }
            
            }

            double[] tabTemp = new double[iNombreEtages];

            for (int i = 0; i < iNombreEtages; i++)
                tabTemp[i] = 0.0;

            for (int i = 0; i < iNombreEtages; i++)
            {
                foreach (CFloor E in M.ListeEtage)
                {
                    foreach (CRoom P in E.ListePiece)
                    {
                        if (P.ListeApp.Count > 0)
                        {
                            foreach (CAppliance A in P.ListeApp)
                            {
                                tabTemp[i] += A.ConsommationJournaliere;
                            }
                        }
                    }
                }
            }

            double dMoyenne = 0.0;

            foreach (double D in tabTemp)
            {
                dMoyenne += D;
            }

            return dMoyenne / M.ListeEtage.Count;
        }

        private double consommationMoyennePiece(CHouse M)
        {
            int iNombrePieces = 0;

            foreach (CFloor E in M.ListeEtage)
            {
                foreach (CRoom P in E.ListePiece)
                {
                    if (P.ListeApp.Count > 0)
                        iNombrePieces++;
                }
            }

            double[] tabTemp = new double[iNombrePieces];

            for (int i = 0; i < tabTemp.Length; i++)
                tabTemp[i] = 0.0;

            int j = 0;

            while (j < iNombrePieces)
            {
                foreach (CFloor E in M.ListeEtage)
                {
                    foreach (CRoom P in E.ListePiece)
                    {
                        if (P.ListeApp.Count > 0)
                        {
                            foreach (CAppliance A in P.ListeApp)
                            {
                                tabTemp[j] += A.ConsommationJournaliere;
                            }
                            j++;
                        }
                    }
                }
            }

            double dMoyenne = 0.0;

            foreach (double D in tabTemp)
            {
                dMoyenne += D;
            }

            return dMoyenne / iNombrePieces;
        }

        #endregion        
    }
}
