using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace ConsumptionLib
{
    public enum TypeAppareil
    {
        Electromenager,
        Media,
        Chauffage,
        Eclairage,
        Autre
    }

    public class CAppliance : ICloneable, IDrawable, IConsumable
    {
        #region Variables membres

        private String _NomAppareil;
        private String _PathImage;
        private String _Marque;
        private String _Modele;
        private String _NumeroSerie;
        private double _Consommation;
        public TypeAppareil _Type;
        private Point _PointAncrage;
        private CAutorisation _Autorisation; 
        private int _Longueur;
        private int _Largeur;

        [XmlIgnore]
        private double _ConsommationJournaliere;

        [XmlIgnore]
        private double _PrixConsommationJournaliere;

        [XmlIgnore]
        private double _PrixConsommationJournaliereVeille;

        #endregion

        #region Propriétés

        public String NomAppareil
        {
            get { return _NomAppareil; }
            set { _NomAppareil = value; }
        }

        public String PathImage
        {
            get { return _PathImage; }
            set { _PathImage = value; }
        }

        public String Marque
        {
            get { return _Marque; }
            set { _Marque = value; }
        }

        public String Modele
        {
            get { return _Modele; }
            set { _Modele = value; }
        }

        public String NumeroSerie
        {
            get { return _NumeroSerie; }
            set { _NumeroSerie = value; }
        }

        public double Consommation
        {
            get { return _Consommation; }
            set { _Consommation = value; }
        }

        public TypeAppareil Type
        {
            get { return _Type; }
            set { _Type = value; }
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

        public CAutorisation Autorisation
        {
            get { return _Autorisation; }
            set { _Autorisation = value; }
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

        [XmlIgnore]
        public double ConsommationJournaliere
        {
            get { return _ConsommationJournaliere; }
            set { _ConsommationJournaliere = value; }
        }

        [XmlIgnore]
        public double PrixConsommationJournaliere
        {
            get { return _PrixConsommationJournaliere; }
            set { _PrixConsommationJournaliere = value; }
        }

        [XmlIgnore]
        public double PrixConsommationJournaliereVeille
        {
            get { return _PrixConsommationJournaliereVeille; }
            set { _PrixConsommationJournaliereVeille = value; }
        }

        #endregion

        #region Constructeurs

        public CAppliance()
        {
            NomAppareil = "Default";
            PathImage = "Default";
            PointAncrage = new Point(0, 0);
            Autorisation = new CAutorisation();
            Consommation = 0.0;
            ConsommationJournaliere = 0.0;
            PrixConsommationJournaliere = 0.0;
            PrixConsommationJournaliereVeille = 0.0;
        }

        public CAppliance(String n, String pi, Point pa, double c)
        {
            NomAppareil = n;
            PathImage = pi;
            PointAncrage = pa;
            Autorisation = new CAutorisation();
            Consommation = c;
            ConsommationJournaliere = 0.0;
            PrixConsommationJournaliere = 0.0;
            PrixConsommationJournaliereVeille = 0.0;
        }

        public CAppliance(String n, String ma, String mo, String ns, double c, int t)
        {
            NomAppareil = n;
            Marque = ma;
            Modele = mo;
            NumeroSerie = ns;
            Consommation = c;
            ConsommationJournaliere = 0.0;
            PrixConsommationJournaliere = 0.0;
            PrixConsommationJournaliereVeille = 0.0;
            Autorisation = new CAutorisation();

            if (t == 0)
                Type = TypeAppareil.Electromenager;
            else if (t == 1)
                Type = TypeAppareil.Media;
            else if (t == 2)
                Type = TypeAppareil.Chauffage;
            else if (t == 3)
                Type = TypeAppareil.Eclairage;
            else
                Type = TypeAppareil.Autre;
        }

        #endregion
        
        #region Méthodes

        public object Clone()
        {
            return new CAppliance(this.NomAppareil, this.PathImage, new Point(this.TopLeft.X, this.TopLeft.Y), this.Consommation);
        }

        public void Draw(Graphics g)
        {
            Bitmap bmp = new Bitmap(PathImage);

            g.DrawImage(bmp, TopLeft.X, TopLeft.Y, Longueur, Largeur);
        }

        public override string ToString()
        {
            return NomAppareil;
        }

        public double Consume(double prixWatt, int i)
        {
            if (Autorisation.TabBool[i])
            {
                ConsommationJournaliere += Consommation;
                PrixConsommationJournaliere += Consommation * prixWatt;

                return Consommation * prixWatt;
            }
            else
                return 0.0;
        }

        public virtual double ConsumeSleepMode(double prixWatt, int i)
        {
            return 0.0;
        }

        #endregion        
    }
}
