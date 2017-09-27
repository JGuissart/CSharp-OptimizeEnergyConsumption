using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsumptionLib
{
    public class CAutorisation
    {
        #region Variables Membres

        [XmlIgnore] // Ignore l'attribut suivant lors de la (dé)sérialisation (Dictionary ne se sérialise pas)
        private Dictionary<String, int> _Dictionnaire = new Dictionary<string, int>();

        private String[] _TabHeure = new String[48];
        private bool[] _TabBool = new bool[48];

        #endregion

        #region Propriétés

        [XmlIgnore]
        public Dictionary<String, int> Dictionnaire
        {
            get { return _Dictionnaire; }
            set { _Dictionnaire = value; }
        }

        public String[] TabHeure
        {
            get { return _TabHeure; }
            set { _TabHeure = value; }
        }

        public bool[] TabBool
        {
            get { return _TabBool; }
            set { _TabBool = value; }
        }

        #endregion

        #region Consructeurs

        public CAutorisation()
        {
            for (int i = 0; i < 24; i++)
            {
                TabHeure[i * 2] = i.ToString() + "h";
                TabHeure[i * 2 + 1] = i.ToString() + "h30";

                Dictionnaire[TabHeure[i * 2]] = i * 2;
                Dictionnaire[TabHeure[i * 2 + 1]] = i * 2 + 1;
            }
        }

        #endregion

        #region Indexeur

        public bool this[string key]
        {
            get
            {
                int[] span = ToSpan(key);

                //for (int i = span[0]; i < span[1]; i++)
                //    if (TabBool[i] == false)
                //        return false;

                //return true;

                return TabBool[span[0]];
            }

            set
            {
                int[] span = ToSpan(key);

                for (int i = span[0]; i < span[1]; i++)
                    TabBool[i] = value;
            }
        }

        #endregion

        #region Méthode

        int[] ToSpan(string key)
        {
            String[] split = key.Split('-');

            if (split.Length >= 2)
                return new int[2] { Dictionnaire[split[0]], Dictionnaire[split[1]] };
            else
                return new int[2] { Dictionnaire[split[0]], 48 };
        }

        #endregion
    }
}
