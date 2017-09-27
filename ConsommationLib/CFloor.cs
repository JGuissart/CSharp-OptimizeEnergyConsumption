using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsumptionLib
{
    public class CFloor : ICloneable
    {
        #region Variables membres

        private String _NomEtage;
        private List<CRoom> _ListePiece;

        [XmlIgnore]
        private double _ConsommationJournaliere;
        [XmlIgnore]
        private double _PrixJournalier;

        #endregion

        #region Propriété

        public String NomEtage
        {
            get { return _NomEtage; }
            set { _NomEtage = value; }
        }

        public List<CRoom> ListePiece
        {
            get { return _ListePiece; }
            set { _ListePiece = value; }
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

        public CFloor()
        {
            NomEtage = "Default";
            ListePiece = new List<CRoom>();
            ConsommationJournaliere = 0.0;
            PrixJournalier = 0.0;
        }

        public CFloor(String n, List<CRoom> l)
        {
            NomEtage = n;
            ListePiece = l;
            ConsommationJournaliere = 0.0;
            PrixJournalier = 0.0;
        }

        #endregion

        #region Méthodes

        public object Clone()
        {
            List<CRoom> lTemp = new List<CRoom>();

            foreach (CRoom P in ListePiece)
            {
                CRoom pieceTemp = (CRoom)P.Clone();
                lTemp.Add(pieceTemp);
            }

            return new CFloor(this.NomEtage, lTemp);
        }

        public void calculerConsommationJournaliere()
        {
            if (ListePiece.Count > 0)
            {
                foreach (CRoom P in ListePiece)
                {
                    ConsommationJournaliere += P.ConsommationJournaliere;
                }
            }
        }

        public void calculerPrixJournalier()
        {
            if (ListePiece.Count > 0)
            {
                foreach (CRoom P in ListePiece)
                {
                    PrixJournalier += P.PrixJournalier;
                }
            }
        }

        #endregion
    }
}
