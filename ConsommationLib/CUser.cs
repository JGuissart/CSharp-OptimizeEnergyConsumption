using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsumptionLib
{
    public class CUser : ICloneable
    {
        #region Variables membres

        private String _Login;
        private String _Password;
        
        [XmlIgnore]
        private List<CHouse> _ListeMaison;

        #endregion

        #region Propriétés

        public String Login
        {
            get { return _Login; }
            set { _Login = value; }
        }

        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        [XmlIgnore]
        public List<CHouse> ListeMaison
        {
            get { return _ListeMaison; }
            set { _ListeMaison = value; }
        }

        #endregion

        #region Constructeurs

        public CUser()
        {
            Login = "Admin";
            Password = "Admin";
            ListeMaison = new List<CHouse>();
        }

        public CUser(String l)
        {
            Login = l;
            Password = "default";
            ListeMaison = new List<CHouse>();
        }

        public CUser(String l, String mdp)
        {
            Login = l;
            Password = mdp;
            ListeMaison = new List<CHouse>();
        }

        public CUser(String l, String mdp, List<CHouse> lMaison) : this(l, mdp)
        {
            ListeMaison = lMaison;
        }

        #endregion

        #region Méthodes

        public override string ToString()
        {
            return "Login: " + Login + " | Mot de passe: *******";
        }

        public object Clone()
        {
            List<CHouse> lTemp = new List<CHouse>();

            foreach (CHouse M in ListeMaison)
            {
                CHouse maisonTemp = (CHouse)M.Clone();
                lTemp.Add(maisonTemp);
            }

            return new CUser(this.Login, this.Password, lTemp);
        }

        #endregion
    }
}
