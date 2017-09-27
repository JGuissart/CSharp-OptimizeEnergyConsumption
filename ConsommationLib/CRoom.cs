using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace ConsumptionLib
{
    public class CRoom : ICloneable, IDrawable
    {
        #region Variables membres

        private String _NomPiece;
        private int _Couleur;
        private Point _PointAncrage;
        private int _Longueur;
        private int _Largeur;
        private List<CAppliance> _ListeApp;

        [XmlIgnore]
        private double _ConsommationJournaliere;
        [XmlIgnore]
        private double _PrixJournalier;

        #endregion

        #region Propriétés

        public String NomPiece
        {
            get { return _NomPiece; }
            set { _NomPiece = value; }
        }

        public int Couleur
        {
            get { return _Couleur; }
            set { _Couleur = value; }
        }

        public Point PointAncrage
        {
            get { return _PointAncrage; }
            set { _PointAncrage = value; }
        }

        public Point TopLeft
        {
            get { return _PointAncrage; }
            set { _PointAncrage = value; }
        }

        public int Longueur
        {
            get { return _Longueur; }
            set { _Longueur = value; }
        }

        public int Largeur
        {
            get { return _Largeur; }
            set { _Largeur = value; }
        }

        public List<CAppliance> ListeApp
        {
            get { return _ListeApp; }
            set { _ListeApp = value; }
        }

        [XmlIgnore]
        public double ConsommationJournaliere
        {
            get { return _ConsommationJournaliere; }
            set { _ConsommationJournaliere = value; }
        }

        [XmlIgnore]
        public double PrixJournalier
        {
            get { return _PrixJournalier; }
            set { _PrixJournalier = value; }
        }

        #endregion

        #region Constructeurs

        public CRoom()
        {
            NomPiece = "default";
            Couleur = 0;
            PointAncrage = new Point(0, 0);
            Longueur = 0;
            Largeur = 0;
            ListeApp = new List<CAppliance>();
        }

        public CRoom(String np, Point pa, int c, int lng, int lrg, List<CAppliance> lApp)
        {
            NomPiece = np;
            Couleur = c;
            PointAncrage = pa;
            Longueur = lng;
            Largeur = lrg;
            ListeApp = lApp;
        }

        #endregion

        #region Méthodes

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public void Draw(Graphics g)
        {
            Color couleur = Color.White;

            switch (Couleur)
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

            g.FillRectangle(new SolidBrush(couleur), PointAncrage.X, PointAncrage.Y, Longueur, Largeur);

            if (ListeApp.Count > 0)
            {
                foreach (CAppliance A in ListeApp)
                {
                    A.Draw(g);
                }
            }
        }

        public override string ToString()
        {
            if (ListeApp.Count == 0)
                return "La pièce \"" + NomPiece + "\" ne contient pas d'appareils !";
            else if (ListeApp.Count == 1)
                return "La pièce \"" + NomPiece + "\" contient " + ListeApp.Count + " appareil";
            else
                return "La pièce \"" + NomPiece + "\" contient " + ListeApp.Count + " appareils";
        }

        public void calculerConsommationJournaliere()
        {
            if (ListeApp.Count > 0)
            {
                foreach (CAppliance A in ListeApp)
                {
                    ConsommationJournaliere += A.ConsommationJournaliere;
                }
            }
        }

        public void calculerPrixJournalier()
        {
            if (ListeApp.Count > 0)
            {
                foreach (CAppliance A in ListeApp)
                {
                    PrixJournalier += A.PrixConsommationJournaliere + A.PrixConsommationJournaliereVeille;
                }
            }
        }

        #endregion   
    }
}
