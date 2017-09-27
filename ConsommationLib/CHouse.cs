using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace ConsumptionLib
{
    public class CHouse : ICloneable
    {
        #region Variables membres

        private String _IDMaison;
        private List<CFloor> _ListeEtage;
        private String _PathImage;
        private CAdress _Adresse;
        [XmlIgnore]
        private double _ConsommationJournaliere;
        [XmlIgnore]
        private double _PrixJournalier;

        #endregion

        #region Propriete

        public String IDMaison
        {
            get { return _IDMaison; }
            set { _IDMaison = value; }
        }

        public List<CFloor> ListeEtage
        {
            get { return _ListeEtage; }
            set { _ListeEtage = value; }
        }

        public String PathImage
        {
            get { return _PathImage; }
            set { _PathImage = value; }
        }

        public CAdress Adresse
        {
            get { return _Adresse; }
            set { _Adresse = value; }
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

        public CHouse()
        {
            ListeEtage = new List<CFloor>();
            PathImage = "default";
            Adresse = new CAdress();
            ConsommationJournaliere = 0.0;
            PrixJournalier = 0.0;
        }

        public CHouse(List<CFloor> l, String PI, CAdress adr)
        {
            ListeEtage = l;
            PathImage = PI;
            Adresse = adr;
            ConsommationJournaliere = 0.0;
            PrixJournalier = 0.0;
        }

        #endregion

        #region Méthodes

        public object Clone()
        {
            List<CFloor> lTemp = new List<CFloor>();

            foreach (CFloor E in ListeEtage)
            {
                CFloor etageTemp = (CFloor)E.Clone();
                lTemp.Add(etageTemp);
            }

            CAdress adrTemp = new CAdress(this.Adresse.Rue, this.Adresse.Numero, this.Adresse.CodePostal, this.Adresse.Localite);

            return new CHouse(lTemp, this.PathImage, adrTemp);
        }

        public override string ToString()
        {
            return IDMaison;
        }

        public void calculerConsommationJournaliere()
        {
            if (ListeEtage.Count > 0)
            {
                foreach (CFloor E in ListeEtage)
                {
                    ConsommationJournaliere += E.ConsommationJournaliere;
                }
            }
        }

        public void calculerPrixJournalier()
        {
            if (ListeEtage.Count > 0)
            {
                foreach (CFloor E in ListeEtage)
                {
                    PrixJournalier += E.PrixJournalier;
                }
            }
        }

        #endregion
    }
}