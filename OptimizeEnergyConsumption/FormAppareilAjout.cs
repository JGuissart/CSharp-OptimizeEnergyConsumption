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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimizeEnergyConsumption
{
    public partial class FormAppareilAjout : Form
    {
        #region Variables membres

        private Bitmap _bitmapPiece;
        private Bitmap _PbTemp;
        private Bitmap _BitmapAppareil;
        private Color _CouleurPiece;
        private RegistryKey _Reg;
        private bool _AjoutAppareil;
        private bool _MouseClic;
        private Point _PositionMouseDown;
        private Point _PositionMouseUp;
        private string _CheminFichier;
        private CRoom _Piece;
        private float _Echelle;

        #endregion

        #region Propriétés

        public Bitmap BitmapPiece
        {
            get { return _bitmapPiece; }
            set { _bitmapPiece = value; }
        }

        public Bitmap PbTemp
        {
            get { return _PbTemp; }
            set { _PbTemp = value; }
        }

        public Bitmap BitmapAppareil
        {
            get { return _BitmapAppareil; }
            set { _BitmapAppareil = value; }
        }

        public Color CouleurPiece
        {
            get { return _CouleurPiece; }
            set { _CouleurPiece = value; }
        }

        public RegistryKey Reg
        {
            get { return _Reg; }
            set { _Reg = value; }
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

        public string CheminFichier
        {
            get { return _CheminFichier; }
            set { _CheminFichier = value; }
        }

        public CRoom Piece
        {
            get { return _Piece; }
            set { _Piece = value; }
        }

        public float Echelle
        {
            get { return _Echelle; }
            set { _Echelle = value; }
        }

        #endregion

        #region Constructeurs

        public FormAppareilAjout()
        {
            InitializeComponent();
        }

        public FormAppareilAjout(CRoom PieceSelectionnee)
        {
            InitializeComponent();
            recupererCouleur(PieceSelectionnee.Couleur);
            remplirListBoxAppareil();
            BitmapPiece = new Bitmap(PieceSelectionnee.Longueur, PieceSelectionnee.Largeur);
            redimensionnerPictureBox();
            Piece = PieceSelectionnee;

            if (Piece.ListeApp.Count > 0)
                dessinerAppareils();
        }

        #endregion

        #region Evenements Boutons

        private void btValider_Click(object sender, EventArgs e)
        {
            AjoutAppareil = true;
            this.Dispose();
        }

        #endregion

        #region Evenements pictureBox

        private void pbDessinAppareil_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                PositionMouseDown = e.Location;
                PbTemp = new Bitmap(pbDessinAppareil.Image);
                BitmapAppareil = new Bitmap(CheminFichier);
                MouseClic = true;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbDessinAppareil_MouseMove(object sender, MouseEventArgs e)
        {
            if (PositionMouseUp.X == PositionMouseDown.X)
                PbTemp = null;

            if (MouseClic && PbTemp != null)
            {
                pbDessinAppareil.Image = new Bitmap(PbTemp);
                Graphics g = Graphics.FromImage(pbDessinAppareil.Image);

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

                float fEchelle = (float)fTailleX / (float)BitmapAppareil.Size.Width;

                g.DrawImage(BitmapAppareil, pAncrageTemp.X, pAncrageTemp.Y, fTailleX, BitmapAppareil.Size.Height * fEchelle);

                pbDessinAppareil.Refresh();
                g.Dispose();
            }
        }

        private void pbDessinAppareil_MouseUp(object sender, MouseEventArgs e)
        {
            if (PositionMouseDown.X == e.Location.X)
                PbTemp = null;

            if (MouseClic && PbTemp != null)
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

                Graphics g = Graphics.FromImage(pbDessinAppareil.Image);

                float fEchelle = (float)fTailleX / (float)BitmapAppareil.Size.Width;

                g.DrawImage(BitmapAppareil, pAncrageTemp.X, pAncrageTemp.Y, fTailleX, BitmapAppareil.Size.Height * fEchelle);

                pbDessinAppareil.Refresh();
                g.Dispose();

                FormAppareilAjoutSpecifications FAAS = new FormAppareilAjoutSpecifications();
                FAAS.ShowDialog();

                if (FAAS.Valide)
                {
                    int PositionXTemp = (int)(pAncrageTemp.X / Echelle);
                    int PositionYTemp = (int)(pAncrageTemp.Y / Echelle);
                    PositionXTemp += Piece.PointAncrage.X;
                    PositionYTemp += Piece.PointAncrage.Y;

                    int Long = (int)(fTailleX / Echelle);
                    int Larg = (int)((BitmapAppareil.Size.Height * fEchelle) / Echelle);

                    if (FAAS.AppareilEnVeille)
                    {
                        CApplianceSleepMode ASM = FAAS.AppareilVeille;
                        ASM.PointAncrage = new Point(PositionXTemp, PositionYTemp);
                        ASM.Longueur = Long;
                        ASM.Largeur = Larg;
                        ASM.PathImage = CheminFichier;
                        Piece.ListeApp.Add(ASM);
                    }
                    else
                    {
                        CAppliance app = FAAS.Appareil;
                        app.PointAncrage = new Point(PositionXTemp, PositionYTemp);
                        app.Longueur = Long;
                        app.Largeur = Larg;
                        app.PathImage = CheminFichier;
                        Piece.ListeApp.Add(app);
                    }
                }

                MouseClic = false;
            }
        }

        #endregion

        #region Evenements ListBox

        private void listBoxAppareil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reg = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("HEPL", true).OpenSubKey("Dessine-moi", true).OpenSubKey("OptimizeEnergyConsumption", true);

            string sFileName = (string)listBoxAppareil.SelectedItem;
            CheminFichier = (string)Reg.GetValue(sFileName);

            Bitmap img = new Bitmap(CheminFichier);

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

        #endregion

        #region Méthodes

        private void remplirListBoxAppareil()
        {
            Reg = Registry.CurrentUser.OpenSubKey("Software", true);
            if (Reg.OpenSubKey("HEPL", true) == null)
                Reg.CreateSubKey("HEPL");
            Reg = Reg.OpenSubKey("HEPL", true);
            if (Reg.OpenSubKey("Dessine-moi", true) == null)
                Reg.CreateSubKey("Dessine-moi");
            Reg = Reg.OpenSubKey("Dessine-moi", true);
            if (Reg.OpenSubKey("OptimizeEnergyConsumption", true) == null)
                Reg.CreateSubKey("OptimizeEnergyConsumption");
            Reg = Reg.OpenSubKey("OptimizeEnergyConsumption", true);

            if (Reg.ValueCount > 0)
            {
                string[] listeNoms = Reg.GetValueNames();
                string sPath;

                foreach (string nomImage in listeNoms)
                {
                    sPath = (string)Reg.GetValue(nomImage);
                    if (File.Exists(sPath))
                    {
                        listBoxAppareil.Items.Add(nomImage);
                    }
                    else
                    {
                        MessageBox.Show("Le fichier \"" + nomImage + "\" n'existe plus ...\n" +
                                        "Celui-ci a peut-être été renommé ou supprimé ...\n" +
                                        "(Ancien emplacement: " + sPath + ")");
                        Reg.DeleteValue(nomImage);
                    }
                }
            }
            else
            {
                string[] sFichiers = Directory.GetFiles(@"C:\Users\" + Environment.UserName + @"\Mes documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\Images\Appareils");

                foreach (string file in sFichiers)
                {
                    FileInfo fi = new FileInfo(file);
                    if (fi.Extension.Contains("bmp") || fi.Extension.Contains("BMP") || fi.Extension.Contains("jpg") || fi.Extension.Contains("JPG") || fi.Extension.Contains("jpeg") || fi.Extension.Contains("JPEG") || fi.Extension.Contains("png") || fi.Extension.Contains("PNG"))
                    {
                        listBoxAppareil.Items.Add(fi.Name);
                        Reg.SetValue(fi.Name, file);
                    }
                }
            }
        }

        private void redimensionnerPictureBox()
        {
            if (BitmapPiece.Size.Width > BitmapPiece.Size.Height)
            {
                Echelle = (float)panelPbDessinAppareil.Size.Width / (float)BitmapPiece.Size.Width;

                MessageBox.Show(Echelle.ToString());

                pbDessinAppareil.Image = new Bitmap(panelPbDessinAppareil.Size.Width, (int)(BitmapPiece.Size.Height * Echelle), PixelFormat.Format24bppRgb);
                pbDessinAppareil.Size = new Size(panelPbDessinAppareil.Size.Width, (int)(BitmapPiece.Size.Height * Echelle));

                int PositionY = panelPbDessinAppareil.Size.Height / 2 - pbDessinAppareil.Size.Height / 2;
                pbDessinAppareil.Location = new Point(pbDessinAppareil.Location.X, PositionY);
            }
            else
            {
                Echelle = (float)panelPbDessinAppareil.Size.Height / (float)BitmapPiece.Size.Height;

                MessageBox.Show(Echelle.ToString());

                pbDessinAppareil.Image = new Bitmap((int)(BitmapPiece.Size.Width * Echelle), panelPbDessinAppareil.Size.Height, PixelFormat.Format24bppRgb);
                pbDessinAppareil.Size = new Size((int)(BitmapPiece.Size.Width * Echelle), panelPbDessinAppareil.Size.Height);

                int PositionX = panelPbDessinAppareil.Size.Width / 2 - pbDessinAppareil.Size.Width / 2;
                pbDessinAppareil.Location = new Point(PositionX, pbDessinAppareil.Location.Y);
            }

            Graphics g = Graphics.FromImage(pbDessinAppareil.Image);
            g.Clear(CouleurPiece);
            g.Dispose();
            pbDessinAppareil.Refresh();
        }

        private void recupererCouleur(int numCouleur)
        {
            switch (numCouleur)
            {
                case 1:
                    CouleurPiece = Color.Aqua;
                    break;

                case 2:
                    CouleurPiece = Color.Beige;
                    break;

                case 3:
                    CouleurPiece = Color.Chartreuse;
                    break;

                case 4:
                    CouleurPiece = Color.Cyan;
                    break;

                case 5:
                    CouleurPiece = Color.Fuchsia;
                    break;

                case 6:
                    CouleurPiece = Color.Gold;
                    break;

                default:
                    CouleurPiece = Color.Silver;
                    break;
            }
        }

        private void dessinerAppareils()
        {
            Graphics g = Graphics.FromImage(pbDessinAppareil.Image);
            foreach (CAppliance A in Piece.ListeApp)
            {
                int iPositionXTemp = A.PointAncrage.X;
                int iPositionYTemp = A.PointAncrage.Y;

                iPositionXTemp -= Piece.PointAncrage.X;
                iPositionYTemp -= Piece.PointAncrage.Y;

                iPositionXTemp = (int)(iPositionXTemp * Echelle);
                iPositionYTemp = (int)(iPositionYTemp * Echelle);

                int LongueurTemp = (int)(A.Longueur * Echelle);
                int LargeurTemp = (int)(A.Largeur * Echelle);

                Bitmap bitTemp = new Bitmap(A.PathImage);

                g.DrawImage(bitTemp, iPositionXTemp, iPositionYTemp, LongueurTemp, LargeurTemp);
            }

            pbDessinAppareil.Refresh();
            g.Dispose();
        }

        #endregion                
    }
}
