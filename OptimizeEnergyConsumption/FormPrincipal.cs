using ConsumptionLib;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OptimizeEnergyConsumption
{
    public partial class FormPrincipal : Form
    {
        #region Variables membres

        private CUser _UserCo;
        private CHouse _MaisonSelectionnee;
        private CFloor _EtageSelectionne;
        private CRoom _PieceSelectionnee;
        private CAppliance _AppareilSelectionne;

        private Point _PositionMouseDown;
        private Point _PositionMouseUp;

        private bool _AjoutPiece;
        private bool _AjoutAppareil;
        private bool _MouseClic;

        private Bitmap _BitmapTemp;

        private RegistryKey _Reg;

        private int _IndiceSimulation;
        private double _PrixWattHeureJournee;
        private double _PrixWattHeureNuit;
        private int _ChoixSimulation;

        #endregion

        #region Propriétés

        public CUser UserCo
        {
            get { return _UserCo; }
            set { _UserCo = value; }
        }

        public CHouse MaisonSelectionnee
        {
            get { return _MaisonSelectionnee; }
            set { _MaisonSelectionnee = value; }
        }

        public CFloor EtageSelectionne
        {
            get { return _EtageSelectionne; }
            set { _EtageSelectionne = value; }
        }

        public CRoom PieceSelectionnee
        {
            get { return _PieceSelectionnee; }
            set { _PieceSelectionnee = value; }
        }

        public CAppliance AppareilSelectionne
        {
            get { return _AppareilSelectionne; }
            set { _AppareilSelectionne = value; }
        }


        public Point PositionMouseDown
        {
            get { return _PositionMouseDown; }
            set { _PositionMouseDown = value; }
        }

        public Point PositionMouseUp
        {
            get { return _PositionMouseUp; }
            set { _PositionMouseUp = value; }
        }


        public bool AjoutPiece
        {
            get { return _AjoutPiece; }
            set { _AjoutPiece = value; }
        }

        public bool AjoutAppareil
        {
            get { return _AjoutAppareil; }
            set { _AjoutAppareil = value; }
        }

        public bool MouseClic
        {
            get { return _MouseClic; }
            set { _MouseClic = value; }
        }


        public Bitmap BitmapTemp
        {
            get { return _BitmapTemp; }
            set { _BitmapTemp = value; }
        }


        public RegistryKey Reg
        {
            get { return _Reg; }
            set { _Reg = value; }
        }

        public int IndiceSimulation
        {
            get { return _IndiceSimulation; }
            set { _IndiceSimulation = value; }
        }

        public double PrixWattHeureJournee
        {
            get { return _PrixWattHeureJournee; }
            set { _PrixWattHeureJournee = value; }
        }

        public double PrixWattHeureNuit
        {
            get { return _PrixWattHeureNuit; }
            set { _PrixWattHeureNuit = value; }
        }

        public int ChoixSimulation
        {
            get { return _ChoixSimulation; }
            set { _ChoixSimulation = value; }
        }

        #endregion

        #region Constructeurs

        public FormPrincipal()
        {
            InitializeComponent();
            pbDessin.Image = new Bitmap(pbDessin.Size.Width, pbDessin.Size.Height, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(pbDessin.Image);
            g.Clear(Color.White);
            g.Dispose();
            pbDessin.Refresh();
            //remplirListBoxAppareil();

            pbAppareil.Image = new Bitmap(pbAppareil.Size.Width, pbAppareil.Size.Height, PixelFormat.Format24bppRgb);
            Graphics gapp = Graphics.FromImage(pbAppareil.Image);
            gapp.Clear(Color.White);
            gapp.Dispose();
            pbAppareil.Refresh();
        }

        public FormPrincipal(CUser UserConnecte)
        {
            InitializeComponent();

            UserCo = UserConnecte;
            this.Text = "Optimize Energy Consumption - Utilisateur : " + UserCo.Login;

            remplirListBoxAppareil(); // Méthodes qui va récupérer toutes les images d'appareils contenues dans un registre et les placer dans la listBox

            Reg = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("HEPL", true).OpenSubKey("User Data", true);

            /******************* Récupération fichier UserConnecte *****************/

            XmlSerializer xml = new XmlSerializer(typeof(List<CHouse>));
            String sPathXmlFile = (String)Reg.GetValue(UserCo.Login, "Chemin inexistant");

            if (File.Exists(sPathXmlFile))
            {
                StreamReader sR = new StreamReader(sPathXmlFile);
                UserCo.ListeMaison = (List<CHouse>)xml.Deserialize(sR);
                sR.Close();
                remplirTreeView();
            }

            /******************* Initialisation des pictureBox *****************/

            pbDessin.Image = new Bitmap(pbDessin.Size.Width, pbDessin.Size.Height, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(pbDessin.Image);
            g.Clear(Color.White);
            g.Dispose();
            pbDessin.Refresh();

            pbAppareil.Image = new Bitmap(pbAppareil.Size.Width, pbAppareil.Size.Height, PixelFormat.Format24bppRgb);
            Graphics gapp = Graphics.FromImage(pbAppareil.Image);
            gapp.Clear(Color.White);
            gapp.Dispose();
            pbAppareil.Refresh();

            listBoxAppareil.Enabled = false;

            MaisonSelectionnee = new CHouse();
            EtageSelectionne = new CFloor();
            PieceSelectionnee = new CRoom();
            AppareilSelectionne = new CAppliance();

            /******************* Configuration de la progressBar *****************/
            progressBarSimulation.Maximum = 100;
            progressBarSimulation.Minimum = 0;
            progressBarSimulation.Step = progressBarSimulation.Maximum / 48;

            /******************* Configuration des variables servant à la simulation *****************/
            IndiceSimulation = 0;
            PrixWattHeureJournee = 0.07366;
            PrixWattHeureNuit = 0.0484;
            ChoixSimulation = 0;
        }

        #endregion

        #region Evenements MenuStrip

        /************************** Maison **************************/

        private void msAjouterMaison_Click(object sender, EventArgs e)
        {
            FormMaisonAjout FMA = new FormMaisonAjout();
            FMA.ShowDialog();

            if (FMA.Valide)
            {
                int iNumMaison = UserCo.ListeMaison.Count + 1;
                treeView.Nodes.Add("Maison " + iNumMaison.ToString());
                FMA.Maison.IDMaison = "Maison " + iNumMaison.ToString();
                UserCo.ListeMaison.Add(FMA.Maison);
            }
        }

        private void msModifierMaison_Click(object sender, EventArgs e)
        {
            FormMaisonModif FMM = new FormMaisonModif(MaisonSelectionnee.Adresse);
            FMM.ShowDialog();

            if (FMM.Valider)
                MaisonSelectionnee.Adresse = FMM.AdresseModifiee;
        } // Plantage niveau SQL

        private void msSupprimerMaison_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment supprimer cette maison ?", "Suppression d'une maison", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                UserCo.ListeMaison.Remove(MaisonSelectionnee);
                //if (treeView.SelectedNode.Text.Contains("Maison"))
                //    treeView.SelectedNode.Remove();
                treeView.Nodes.Clear();
                if (UserCo.ListeMaison.Count > 0)
                    remplirTreeView();

                msAjouterPiece.Enabled = false;
                msModifierPiece.Enabled = false;
                msSupprimerPiece.Enabled = false;
                msAjouterEtage.Enabled = false;
                msSupprimerEtage.Enabled = false;
                msAjouterAppareil.Enabled = false;
                msModifierAppareil.Enabled = false;
                msSupprimerAppareil.Enabled = false;

                MaisonSelectionnee = new CHouse();
                EtageSelectionne = new CFloor();
                PieceSelectionnee = new CRoom();
                AppareilSelectionne = new CAppliance();
            }
        }

        /************************** Etages **************************/

        private void msAjouterEtage_Click(object sender, EventArgs e)
        {
            FormEtageAjout FEA = new FormEtageAjout();
            FEA.ShowDialog();

            if (FEA.Valide) // Vérifier avec nombreEtages dans FEA (optimisation)
            {
                int iNbreEtage;
                iNbreEtage = MaisonSelectionnee.ListeEtage.Count;
                for (int i = iNbreEtage; i < iNbreEtage + FEA.NombreEtages; i++)
                {
                    CFloor NewEtage = new CFloor();

                    if (i > 0)
                    {
                        treeView.SelectedNode.Nodes.Add("Etage" + (i).ToString());
                        NewEtage.NomEtage = "Etage" + (i).ToString();
                    }
                    else
                    {
                        treeView.SelectedNode.Nodes.Add("Rez-de-chaussée");
                        NewEtage.NomEtage = "Rez-de-chaussée";
                    }

                    MaisonSelectionnee.ListeEtage.Add(NewEtage);
                }
            }
        }

        private void msSupprimerEtage_Click(object sender, EventArgs e)
        {
            if (EtageSelectionne != null)
            {
                DialogResult DR = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet étage ?", "Suppression d'étage", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (DR == DialogResult.Yes)
                {
                    if (treeView.SelectedNode.Text.Contains("Rez-de-chaussée") || treeView.SelectedNode.Text.Contains("Etage"))
                    {
                        bool bSuppEtage = false;
                        CFloor EtageASupprimer = new CFloor();
                        foreach (CFloor E in MaisonSelectionnee.ListeEtage)
                        {
                            if (treeView.SelectedNode.Text == E.NomEtage)
                            {
                                bSuppEtage = true;
                                EtageASupprimer = E;
                            }
                        }
                        if (bSuppEtage)
                        {
                            MaisonSelectionnee.ListeEtage.Remove(EtageASupprimer);

                            if (MaisonSelectionnee.ListeEtage.Count > 0)
                            {
                                treeView.Nodes.Clear();
                                remplirTreeView();
                            }
                            else
                                treeView.SelectedNode.Remove();

                            msAjouterPiece.Enabled = false;
                            msModifierPiece.Enabled = false;
                            msSupprimerPiece.Enabled = false;
                            msSupprimerEtage.Enabled = false;
                            msAjouterAppareil.Enabled = false;
                            msModifierAppareil.Enabled = false;
                            msSupprimerAppareil.Enabled = false;

                            EtageSelectionne = new CFloor();
                            PieceSelectionnee = new CRoom();
                            AppareilSelectionne = new CAppliance();
                        }
                    }

                }
            }
        }

        /************************** Pieces **************************/

        private void msAjouterPiece_Click(object sender, EventArgs e)
        {
            AjoutPiece = true;
        }

        private void msModifierPiece_Click(object sender, EventArgs e)
        {
            FormPieceModif FPM = new FormPieceModif(PieceSelectionnee.NomPiece);
            FPM.ShowDialog();

            if (FPM.Valider)
            {
                foreach (CFloor E in MaisonSelectionnee.ListeEtage)
                {
                    foreach (CRoom P in E.ListePiece)
                    {
                        if (P.NomPiece == PieceSelectionnee.NomPiece)
                        {
                            P.NomPiece = FPM.NouveauNom;
                            PieceSelectionnee = null;
                            PieceSelectionnee = P;
                            treeView.Nodes.Clear();
                            remplirTreeView();
                            break;
                        }
                    }
                }
            }
        }

        private void msSupprimerPiece_Click(object sender, EventArgs e)
        {
            if (PieceSelectionnee != null)
            {
                DialogResult DR = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet pièce ?", "Suppression d'une pièce", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (DR == DialogResult.Yes)
                {
                    if (treeView.SelectedNode.Parent.Text.Contains("Rez-de-chaussée") || treeView.SelectedNode.Parent.Text.Contains("Etage"))
                    {
                        bool bSuppPiece = false;
                        CRoom PieceASupprimer = new CRoom();

                        foreach (CRoom P in EtageSelectionne.ListePiece)
                        {
                            if (treeView.SelectedNode.Text == P.NomPiece)
                            {
                                bSuppPiece = true;
                                PieceASupprimer = P;
                            }
                        }
                        if (bSuppPiece)
                        {
                            EtageSelectionne.ListePiece.Remove(PieceASupprimer);
                            treeView.SelectedNode.Remove();

                            msAjouterPiece.Enabled = false;
                            msModifierPiece.Enabled = false;
                            msSupprimerPiece.Enabled = false;
                            msAjouterAppareil.Enabled = false;
                            msModifierAppareil.Enabled = false;
                            msSupprimerAppareil.Enabled = false;

                            PieceSelectionnee = new CRoom();
                            AppareilSelectionne = new CAppliance();
                        }
                    }
                }
            }
        }

        /************************** Appareils **************************/

        private void msAjouterAppareil_Click(object sender, EventArgs e)
        {
            FormAppareilAjout FAA = new FormAppareilAjout(PieceSelectionnee);

            FAA.ShowDialog();

            if (FAA.AjoutAppareil)
            {
                Graphics g = Graphics.FromImage(pbDessin.Image);
                PieceSelectionnee.Draw(g);
                pbDessin.Refresh();
                g.Dispose();
            }
        }

        private void msModifierAppareil_Click(object sender, EventArgs e)
        {
            FormAppareilModif FAM = new FormAppareilModif(AppareilSelectionne);

            FAM.ShowDialog();

            if (FAM.Valide)
                MessageBox.Show("Les modifications ont bien été prise en compte !");
        }

        private void msSupprimerAppareil_Click(object sender, EventArgs e)
        {
            if (AppareilSelectionne != null)
            {
                DialogResult DR = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet appareil ?", "Suppression d'un appareil", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (DR == DialogResult.Yes)
                {
                    if (treeView.SelectedNode.Parent.Parent.Text.Contains("Rez-de-chaussée") || treeView.SelectedNode.Parent.Parent.Text.Contains("Etage"))
                    {
                        bool bSuppApp = false;
                        CAppliance appASupprimer = new CAppliance();

                        foreach (CAppliance A in PieceSelectionnee.ListeApp)
                        {
                            if (treeView.SelectedNode.Text == A.NomAppareil)
                            {
                                bSuppApp = true;
                                appASupprimer = A;
                            }
                        }
                        if (bSuppApp)
                        {
                            PieceSelectionnee.ListeApp.Remove(appASupprimer);
                            treeView.SelectedNode.Remove();

                            msAjouterAppareil.Enabled = false;
                            msModifierAppareil.Enabled = false;
                            msSupprimerAppareil.Enabled = false;

                            AppareilSelectionne = new CAppliance();
                        }
                    }

                }
            }
        }

        /************************** Simulation **************************/

        private void msSimulation_Click(object sender, EventArgs e)
        {
            FormSimulationChoix FSC = new FormSimulationChoix();
            FSC.ShowDialog();

            ChoixSimulation = FSC.ChoixSimulation;

            if (ChoixSimulation == 0)
                MessageBox.Show("Vous avez décidé d'annuler la simulation !");
            else
            {
                if (ChoixSimulation == 1) // Maison sélectionnée
                {
                    /* Permet de remettre le prix de la consommation journalière à 0 pour ne pas fausser les futures simulations */
                    foreach (CFloor E in MaisonSelectionnee.ListeEtage)
                    {
                        foreach (CRoom P in E.ListePiece)
                        {
                            foreach (IConsumable A in P.ListeApp)
                            {
                                A.PrixConsommationJournaliere = 0.0;
                                A.PrixConsommationJournaliereVeille = 0.0;
                            }
                        }
                    }
                }
                else if (ChoixSimulation == 2) // Toutes les maisons du propriétaires
                {
                    /* Permet de remettre le prix de la consommation journalière à 0 pour ne pas fausser les futures simulations */
                    foreach (CHouse M in UserCo.ListeMaison)
                    {
                        foreach (CFloor E in M.ListeEtage)
                        {
                            foreach (CRoom P in E.ListePiece)
                            {
                                foreach (IConsumable A in P.ListeApp)
                                {
                                    A.PrixConsommationJournaliere = 0.0;
                                    A.PrixConsommationJournaliereVeille = 0.0;
                                }
                            }
                        }
                    }
                }

                lbSimulationEnCours.Visible = true;
                progressBarSimulation.Visible = true;

                msMaison.Enabled = false;
                msEtage.Enabled = false;
                msPiece.Enabled = false;
                msAppareil.Enabled = false;
                msSimulation.Enabled = false;
                msQuitter.Enabled = false;

                timerSimulation.Interval = 250;
                timerSimulation.Start();
            }              
        }

        /************************** Quitter **************************/

        private void msQuitter_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<CHouse>));

            String sPathFile = (String)Reg.GetValue(UserCo.Login, "Chemin inexistant");

            if (sPathFile.Equals("Chemin inexistant"))
            {
                StreamWriter strW = new StreamWriter(@"C:\Users\" + Environment.UserName + @"\Documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\XMLFiles\" + UserCo.Login + ".xml");
                xml.Serialize(strW, UserCo.ListeMaison);
                strW.Close();
                Reg.SetValue(UserCo.Login, @"C:\Users\" + Environment.UserName + @"\Documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\XMLFiles\" + UserCo.Login + ".xml");
            }
            else
            {
                if (File.Exists(sPathFile))
                {
                    StreamWriter strW = new StreamWriter(sPathFile);
                    xml.Serialize(strW, UserCo.ListeMaison);
                    strW.Close();
                }
            }

            this.Dispose();
        }

        #endregion

        #region Evenements Noeuds TreeView

        void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                Graphics g = Graphics.FromImage(pbDessin.Image);

                if (treeView.SelectedNode.Text.Contains("Maison"))
                {
                    //msModifierMaison.Enabled = true;
                    msSupprimerMaison.Enabled = true;

                    foreach (CHouse M in UserCo.ListeMaison)
                    {
                        if (M.IDMaison.Equals(treeView.SelectedNode.Text))
                        {
                            pbDessin.Image = new Bitmap(Image.FromFile(M.PathImage), pbDessin.Size);
                            msAjouterEtage.Enabled = true;
                            MaisonSelectionnee = M;
                            lbRue.Text = M.Adresse.ToString();
                            break;
                        }
                    }

                    if (MaisonSelectionnee.IDMaison != treeView.SelectedNode.Text)
                    {
                        msAjouterPiece.Enabled = false;
                        msModifierPiece.Enabled = false;
                        msSupprimerPiece.Enabled = false;
                        msSupprimerEtage.Enabled = false;
                        msAjouterAppareil.Enabled = false;
                        msModifierAppareil.Enabled = false;
                        msSupprimerAppareil.Enabled = false;

                        EtageSelectionne = new CFloor();
                        PieceSelectionnee = new CRoom();
                        AppareilSelectionne = new CAppliance();
                    }
                }
                else if (treeView.SelectedNode.Text.Contains("Rez-de-chaussée") || treeView.SelectedNode.Text.Contains("Etage"))
                {
                    msAjouterPiece.Enabled = true;
                    msSupprimerEtage.Enabled = true;

                    if (EtageSelectionne.NomEtage != treeView.SelectedNode.Text)
                    {
                        msAjouterAppareil.Enabled = false;
                        msModifierAppareil.Enabled = false;
                        msSupprimerAppareil.Enabled = false;
                        msModifierPiece.Enabled = false;
                        msSupprimerPiece.Enabled = false;
                    }

                    foreach (CFloor E in MaisonSelectionnee.ListeEtage)
                    {
                        if (E.NomEtage.Equals(treeView.SelectedNode.Text))
                        {
                            EtageSelectionne = new CFloor(E.NomEtage, E.ListePiece);
                            g.Clear(Color.White);

                            foreach (CRoom P in EtageSelectionne.ListePiece)
                            {
                                P.Draw(g);
                                g.DrawString(P.NomPiece, new Font(this.Font, FontStyle.Regular), new SolidBrush(Color.Black), P.PointAncrage.X + P.Longueur / 2, P.PointAncrage.Y + P.Largeur / 2);

                                if (P.ListeApp.Count > 0)
                                {
                                    foreach (IDrawable A in P.ListeApp)
                                    {
                                        A.Draw(g);
                                    }
                                }
                            }
                        }
                    }

                    g.Dispose();
                    pbDessin.Refresh();
                }
                else if (treeView.SelectedNode.Parent.Text.Contains("Rez-de-chaussée") || treeView.SelectedNode.Parent.Text.Contains("Etage")) // Clique sur une pièce
                {
                    remplirListBoxAppareil();
                    listBoxAppareil.Enabled = true;
                    msAjouterAppareil.Enabled = true;
                    msModifierPiece.Enabled = true;
                    msSupprimerPiece.Enabled = true;

                    foreach (CRoom P in EtageSelectionne.ListePiece)
                    {
                        if (P.NomPiece == treeView.SelectedNode.Text)
                        {
                            PieceSelectionnee = new CRoom(P.NomPiece, P.PointAncrage, P.Couleur, P.Longueur, P.Largeur, P.ListeApp);
                            break;
                        }
                    }

                    if (PieceSelectionnee != null)
                        MessageBox.Show(PieceSelectionnee.ToString());
                }
                else // Clique sur un appareil
                {
                    MessageBox.Show("Appareil sélectionné");
                    msModifierAppareil.Enabled = true;
                    msSupprimerAppareil.Enabled = true;
                    listBoxAppareil.Enabled = true;
                }

                pbDessin.Refresh();
                g.Dispose();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Veuillez sélectionner un noeud dans la tree view ! : " + ex.Message);
            }
        }

        #endregion

        #region Evenements PictureBox

        private void pbDessin_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Graphics g = Graphics.FromImage(pbDessin.Image);
                
                foreach (CRoom P in EtageSelectionne.ListePiece)
                {
                    Color couleur = Color.White;

                    switch (P.Couleur)
                    {
                        case 1:
                            couleur = Color.Aqua;
                            break;

                        case 2:
                            couleur = Color.Beige;
                            break;

                        case 3:
                            couleur = Color.Chartreuse;
                            break;

                        case 4:
                            couleur = Color.Cyan;
                            break;

                        case 5:
                            couleur = Color.Fuchsia;
                            break;

                        case 6:
                            couleur = Color.Gold;
                            break;

                        default:
                            couleur = Color.Silver;
                            break;
                    }

                    if (P.TopLeft.X <= e.Location.X && P.TopLeft.X + P.Longueur >= e.Location.X)
                    {
                        if (P.TopLeft.Y <= e.Location.Y && P.TopLeft.Y + P.Largeur >= e.Location.Y)
                            g.DrawRectangle(new Pen(Color.Red, 2), P.TopLeft.X, P.TopLeft.Y, P.Longueur, P.Largeur);
                        else
                            g.DrawRectangle(new Pen(Color.White, 2), P.PointAncrage.X, P.PointAncrage.Y, P.Longueur, P.Largeur);
                    }
                    else
                        g.DrawRectangle(new Pen(Color.White, 2), P.PointAncrage.X, P.PointAncrage.Y, P.Longueur, P.Largeur);
                }
                g.Dispose();
                pbDessin.Refresh();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void pbDessin_MouseDown(object sender, MouseEventArgs e)
        {
            if (AjoutPiece || (AjoutAppareil && listBoxAppareil.SelectedItem != null))
            {
                BitmapTemp = new Bitmap(pbDessin.Image);
                PositionMouseDown = e.Location;
                MouseClic = true;
            }
        }

        private void pbDessin_MouseMove(object sender, MouseEventArgs e)
        {
            if (PositionMouseUp.X == PositionMouseDown.X)
                BitmapTemp = null;

            if (AjoutPiece && MouseClic && BitmapTemp != null)
            {
                pbDessin.Image = new Bitmap(BitmapTemp);
                Graphics g = Graphics.FromImage(pbDessin.Image);

                float fTailleX = e.Location.X - PositionMouseDown.X;
                float fTailleY = e.Location.Y - PositionMouseDown.Y;

                Point pAncrageTemp = new Point();

                if (PositionMouseDown.X < e.Location.X)
                    pAncrageTemp.X = PositionMouseDown.X;
                else
                    pAncrageTemp.X = e.Location.X;

                if (PositionMouseDown.Y < e.Location.Y)
                    pAncrageTemp.Y = PositionMouseDown.Y;
                else
                    pAncrageTemp.Y = e.Location.Y;

                fTailleX = Math.Abs(fTailleX);
                fTailleY = Math.Abs(fTailleY);

                Color couleur = Color.White;

                switch (EtageSelectionne.ListePiece.Count)
                {
                    case 1:
                        couleur = Color.Aqua;
                        break;

                    case 2:
                        couleur = Color.Beige;
                        break;

                    case 3:
                        couleur = Color.Chartreuse;
                        break;

                    case 4:
                        couleur = Color.Cyan;
                        break;

                    case 5:
                        couleur = Color.Fuchsia;
                        break;

                    case 6:
                        couleur = Color.Gold;
                        break;

                    default:
                        couleur = Color.Silver;
                        break;
                }

                g.FillRectangle(new SolidBrush(couleur), pAncrageTemp.X, pAncrageTemp.Y, fTailleX, fTailleY);
                pbDessin.Refresh();
                g.Dispose();
            }
        }

        private void pbDessin_MouseUp(object sender, MouseEventArgs e)
        {
            if (PositionMouseDown.X == e.Location.X)
                BitmapTemp = null;

            if (AjoutPiece && MouseClic && BitmapTemp != null)
            {
                PositionMouseUp = e.Location;
                float fTailleX = PositionMouseUp.X - PositionMouseDown.X;
                float fTailleY = PositionMouseUp.Y - PositionMouseDown.Y;

                Point pAncrageTemp = new Point();

                if (PositionMouseDown.X < PositionMouseUp.X)
                    pAncrageTemp.X = PositionMouseDown.X;
                else
                    pAncrageTemp.X = PositionMouseUp.X;

                if (PositionMouseDown.Y < PositionMouseUp.Y)
                    pAncrageTemp.Y = PositionMouseDown.Y;
                else
                    pAncrageTemp.Y = PositionMouseUp.Y;

                fTailleX = Math.Abs(fTailleX);
                fTailleY = Math.Abs(fTailleY);

                FormPieceAjout FPA = new FormPieceAjout();
                FPA.ShowDialog();

                if (FPA.Valide)
                {
                    Graphics g = Graphics.FromImage(pbDessin.Image);

                    CRoom pieceAjoutee = new CRoom(FPA.NomPiece, pAncrageTemp, EtageSelectionne.ListePiece.Count, (int)fTailleX, (int)fTailleY, new List<CAppliance>());
                    pieceAjoutee.Draw(g);
                    EtageSelectionne.ListePiece.Add(pieceAjoutee);

                    foreach (CRoom P in EtageSelectionne.ListePiece)
                    {
                        g.DrawString(P.NomPiece, new Font(this.Font, FontStyle.Regular), new SolidBrush(Color.Black), P.PointAncrage.X + P.Longueur / 2, P.PointAncrage.Y + P.Largeur / 2);
                    }

                    g.Dispose();
                    pbDessin.Refresh();
                    treeView.SelectedNode.Nodes.Add(FPA.NomPiece);
                }
                AjoutPiece = false;
                MouseClic = false;
            }
        }

        #endregion

        #region Evenements ListBox

        private void listBoxAppareil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reg = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("HEPL", true).OpenSubKey("Dessine-moi", true).OpenSubKey("OptimizeEnergyConsumption", true);

            CAppliance app = (CAppliance)listBoxAppareil.SelectedItem;
            //string sFileName = (string)listBoxAppareil.SelectedItem;
            //string sFilePath = (string)Reg.GetValue(sFileName);

            Bitmap img = new Bitmap(app.PathImage);

            float fEchelleTemp, fCoordTemp;
            pbAppareil.Image = new Bitmap(pbAppareil.Size.Width, pbAppareil.Size.Height, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(pbAppareil.Image);

            if (img.Size.Width > img.Size.Height)
            {
                fEchelleTemp = (float)img.Size.Width / (float)pbAppareil.Size.Width;
                fCoordTemp = (pbAppareil.Size.Height - (img.Size.Height / fEchelleTemp)) / 2;

                g.DrawImage(img, 0, (int)fCoordTemp, pbAppareil.Size.Width, img.Size.Height / fEchelleTemp);
            }
            else if (img.Size.Width < img.Size.Height)
            {
                fEchelleTemp = (float)img.Size.Height / (float)pbAppareil.Size.Height;
                fCoordTemp = (pbAppareil.Size.Width - (img.Size.Width / fEchelleTemp)) / 2;

                g.DrawImage(img, (int)fCoordTemp, 0, img.Size.Width / fEchelleTemp, pbAppareil.Size.Height);
            }
            else
            {
                if (img.Size.Width >= pbAppareil.Size.Width)
                    g.DrawImage(img, 0, 0, pbAppareil.Size.Width, pbAppareil.Size.Height);
                else
                {
                    fCoordTemp = pbAppareil.Size.Width - img.Size.Width;

                    g.DrawImage(img, fCoordTemp / 2, fCoordTemp / 2, img.Size.Width, img.Size.Height);
                }
            }

            g.Dispose();
            pbAppareil.Refresh();

            AjoutAppareil = true;
        }

        private void listBoxAppareil_SelectedValueChanged(object sender, EventArgs e)
        {
            propertyGridAppareil.SelectedObject = listBoxAppareil.SelectedItem;
        }

        #endregion

        #region Evenements Timer

        private void timerSimulation_Tick(object sender, EventArgs e)
        {
            double resultatSimulationAppareil = 0.0, resultatSimulationAppareilVeille = 0.0;

            if (IndiceSimulation < AppareilSelectionne.Autorisation.TabBool.Length)
            {
                progressBarSimulation.PerformStep();

                if (IndiceSimulation == 47)
                    progressBarSimulation.Value = progressBarSimulation.Maximum;

                if (ChoixSimulation == 1)
                {
                    foreach (CFloor E in MaisonSelectionnee.ListeEtage)
                    {
                        foreach (CRoom P in E.ListePiece)
                        {
                            foreach (IConsumable A in P.ListeApp)
                            {
                                if (IndiceSimulation > 11 && IndiceSimulation < 46) // Entre 6h et 23h, tarif de jour
                                {
                                    resultatSimulationAppareil += A.Consume(PrixWattHeureJournee, IndiceSimulation);
                                    resultatSimulationAppareilVeille += A.ConsumeSleepMode(PrixWattHeureJournee, IndiceSimulation);
                                }
                                else // entre 23h et 6h, tarif de nuit
                                {
                                    resultatSimulationAppareil += A.Consume(PrixWattHeureNuit, IndiceSimulation);
                                    resultatSimulationAppareilVeille += A.ConsumeSleepMode(PrixWattHeureNuit, IndiceSimulation);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (ChoixSimulation == 2)
                    {
                        foreach (CHouse M in UserCo.ListeMaison)
                        {
                            foreach (CFloor E in M.ListeEtage)
                            {
                                foreach (CRoom P in E.ListePiece)
                                {
                                    foreach (IConsumable A in P.ListeApp)
                                    {
                                        if (IndiceSimulation > 11 && IndiceSimulation < 46)
                                        {
                                            resultatSimulationAppareil += A.Consume(PrixWattHeureJournee, IndiceSimulation);
                                            resultatSimulationAppareilVeille += A.ConsumeSleepMode(PrixWattHeureJournee, IndiceSimulation);
                                        }
                                        else
                                        {
                                            resultatSimulationAppareil += A.Consume(PrixWattHeureNuit, IndiceSimulation);
                                            resultatSimulationAppareilVeille += A.ConsumeSleepMode(PrixWattHeureNuit, IndiceSimulation);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                IndiceSimulation++;
            }
            else
            {
                timerSimulation.Stop();
                MessageBox.Show("La simulation est terminée !");

                FormAffichageResultatSimulation FARS;

                if (ChoixSimulation == 1)
                {
                    foreach (CFloor E in MaisonSelectionnee.ListeEtage)
                    {
                        foreach (CRoom P in E.ListePiece)
                        {
                            P.calculerConsommationJournaliere();
                            P.calculerPrixJournalier();
                        }

                        E.calculerConsommationJournaliere();
                        E.calculerPrixJournalier();
                    }

                    MaisonSelectionnee.calculerConsommationJournaliere();
                    MaisonSelectionnee.calculerPrixJournalier();

                    FARS = new FormAffichageResultatSimulation(MaisonSelectionnee, resultatSimulationAppareil, resultatSimulationAppareilVeille);
                    FARS.ShowDialog();
                }
                else // A FAIRE !!!!!!!!!!!!!!!
                {
                    if (ChoixSimulation == 2)
                    {
                        FARS = new FormAffichageResultatSimulation(UserCo.ListeMaison, resultatSimulationAppareil, resultatSimulationAppareilVeille);
                        FARS.ShowDialog();
                    }
                }

                msMaison.Enabled = true;
                msEtage.Enabled = true;
                msPiece.Enabled = true;
                msAppareil.Enabled = true;
                msSimulation.Enabled = true;
                msQuitter.Enabled = true;

                progressBarSimulation.Visible = false;
                lbSimulationEnCours.Visible = false;
                IndiceSimulation = 0;
                progressBarSimulation.Value = 0;
            }
        }

        #endregion

        #region Méthodes

        private void remplirTreeView()
        {
            for (int i = 0; i < UserCo.ListeMaison.Count; i++)
            {
                int iNumMaison = i + 1;
                UserCo.ListeMaison[i].IDMaison = "Maison " + iNumMaison.ToString();
                treeView.Nodes.Add(UserCo.ListeMaison[i].IDMaison);

                for (int j = 0; j < UserCo.ListeMaison[i].ListeEtage.Count; j++)
                {
                    if (j == 0)
                        UserCo.ListeMaison[i].ListeEtage[j].NomEtage = "Rez-de-chaussée";
                    else
                        UserCo.ListeMaison[i].ListeEtage[j].NomEtage = "Etage " + j.ToString();

                    treeView.Nodes[i].Nodes.Add(UserCo.ListeMaison[i].ListeEtage[j].NomEtage);

                    for (int k = 0; k < UserCo.ListeMaison[i].ListeEtage[j].ListePiece.Count; k++)
                    {
                        treeView.Nodes[i].Nodes[j].Nodes.Add(UserCo.ListeMaison[i].ListeEtage[j].ListePiece[k].NomPiece);

                        for (int l = 0; l < UserCo.ListeMaison[i].ListeEtage[j].ListePiece[k].ListeApp.Count; l++)
                        {
                            treeView.Nodes[i].Nodes[j].Nodes[k].Nodes.Add(UserCo.ListeMaison[i].ListeEtage[j].ListePiece[k].ListeApp[l].NomAppareil);
                        }
                    }
                }
            }
        }

        private void remplirListBoxAppareil()
        {
            if (PieceSelectionnee != null)
            {
                if (PieceSelectionnee.ListeApp.Count > 0)
                {
                    listBoxAppareil.Items.Clear();

                    foreach (IConsumable A in PieceSelectionnee.ListeApp)
                    {
                        listBoxAppareil.Items.Add(A);
                    }
                }
            }
        }

        #endregion
    }
}
