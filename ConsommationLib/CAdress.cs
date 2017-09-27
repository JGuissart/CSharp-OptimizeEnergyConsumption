using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumptionLib
{
    public class CAdress
    {
        #region Variables membres

        String _Rue;
        int _Numero;
        int _CodePostal;
        String _Localite;

        #endregion

        #region Propriétés

        public String Rue
        {
            get { return _Rue; }
            set { _Rue = value; }
        }

        public int Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public int CodePostal
        {
            get { return _CodePostal; }
            set { _CodePostal = value; }
        }

        public String Localite
        {
            get { return _Localite; }
            set { _Localite = value; }
        }

        #endregion

        #region Constructeurs

        public CAdress()
        {
            Rue = "Default";
            Numero = 0;
            CodePostal = 1000;
            Localite = "Default";
        }

        public CAdress(String r, int n, int CP, String l)
        {
            Rue = r;
            Numero = n;
            CodePostal = CP;
            Localite = l;
        }

        #endregion

        #region Méthodes

        public override string ToString()
        {
            return Rue + ", " + Numero.ToString() + ", " + CodePostal.ToString() + " " + Localite;
        }

        #endregion
    }
}
